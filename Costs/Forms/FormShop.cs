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
    public partial class FormShop : Form
    {
        public Shop EditedShop;

        public FormShop()
        {
            InitializeComponent();

            EditedShop = new Shop();
        }

        public FormShop(Shop shop)
        {
            InitializeComponent();

            EditedShop = shop;

            tbShopName.Text = shop.Name;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedShop.Name = tbShopName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
