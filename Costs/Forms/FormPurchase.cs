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
    public partial class FormPurchase : Form
    {
        public Purchase EditedPurchase;

        public FormPurchase()
        {
            Init();

            EditedPurchase = new Purchase();
        }

        public FormPurchase(Purchase purchase)
        {
            Init();

            EditedPurchase = purchase;

            cbItem.SelectedItem = purchase.Item;
            cbShop.SelectedItem = purchase.Shop;
            nudVolume.Value = (decimal)purchase.Volume;
            nudPrice.Value = (decimal)purchase.Price;
            nudActualCost.Value = (decimal)purchase.ActualCost;
            dtpDate.Value = purchase.Date;
            tbComment.Text = purchase.Comment;
        }

        private void Init()
        {
            InitializeComponent();

            CostCollection costCollection = CostCollection.GetInstance();

            costCollection.Items.FindAll(i => !costCollection.Items.Exists(it => it.Parent == i)).ForEach(i => cbItem.Items.Add(i));
            costCollection.Shops.ForEach(s => cbShop.Items.Add(s));
        }
        
        private void CalculatePrice()
        {
            nudPrice.Value = nudCalculatedCost.Value / nudVolume.Value;
        }

        private void CalculateCost()
        {
            nudCalculatedCost.Value = nudPrice.Value * nudVolume.Value;
        }

        private void CalculateOverCost()
        {
            nudOverCost.Value = nudActualCost.Value - nudCalculatedCost.Value;
        }

        private void nudVolume_ValueChanged(object sender, EventArgs e)
        {
            CalculateCost();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {
            CalculateCost();
        }

        private void nudActualCost_ValueChanged(object sender, EventArgs e)
        {
            CalculateOverCost();
        }

        private void nudCalculatedCost_ValueChanged(object sender, EventArgs e)
        {
            CalculatePrice();
            nudActualCost.Value = nudCalculatedCost.Value;
            CalculateOverCost();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (cbItem.SelectedItem == null)
            {
                MessageBox.Show("Не выбран товар");
                return;
            }

            if (cbShop.SelectedItem == null)
            {
                MessageBox.Show("Не выбран магазин");
                return;
            }

            EditedPurchase.Date = dtpDate.Value.Date;
            EditedPurchase.Item = (Item)cbItem.SelectedItem;
            EditedPurchase.Shop = (Shop)cbShop.SelectedItem;
            EditedPurchase.ActualCost = (float)nudActualCost.Value;
            EditedPurchase.Price = (float)nudPrice.Value;
            EditedPurchase.Volume = (float)nudVolume.Value;
            EditedPurchase.Comment = tbComment.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
