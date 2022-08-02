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
                Product.findOne(Products.Object_Name);
            }
        }
    }
}
