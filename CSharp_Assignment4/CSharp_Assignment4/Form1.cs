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
        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = Product.GetAllProduct();
            DataGridView.ClearSelection();
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
            }
            else if (string.IsNullOrEmpty(txt_Inventory.Text))
            {
                errorProvider1.SetError(txt_Inventory, "Number required");
            }
            else if (string.IsNullOrEmpty(txt_Object.Text))
            {
                errorProvider1.SetError(txt_Object, "Object Name required");
            }
            else if (string.IsNullOrEmpty(txt_Count.Text))
            {
                errorProvider1.SetError(txt_Count, "Count required");
            }
            else if (string.IsNullOrEmpty(txt_Price.Text))
            {
                errorProvider1.SetError(txt_Price, "Price required");
            }
           /* else if (!re.IsMatch(txt_Price.Text))
            {
                errorProvider1.SetError(txt_Price, "Price formate error");
            }*/
            else
            {
                try
                {
                    Product p = new Product
                    {

                        Number = int.Parse(txt_Number.Text),
                        Date = DatePicker1.Value,
                        Inventory_Number = int.Parse(txt_Inventory.Text),
                        Object_Name = txt_Object.Text,
                        Count = int.Parse(txt_Count.Text),
                        Price = int.Parse(txt_Price.Text),
                        isAvailable = check_Availability.Checked,
                        rad_Plastic = rad_Plastic.Checked
                    };

                    p.save();
                    DataGridView.DataSource = null;
                    DataGridView.DataSource = Product.GetAllProduct(); //takes the data to be provided
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Product pro = Product.findOne(txt_Search.Text) as Product;
                Product updatedProduct = new Product
                {
                    Number = int.Parse(txt_Number.Text),
                    Date = DatePicker1.Value,
                    Inventory_Number = int.Parse(txt_Inventory.Text),
                    Object_Name = txt_Object.Text,
                    Count = int.Parse(txt_Count.Text),
                    Price = int.Parse(txt_Price.Text),
                    isAvailable = check_Availability.Checked,
                    rad_Plastic = rad_Plastic.Checked
                };
                pro.updateProduct(updatedProduct);

                //refresh dgv
                DataGridView.DataSource = null;
                DataGridView.DataSource = Product.GetAllProduct();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Product.deleteProduct(int.Parse(txt_Number.Text));
            MessageBox.Show("Deleted Successfully");
            //refresh dgv
            DataGridView.DataSource = null;
            DataGridView.DataSource = Product.GetAllProduct();
            clear();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                var pro = Product.findOne(txt_Search.Text);
                if (pro == null)
                {
                    MessageBox.Show("Not Found!");
                }
                else
                {
                    txt_Number.Text = pro.Number.ToString();
                    txt_Inventory.Text = pro.Inventory_Number.ToString();
                    txt_Object.Text = pro.Object_Name.ToString();
                    txt_Price.Text = pro.Price.ToString();
                    txt_Count.Text = pro.Count.ToString();
                    DatePicker1.Value = pro.Date;
                    check_Availability.CheckState = (CheckState)Convert.ToInt32(pro.isAvailable);
                    rad_Plastic.Checked = pro.rad_Plastic;
                   }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        
        public void clear()
        {
            txt_Number.Clear();
            txt_Inventory.Clear();
            txt_Object.Clear();
            txt_Price.Clear();
            txt_Count.Clear();
            DatePicker1.Value = DateTime.Now;
            check_Availability.CheckState = 0;
            rad_Plastic.Checked = false;
        }
    }
}