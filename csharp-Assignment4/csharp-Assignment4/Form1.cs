using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_Assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblManagement_Click(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Student s = new Student
            {
                Name = txt_Name.Text,
                Id = int.Parse(txt_Id.Text),
                Gender = txt_Gender.Text,
                Field = txt_Field.Text,
                Date_Of_Registeration = txt_DatePicker.Value
            };
            s.Register();
            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Student s = new Student();
                s.Cancel();
        }
    }
}
