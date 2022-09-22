using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSharp_Assignment4
{
    public partial class DetailPage : Form
    {
        public DetailPage()
        {
            InitializeComponent();
        }

        

        private void Search_Load(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            foreach (var item in Product.GetAllProduct())
            {
                UCProductCard pro = new UCProductCard();
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
