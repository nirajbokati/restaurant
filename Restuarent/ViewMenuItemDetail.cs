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
    public partial class ViewMenuItemDetail : UserControl
    {
        public ViewMenuItemDetail()
        {
            InitializeComponent();
        }

        private void textBoxTotalPriceValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPriceValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void labelPrice_Click(object sender, EventArgs e)
        {

        }

        public string IdValue
        {
            get { return textBoxIDValue.Text; }
            set { textBoxIDValue.Text = value; }
        }
        public string ItemNameValue
        {
            get { return textBoxItemNameValue.Text; }
            set { textBoxItemNameValue.Text = value; }
        }
        public string CotegoryTypeValue
        {
            get { return textBoxcategoryTypeValue.Text; }
            set { textBoxcategoryTypeValue.Text = value; }
        }
        public string PriceValue
        {
            get { return textBoxPriceValue.Text; }
            set { textBoxPriceValue.Text = value; }
        }
        public string TotalPriceValue
        {
            get { return textBoxTotalPriceValue.Text; }
            set { textBoxTotalPriceValue.Text = value; }
        }
        public string QuantityValue
        {
            get { return textboxquantityValue.Text; }
            set { textboxquantityValue.Text = value; }
        }
    }
}
