using Costs.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms
{
    public partial class FormMain : Form
    {
        private const string ALL = "Все";

        public FormMain()
        {
            InitializeComponent();

            dgvPurchases.AutoGenerateColumns = false;
            dgvShops.AutoGenerateColumns = false;

            tscbFilter.SelectedIndex = 0;
            tscbFilter.SelectedIndexChanged += TscbFilter_SelectedIndexChanged;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CostCollection costCollection = CostCollection.GetInstance();

            RefreshPurchases();
            RefreshItems();
            dgvShops.DataSource = new List<Shop>(costCollection.Shops);
        }

        private void RefreshPurchases()
        {
            List<Purchase> purchases = new List<Purchase>(CostCollection.GetInstance().Purchases);

            if (tcMain.SelectedTab == tpItems)
            {
                if (tvItems.SelectedNode != null && tvItems.SelectedNode.Text != ALL)
                    purchases.RemoveAll(p => !CostCollection.IsPurchaseOfItemBranch((Item)tvItems.SelectedNode.Tag, p));
            }
            else if (tcMain.SelectedTab == tpShops)
            {
                Shop shop = GetSelectedShop();
                if (shop != null)
                    purchases.RemoveAll(p => p.Shop != shop);
            }

            switch (tscbFilter.SelectedIndex)
            {
                case 1: purchases.RemoveAll(p => DateTime.Now > p.Date.AddMonths(1)); break;
                case 2: purchases.RemoveAll(p => DateTime.Now > p.Date.AddYears(1)); break;
            }

            dgvPurchases.DataSource = purchases;

            float sum = 0;
            purchases.ForEach(p => sum += p.ActualCost);
            tsslSum.Text = "" + sum;
        }

        private void RefreshItems()
        {
            tvItems.Nodes.Add(new TreeNode(ALL) { Tag = new Item() { Name = ALL } });

            Dictionary<Item, TreeNode> itemNodes = new Dictionary<Item, TreeNode>();
            foreach (Item item in CostCollection.GetInstance().Items)
                itemNodes.Add(item, new TreeNode(item.Name) { Tag = item });
            foreach (Item item in CostCollection.GetInstance().Items.FindAll(i => i.Parent != null))
                itemNodes[item.Parent].Nodes.Add(itemNodes[item]);
            foreach (Item item in CostCollection.GetInstance().Items.FindAll(i => i.Parent == null))
                tvItems.Nodes.Add(itemNodes[item]);
        }

        private void tsmiPurchaseAdd_Click(object sender, EventArgs e)
        {
            FormPurchase form = new FormPurchase();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            CostCollection.Add(form.EditedPurchase);
            CostCollection.Save();
            RefreshPurchases();
        }

        private void tsmiPurchaseEdit_Click(object sender, EventArgs e)
        {
            Purchase selectedPurchase = GetSelectedPurchase();
            if (selectedPurchase == null)
                return;

            if (new FormPurchase(selectedPurchase).ShowDialog() != DialogResult.OK)
                return;

            CostCollection costCollection = CostCollection.GetInstance();
            CostCollection.Save();
            RefreshPurchases();
        }

        private void tmsiPurchaseCopy_Click(object sender, EventArgs e)
        {
            Purchase selectedPurchase = GetSelectedPurchase();
            if (selectedPurchase == null)
                return;

            CostCollection.Add(
                new Purchase()
                {
                    ActualCost = selectedPurchase.ActualCost,
                    Date = DateTime.Today,
                    Item = selectedPurchase.Item,
                    Price = selectedPurchase.Price,
                    Shop = selectedPurchase.Shop,
                    Volume = selectedPurchase.Volume
                }
            );
            CostCollection.Save();
            RefreshPurchases();
        }

        private Purchase GetSelectedPurchase()
        {
            if (dgvPurchases.SelectedRows.Count == 0 || dgvPurchases.SelectedRows[0].Index == -1)
                return null;

            return dgvPurchases.SelectedRows[0].DataBoundItem as Purchase;
        }

        private void tsmiShopAdd_Click(object sender, EventArgs e)
        {
            FormShop form = new FormShop();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            CostCollection.Add(form.EditedShop);
            CostCollection.Save();
            dgvShops.DataSource = new List<Shop>(CostCollection.GetInstance().Shops);
        }

        private void tsmiShopEdit_Click(object sender, EventArgs e)
        {
            Shop selectedShop = GetSelectedShop();
            if (selectedShop == null)
                return;

            if (new FormShop(selectedShop).ShowDialog() != DialogResult.OK)
                return;

            CostCollection.Save();
            dgvShops.DataSource = new List<Shop>(CostCollection.GetInstance().Shops);
        }

        private Shop GetSelectedShop()
        {
            if (dgvShops.SelectedRows.Count == 0 || dgvShops.SelectedRows[0].Index == -1)
                return null;

            return dgvShops.SelectedRows[0].DataBoundItem as Shop;
        }

        private void tsmiItemAdd_Click(object sender, EventArgs e)
        {
            FormItem form = new FormItem();
            if (form.ShowDialog() != DialogResult.OK)
                return;

            CostCollection.Add(form.EditedItem);
            CostCollection.Save();
            tvItems.Nodes.Add(new TreeNode(form.EditedItem.Name) { Tag = form.EditedItem });
        }

        private void tsmiItemEdit_Click(object sender, EventArgs e)
        {
            if (tvItems.SelectedNode == null || tvItems.SelectedNode.Text == ALL || !(tvItems.SelectedNode.Tag is Item))
                return;
            Item selectedItem = tvItems.SelectedNode.Tag as Item;
            if (selectedItem == null)
                return;

            if (new FormItem(selectedItem).ShowDialog() != DialogResult.OK)
                return;

            CostCollection costCollection = CostCollection.GetInstance();
            CostCollection.Save();
            tvItems.SelectedNode.Text = selectedItem.Name;
        }

        #region DragDrop

        private void tvItems_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Item is TreeNode && (e.Item as TreeNode).Text != ALL)
                DoDragDrop(e.Item, DragDropEffects.All);
        }

        private void tvItems_DragDrop(object sender, DragEventArgs e)
        {
            Point targetPoint = tvItems.PointToClient(new Point(e.X, e.Y));
            TreeNode targetNode = tvItems.GetNodeAt(targetPoint);
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            if (draggedNode != targetNode)
                MoveNode(draggedNode, targetNode);
            e.Effect = DragDropEffects.None;
        }

        private void MoveNode(TreeNode nodeToMove, TreeNode newParent)
        {
            nodeToMove.Remove();

            if (newParent != null && newParent.Text != ALL)
            {
                newParent.Nodes.Add(nodeToMove);
                ((Item)nodeToMove.Tag).Parent = (Item)newParent.Tag;
            }
            else
            {
                tvItems.Nodes.Add(nodeToMove);
                ((Item)nodeToMove.Tag).Parent = null;
                ((Item)nodeToMove.Tag).ParentId = -1;
            }
            CostCollection.Save();
        }

        private void tvItems_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        #endregion

        private void tvItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshPurchases();
        }

        private void dgvShops_SelectionChanged(object sender, EventArgs e)
        {
            RefreshPurchases();
        }

        private void TscbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPurchases();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPurchases();
        }
    }
}

// круговая диаграмма по магазинам
// многоуровневая круговая диаграмма по товарам