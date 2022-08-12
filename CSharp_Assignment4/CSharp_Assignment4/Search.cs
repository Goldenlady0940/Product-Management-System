using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Assignment4
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void lbl_Search_Click(object sender, EventArgs e)
        {
            var Products = Product.findOne(txt_Search.Text);
            if (Products == null)
            {
                MessageBox.Show("not found");
            }
            else
            {
                MessageBox.Show("Found");
                Product.findOne(Products.Object_Name);
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Product.GetAllProduct())
            {
                ProductCard pro = new ProductCard();
                pro.Product_Name = item.Object_Name;
                pro.Product_Inventory = item.Inventory_Number;
                pro.Count = item.Count;
                pro.Price = item.Price;

                flowLayoutPanel1.Controls.Add(pro);
            }
        }

       
    }
}
