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
    public partial class Product_Detail : Form
    {
        public Product_Detail(string Name, int Inventory, int Count, int Price, DateTime Date, int Number)
        {
            InitializeComponent();
            lbl_Name.Text = "Name: " + Name;
            lbl_Inventory.Text = "Inventory Number: " + Inventory.ToString();
            lbl_Count.Text = "Count: " + Count.ToString();
            lbl_Date.Text = "Date: " + Date.ToString();
            lbl_Number.Text = "Number: " + Number.ToString();
            lbl_Price.Text = "Price: " + Price.ToString();
        }

        private void Product_Detail_Load(object sender, EventArgs e)
        {

        }
    }
}
