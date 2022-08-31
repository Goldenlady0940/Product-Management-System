using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CSharp_Assignment4
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void btn_Connection_Click(object sender, EventArgs e)
        {
            try
            {
                string connection = @"Data Source = DESKTOP-O813SED\SQLEXPRESS; Initial Catalog = CCONNECTION; Integrated Security = true";
                //System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connection);
                SqlConnection con = new SqlConnection(connection);

                //belela form change the name of the form SqlConnection milew name check miyadergew error agatmot new
                 con.Open();


                //for save method
                string Query = "INSERT INTO PRODUCT VALUES (ID,'NAME')";//this.Productname
                SqlCommand cmd = new SqlCommand(Query, con);
                var result = cmd.ExecuteNonQuery();//Rows affected
                                                   //var res = cmd.ExecuteScalar();//single user
                                                   //var r = cmd.ExecuteReader();//returns table
                /*while(r.Read())
                {

                }*/
                //for getallproduct method
                /* string query = "SELECT * FRO PRODUCT";//this.Productname
                 SqlCommand cd = new SqlCommand(Query, con);
                 var resu = cmd.ExecuteReader();
                 List<Product> temp = new List<Product>();
                 while (resu.Read())
                 {
                     Product p = new Product();
                     p.ProductName = resu[0] or resu["Object_Name"]
                     resu[1]
                         temp.Add(p);

                     return temp;
                  MessageBox.Show("Connected");*/
             }
             catch
             {
                 MessageBox.Show("Unable to connect");
             };
                
            }
        }
    }

               