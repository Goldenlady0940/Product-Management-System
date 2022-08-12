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
    public partial class ProductCard : UserControl
    {
        private string _Product_Name;
        private int _Product_Inventory;
        private Double _Price;
        private int _Count;

        public string Product_Name
        {
            get { return _Product_Name; }
            set { _Product_Name = value; lbl_Name.Text = value; }
        }

        public int Product_Inventory
        {
            get { return _Product_Inventory; }
            set { _Product_Inventory = value; lbl_Inventory.Text = value.ToString(); }
        }
        public Double Price
        {
            get { return _Price; }
            set { _Price = value; lbl_Price.Text = value.ToString(); }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; lbl_Count.Text = value.ToString(); }
        }
        public ProductCard()
        {
            InitializeComponent();//defined in the designer class
        }

        private void ProductCard_Load(object sender, EventArgs e)
        {

        }
    }
}
