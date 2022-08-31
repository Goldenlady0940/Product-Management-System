using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSharp_Assignment4
{
    class Product
    {
        string connection = @"Data Source=DESKTOP-O813SED\SQLEXPRESS;Initial Catalog=CCONNECTION;Integrated Security=True";
        static private List<Product> Products = new List<Product>();

        public int Number { get; set; }

        public DateTime Date { get; set; }

        public int Inventory_Number { get; set; }

        public string Object_Name { get; set; }

        public int Count { get; set; }

        public int Price { get; set; }
        public bool isAvailable { get; set; }
        public bool rad_Plastic { get; set; }
        public bool rad_NonPlastic { get; set; }

       
        public static Product findOne(string name)//for search
        {
            return Products.Find(p => p.Object_Name == name); // arrow function
        }
        //new get manager
        //class product extend entity
        public void save()
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string Query = "INSERT INTO PRODUCT VALUES (" + this.Number + ",'" + this.Date + "'," + this.Inventory_Number + ",'" + this.Object_Name + "'," + this.Count + "," + this.Price + ",'" + this.isAvailable + "','" + this.rad_Plastic + "');";//this.Productname
            SqlCommand cmd = new SqlCommand(Query, con);
            /*
             * sql injection attack user yerasu query indayasgeba
             * string Query = "INSERT INTO PRODUCT VALUES (@name,@int)
             * SqlCommand cmd = new SqlCommand(Query, con);
             * cmd.parameters.AddValluewith("@name",this.name)//@--is the parameter and this.name is to replace the 
             * */
            var result = cmd.ExecuteNonQuery();
            con.Close();
            //Products.Add(this);
            //MessageBox.Show("connected");

        }
        public static List<Product> GetAllProduct()
        {
            string connection = @"Data Source=DESKTOP-O813SED\SQLEXPRESS;Initial Catalog=CCONNECTION;Integrated Security=True";

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string Query = "SELECT * FROM PRODUCT";//this.Productname
            SqlCommand cmd = new SqlCommand(Query, con);
            var result = cmd.ExecuteReader();
            List<Product> temp = new List<Product>();
            while (result.Read())
            {
                Product p = new Product();
                p.Number = (int)result["ID"];//result[0] or
                p.Date = (DateTime)result["DAT"];
                p.Inventory_Number = (int)result["INV_NUM"];
                p.Object_Name = (string)result["NAME"];
                p.Count = (int)result["COUN"];
                p.Price = (int)result["PRICE"];
                p.isAvailable = Convert.ToBoolean(result["AVAILABILITY"]);
                p.rad_Plastic = Convert.ToBoolean(result["PLASTIC"]);
                p.rad_NonPlastic = !(Convert.ToBoolean(result["PLASTIC"]));
                temp.Add(p);
            }
            con.Close();
            return temp;
            // return Products;
        }

    }
}
