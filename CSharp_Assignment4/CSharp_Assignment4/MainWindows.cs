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
    public partial class MainWindows : Form
    {
        public MainWindows()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //add mainstrip
            //isMdi = true form display lemadreg space provide yadergal
            //Formboarderstyle = non. minimiz maximize mnamn lematfat
            //start position = center. same position endihone
            if (this.ActiveMdiChild != null)//mdi form lay active yehonewn
            {
                ActiveMdiChild.Close();
            }
            Form1 form1 = new Form1();
            form1.MdiParent = this; // ezaw form wst display endihone
            form1.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                Search search = new Search();
                search.MdiParent = this;
                search.Show();
                
        }
    }
}
/*
 * for each has no iterantion variable just listu eskiyalk
 * public static Product findone(string name)
 * return products.Find(p =>p.nmae == name).. p iteration value.. set yderegbtal
 * form txt search yetebale txtbox n button
 * Product.findone(txt_search.Text)
 * if(Product == null)
 * Messagebob("not found)
 * else...
 * multiple form create adergen search 
 */