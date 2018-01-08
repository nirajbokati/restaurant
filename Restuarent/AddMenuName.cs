using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restuarent
{
    public partial class AddMenuName : UserControl
    {
        public AddMenuName()
        {
            InitializeComponent();
        }
        public string menuIdinput
        {
            get { return textBoxID.Text; }
            set { textBoxID.Text = value; }
        }
        public string menuItemNameInput
        {
            get { return textBoxItemName.Text; }
            set { textBoxItemName.Text = value; }
        }
        public string categoryInput
        {
            get { return textBoxcategoryType.Text; }
            set { textBoxcategoryType.Text = value; }


        }
        public string PriceInput
        {
            get { return textBoxPrice.Text; }
            set { textBoxPrice.Text = value; }
        }
        public string totalPriceInput
        {
            get { return textBoxTotalPrice.Text; }
            set { textBoxTotalPrice.Text = value; }
        }
        public string ItemquantityInput
        {
            get { return textboxquantity.Text; }
            set { textboxquantity.Text = value; }
        }
        private void FirstCustomControl_Load(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            dataGridViewAddDisplay.Rows.Add();
            dataGridViewAddDisplay.Rows[i].Cells["ColItemID"].Value = textBoxID.Text.ToString();
            dataGridViewAddDisplay.Rows[i].Cells["ColItemName"].Value = textBoxItemName.Text;
            dataGridViewAddDisplay.Rows[i].Cells["ColPrice"].Value = textBoxPrice.Text;
            dataGridViewAddDisplay.Rows[i].Cells["ColQuantity"].Value = textboxquantity.Text;
            dataGridViewAddDisplay.Rows[i].Cells["ColTotalPrice"].Value = textBoxTotalPrice.Text;
            i++;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void textboxquantity_TextChanged(object sender, EventArgs e)
        {
            if (textboxquantity.Text.Length > 0)
            {
                Int32 a = Convert.ToInt32(textBoxPrice.Text);
                Int32 b = Convert.ToInt32(textboxquantity.Text);
                Int32 c = a * b;
                textBoxTotalPrice.Text = c.ToString();
            }
        }

        private void textboxquantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.Select();
            }
        }
    }
}
