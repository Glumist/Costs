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
    public partial class FormItem : Form
    {
        public Item EditedItem;

        public FormItem()
        {
            InitializeComponent();

            EditedItem = new Item();
        }

        public FormItem(Item item)
        {
            InitializeComponent();

            EditedItem = item;

            tbItemName.Text = item.Name;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            EditedItem.Name = tbItemName.Text;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}