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
    public partial class Form_Panel : Form
    {
        public Form_Panel()
        {
            InitializeComponent();
        }
        //figma
        //Adobe xd
        //Dribble
        private void btn_Add_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            Indicator_panel3.Location = new Point(29, 62);
            //panel2.Visible = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            panel2.BackColor= Color.SpringGreen;
            Indicator_panel3.Location = new Point(26, 118);
            //panel2.Visible = true;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            Indicator_panel3.Location = new Point(26, 173);
        }

        private void Indicator_panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Green;
            Indicator_panel3.Location = new Point(23, 223);
        }
    }
}
