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

                pro.Click += (object P, EventArgs e2) =>
                {
                    Product_Detail pd = new Product_Detail(item.Object_Name, item.Inventory_Number, item.Count, item.Price, item.Date, item.Number);
                    pd.Show();
                };
                flowLayoutPanel1.Controls.Add(pro);
            }
        }

       
    }
}
