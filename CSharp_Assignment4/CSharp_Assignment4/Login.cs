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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_User_Name.Text == "Admin" && txt_Password.Text == "Admin")
            {
                MainWindows screen = new MainWindows(/*txt_User_Name.Text*/);
                screen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid");
            }
            
        }
    }
}
