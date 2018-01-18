namespace Costs.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.msCosts = new System.Windows.Forms.MenuStrip();
            this.tsmiPurchaseAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPurchaseEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmsiPurchaseCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbFilter = new System.Windows.Forms.ToolStripComboBox();
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            this.colCostDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostActualCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostOverCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostShop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpItems = new System.Windows.Forms.TabPage();
            this.tvItems = new System.Windows.Forms.TreeView();
            this.msTypes = new System.Windows.Forms.MenuStrip();
            this.tsmiItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tpShops = new System.Windows.Forms.TabPage();
            this.dgvShops = new System.Windows.Forms.DataGridView();
            this.colShopName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msShops = new System.Windows.Forms.MenuStrip();
            this.tsmiShopAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShopEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ssPurchases = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.msCosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tpItems.SuspendLayout();
            this.msTypes.SuspendLayout();
            this.tpShops.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShops)).BeginInit();
            this.msShops.SuspendLayout();
            this.ssPurchases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msCosts
            // 
            this.msCosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPurchaseAdd,
            this.tsmiPurchaseEdit,
            this.tmsiPurchaseCopy,
            this.tscbFilter});
            this.msCosts.Location = new System.Drawing.Point(0, 0);
            this.msCosts.Name = "msCosts";
            this.msCosts.Size = new System.Drawing.Size(760, 27);
            this.msCosts.TabIndex = 0;
            // 
            // tsmiPurchaseAdd
            // 
            this.tsmiPurchaseAdd.Image = global::Costs.Properties.Resources.IconPlus;
            this.tsmiPurchaseAdd.Name = "tsmiPurchaseAdd";
            this.tsmiPurchaseAdd.Size = new System.Drawing.Size(87, 23);
            this.tsmiPurchaseAdd.Text = "Добавить";
            this.tsmiPurchaseAdd.Click += new System.EventHandler(this.tsmiPurchaseAdd_Click);
            // 
            // tsmiPurchaseEdit
            // 
            this.tsmiPurchaseEdit.Image = global::Costs.Properties.Resources.IconEdit;
            this.tsmiPurchaseEdit.Name = "tsmiPurchaseEdit";
            this.tsmiPurchaseEdit.Size = new System.Drawing.Size(115, 23);
            this.tsmiPurchaseEdit.Text = "Редактировать";
            this.tsmiPurchaseEdit.Click += new System.EventHandler(this.tsmiPurchaseEdit_Click);
            // 
            // tmsiPurchaseCopy
            // 
            this.tmsiPurchaseCopy.Image = global::Costs.Properties.Resources.IconCopy;
            this.tmsiPurchaseCopy.Name = "tmsiPurchaseCopy";
            this.tmsiPurchaseCopy.Size = new System.Drawing.Size(100, 23);
            this.tmsiPurchaseCopy.Text = "Копировать";
            this.tmsiPurchaseCopy.Click += new System.EventHandler(this.tmsiPurchaseCopy_Click);
            // 
            // tscbFilter
            // 
            this.tscbFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbFilter.Items.AddRange(new object[] {
            "Все",
            "За месяц",
            "За год"});
            this.tscbFilter.Name = "tscbFilter";
            this.tscbFilter.Size = new System.Drawing.Size(121, 23);
            // 
            // dgvPurchases
            // 
            this.dgvPurchases.AllowUserToAddRows = false;
            this.dgvPurchases.AllowUserToDeleteRows = false;
            this.dgvPurchases.AllowUserToResizeRows = false;
            this.dgvPurchases.BackgroundColor = System.Drawing.Color.White;
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCostDate,
            this.colCostName,
            this.colCostPrice,
            this.colCostVolume,
            this.colCostActualCost,
            this.colCostOverCost,
            this.colCostShop});
            this.dgvPurchases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchases.Location = new System.Drawing.Point(0, 27);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.ReadOnly = true;
            this.dgvPurchases.RowHeadersVisible = false;
            this.dgvPurchases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchases.Size = new System.Drawing.Size(760, 564);
            this.dgvPurchases.TabIndex = 1;
            // 
            // colCostDate
            // 
            this.colCostDate.DataPropertyName = "Date";
            this.colCostDate.HeaderText = "Дата";
            this.colCostDate.Name = "colCostDate";
            this.colCostDate.ReadOnly = true;
            this.colCostDate.Width = 70;
            // 
            // colCostName
            // 
            this.colCostName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCostName.DataPropertyName = "Item";
            this.colCostName.HeaderText = "Название";
            this.colCostName.Name = "colCostName";
            this.colCostName.ReadOnly = true;
            // 
            // colCostPrice
            // 
            this.colCostPrice.DataPropertyName = "Price";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colCostPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCostPrice.HeaderText = "Цена";
            this.colCostPrice.Name = "colCostPrice";
            this.colCostPrice.ReadOnly = true;
            this.colCostPrice.Width = 60;
            // 
            // colCostVolume
            // 
            this.colCostVolume.DataPropertyName = "Volume";
            dataGridViewCellStyle2.Format = "0.###";
            dataGridViewCellStyle2.NullValue = null;
            this.colCostVolume.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCostVolume.HeaderText = "Количество";
            this.colCostVolume.Name = "colCostVolume";
            this.colCostVolume.ReadOnly = true;
            this.colCostVolume.Width = 70;
            // 
            // colCostActualCost
            // 
            this.colCostActualCost.DataPropertyName = "ActualCost";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colCostActualCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCostActualCost.HeaderText = "Потрачено";
            this.colCostActualCost.Name = "colCostActualCost";
            this.colCostActualCost.ReadOnly = true;
            this.colCostActualCost.Width = 70;
            // 
            // colCostOverCost
            // 
            this.colCostOverCost.DataPropertyName = "OverCost";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.colCostOverCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.colCostOverCost.HeaderText = "Переплата";
            this.colCostOverCost.Name = "colCostOverCost";
            this.colCostOverCost.ReadOnly = true;
            this.colCostOverCost.Width = 70;
            // 
            // colCostShop
            // 
            this.colCostShop.DataPropertyName = "Shop";
            this.colCostShop.HeaderText = "Магазин";
            this.colCostShop.Name = "colCostShop";
            this.colCostShop.ReadOnly = true;
            this.colCostShop.Width = 150;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpItems);
            this.tcMain.Controls.Add(this.tpShops);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(258, 613);
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpItems
            // 
            this.tpItems.Controls.Add(this.tvItems);
            this.tpItems.Controls.Add(this.msTypes);
            this.tpItems.Location = new System.Drawing.Point(4, 22);
            this.tpItems.Name = "tpItems";
            this.tpItems.Size = new System.Drawing.Size(250, 587);
            this.tpItems.TabIndex = 2;
            this.tpItems.Text = "Товары";
            this.tpItems.UseVisualStyleBackColor = true;
            // 
            // tvItems
            // 
            this.tvItems.AllowDrop = true;
            this.tvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvItems.Location = new System.Drawing.Point(0, 24);
            this.tvItems.Name = "tvItems";
            this.tvItems.Size = new System.Drawing.Size(250, 563);
            this.tvItems.TabIndex = 4;
            this.tvItems.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvItems_ItemDrag);
            this.tvItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvItems_AfterSelect);
            this.tvItems.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvItems_DragDrop);
            this.tvItems.DragEnter += new System.Windows.Forms.DragEventHandler(this.tvItems_DragEnter);
            // 
            // msTypes
            // 
            this.msTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiItemAdd,
            this.tsmiItemEdit});
            this.msTypes.Location = new System.Drawing.Point(0, 0);
            this.msTypes.Name = "msTypes";
            this.msTypes.Size = new System.Drawing.Size(250, 24);
            this.msTypes.TabIndex = 3;
            // 
            // tsmiItemAdd
            // 
            this.tsmiItemAdd.Image = global::Costs.Properties.Resources.IconPlus;
            this.tsmiItemAdd.Name = "tsmiItemAdd";
            this.tsmiItemAdd.Size = new System.Drawing.Size(87, 20);
            this.tsmiItemAdd.Text = "Добавить";
            this.tsmiItemAdd.Click += new System.EventHandler(this.tsmiItemAdd_Click);
            // 
            // tsmiItemEdit
            // 
            this.tsmiItemEdit.Image = global::Costs.Properties.Resources.IconEdit;
            this.tsmiItemEdit.Name = "tsmiItemEdit";
            this.tsmiItemEdit.Size = new System.Drawing.Size(115, 20);
            this.tsmiItemEdit.Text = "Редактировать";
            this.tsmiItemEdit.Click += new System.EventHandler(this.tsmiItemEdit_Click);
            // 
            // tpShops
            // 
            this.tpShops.Controls.Add(this.dgvShops);
            this.tpShops.Controls.Add(this.msShops);
            this.tpShops.Location = new System.Drawing.Point(4, 22);
            this.tpShops.Name = "tpShops";
            this.tpShops.Padding = new System.Windows.Forms.Padding(3);
            this.tpShops.Size = new System.Drawing.Size(250, 587);
            this.tpShops.TabIndex = 1;
            this.tpShops.Text = "Магазины";
            this.tpShops.UseVisualStyleBackColor = true;
            // 
            // dgvShops
            // 
            this.dgvShops.AllowUserToAddRows = false;
            this.dgvShops.AllowUserToDeleteRows = false;
            this.dgvShops.AllowUserToResizeRows = false;
            this.dgvShops.BackgroundColor = System.Drawing.Color.White;
            this.dgvShops.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShops.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colShopName});
            this.dgvShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShops.Location = new System.Drawing.Point(3, 27);
            this.dgvShops.Name = "dgvShops";
            this.dgvShops.ReadOnly = true;
            this.dgvShops.RowHeadersVisible = false;
            this.dgvShops.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShops.Size = new System.Drawing.Size(244, 557);
            this.dgvShops.TabIndex = 3;
            this.dgvShops.SelectionChanged += new System.EventHandler(this.dgvShops_SelectionChanged);
            // 
            // colShopName
            // 
            this.colShopName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colShopName.DataPropertyName = "Name";
            this.colShopName.HeaderText = "Название";
            this.colShopName.Name = "colShopName";
            this.colShopName.ReadOnly = true;
            // 
            // msShops
            // 
            this.msShops.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShopAdd,
            this.tsmiShopEdit});
            this.msShops.Location = new System.Drawing.Point(3, 3);
            this.msShops.Name = "msShops";
            this.msShops.Size = new System.Drawing.Size(244, 24);
            this.msShops.TabIndex = 2;
            // 
            // tsmiShopAdd
            // 
            this.tsmiShopAdd.Image = global::Costs.Properties.Resources.IconPlus;
            this.tsmiShopAdd.Name = "tsmiShopAdd";
            this.tsmiShopAdd.Size = new System.Drawing.Size(87, 20);
            this.tsmiShopAdd.Text = "Добавить";
            this.tsmiShopAdd.Click += new System.EventHandler(this.tsmiShopAdd_Click);
            // 
            // tsmiShopEdit
            // 
            this.tsmiShopEdit.Image = global::Costs.Properties.Resources.IconEdit;
            this.tsmiShopEdit.Name = "tsmiShopEdit";
            this.tsmiShopEdit.Size = new System.Drawing.Size(115, 20);
            this.tsmiShopEdit.Text = "Редактировать";
            this.tsmiShopEdit.Click += new System.EventHandler(this.tsmiShopEdit_Click);
            // 
            // ssPurchases
            // 
            this.ssPurchases.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslSum});
            this.ssPurchases.Location = new System.Drawing.Point(0, 591);
            this.ssPurchases.Name = "ssPurchases";
            this.ssPurchases.Size = new System.Drawing.Size(760, 22);
            this.ssPurchases.TabIndex = 2;
            this.ssPurchases.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Итого:";
            // 
            // tsslSum
            // 
            this.tsslSum.Name = "tsslSum";
            this.tsslSum.Size = new System.Drawing.Size(0, 17);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tcMain);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.dgvPurchases);
            this.scMain.Panel2.Controls.Add(this.msCosts);
            this.scMain.Panel2.Controls.Add(this.ssPurchases);
            this.scMain.Size = new System.Drawing.Size(1024, 613);
            this.scMain.SplitterDistance = 258;
            this.scMain.SplitterWidth = 6;
            this.scMain.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 613);
            this.Controls.Add(this.scMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msCosts;
            this.Name = "FormMain";
            this.Text = "Затраты";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.msCosts.ResumeLayout(false);
            this.msCosts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.tcMain.ResumeLayout(false);
            this.tpItems.ResumeLayout(false);
            this.tpItems.PerformLayout();
            this.msTypes.ResumeLayout(false);
            this.msTypes.PerformLayout();
            this.tpShops.ResumeLayout(false);
            this.tpShops.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShops)).EndInit();
            this.msShops.ResumeLayout(false);
            this.msShops.PerformLayout();
            this.ssPurchases.ResumeLayout(false);
            this.ssPurchases.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msCosts;
        private System.Windows.Forms.DataGridView dgvPurchases;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpShops;
        private System.Windows.Forms.TabPage tpItems;
        private System.Windows.Forms.ToolStripMenuItem tsmiPurchaseAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiPurchaseEdit;
        private System.Windows.Forms.DataGridView dgvShops;
        private System.Windows.Forms.MenuStrip msShops;
        private System.Windows.Forms.ToolStripMenuItem tsmiShopAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiShopEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colShopName;
        private System.Windows.Forms.MenuStrip msTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemEdit;
        private System.Windows.Forms.ToolStripMenuItem tmsiPurchaseCopy;
        private System.Windows.Forms.StatusStrip ssPurchases;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslSum;
        private System.Windows.Forms.TreeView tvItems;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostActualCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostOverCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostShop;
        private System.Windows.Forms.ToolStripComboBox tscbFilter;
    }
}

