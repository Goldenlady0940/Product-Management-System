using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


//using lab4_windows_gui.Model;
//@ to ignor escae character
//$ 

namespace CSharp_Assignment4
{
    public partial class Form1 : Form
    {
        public Form1(/*string Name*/)
        {
            InitializeComponent();
            //lbl_User.Text = Name;  
        }
        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            //Regex re = new Regex(@"^[0 - 9]{ 3 } - [0 - 9]{3}$");
            //1st
            // string  name = txt_name.Text;
            // MessageBox.Show("Hello " + name);
            //2nd
            // string msg = "hello" + txt_Number.Text;
            //MessageBox.Show(msg);
            //3rd
            //concatination endaybeza use below
            //.Show ($"hello {txt_Number.Text} how u doing");
            if (string.IsNullOrEmpty(txt_Number.Text))
            {
                errorProvider1.SetError(txt_Number, "Number required");
                //MessageBox.Show("Please enter Number");
            }
            else if (string.IsNullOrEmpty(txt_Inventory.Text))
            {
                errorProvider1.SetError(txt_Inventory, "Number required");
                //MessageBox.Show("Please enter Inventroy Number");
            }
            else if (string.IsNullOrEmpty(txt_Object.Text))
            {
                errorProvider1.SetError(txt_Object, "Object Name required");
                //MessageBox.Show("Please enter Object name");
            }
            else if (string.IsNullOrEmpty(txt_Count.Text))
            {
                errorProvider1.SetError(txt_Count, "Count required");
                //MessageBox.Show("Please enter Count");
            }
            else if (string.IsNullOrEmpty(txt_Price.Text))
            {
                errorProvider1.SetError(txt_Price, "Price required");
                //MessageBox.Show("Please enter Price");
            }
           /* else if (!re.IsMatch(txt_Price.Text))
            {
                errorProvider1.SetError(txt_Price, "Price formate error");
            }*/
            else
            {
               // errorProvider1.Clear();

                try
                {
                    Product p = new Product
                    {

                        Number = int.Parse(txt_Number.Text),
                        Date = DatePicker1.Value,
                        Inventory_Number = int.Parse(txt_Number.Text),
                        Object_Name = txt_Object.Text,
                        Count = int.Parse(txt_Count.Text),
                        Price = int.Parse(txt_Price.Text),
                        isAvailable = check_Availability.Checked,
                        rad_NonPlastic = rad_NonPlastic.Checked,
                        rad_Plastic = rad_Plastic.Checked
                    };

                    p.save();
                    DataGridView.DataSource = null;
                    DataGridView.DataSource = Product.GetAllProduct(); //takes the data to be provided

                    string checkedItems = "";
                    foreach (var item in check_List.CheckedItems)
                    {
                        checkedItems += item.ToString() + " ";
                    }
                    MessageBox.Show(checkedItems);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                };
            }




        }
    }
}
