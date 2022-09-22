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
            List<Product> list = GetAllProduct();
            return list.Find(Pro => Pro.Object_Name == name);
        }
       
        public void save()
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.connection))
            {
                try
                {
                    con.Open();
                    string Query = "INSERT INTO PRODUCT VALUES (@ID,@DATE,@INV_NUM,@NAME,@COUNT,@PRICE,@AVAIL,@PLASTIC);";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@ID", this.Number);
                    cmd.Parameters.AddWithValue("@DATE", this.Date);
                    cmd.Parameters.AddWithValue("@INV_NUM", this.Inventory_Number);
                    cmd.Parameters.AddWithValue("@NAME", this.Object_Name);
                    cmd.Parameters.AddWithValue("@COUNT", this.Count);
                    cmd.Parameters.AddWithValue("@PRICE", this.Price);
                    //cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add("@AVAIL", System.Data.SqlDbType.VarChar).Value = this.isAvailable;//value
                    cmd.Parameters.Add("@PLASTIC", System.Data.SqlDbType.VarChar).Value = this.rad_Plastic;
                    //cmd.ExecuteScalar();
                    //spGetAllProduct

                    var result = cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                };
            }
           
            
        }
        public static List<Product> GetAllProduct()
        {

            using (SqlConnection con = new SqlConnection(ConnectionClass.connection))
            {
                try
                {
                    con.Open();
                    string Query = "SELECT * FROM PRODUCT";
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
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                };

            }
                
               // return Products;
        }
        public void updateProduct(Product updatedProduct)
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.connection))
            {
                try
                {
                    con.Open();
                    string Query = "EXEC sp_UPDATEPRODUCT @ID,@DATE,@INV_NUM,@NAME,@COUNT,@PRICE,@AVAIL,@PLASTIC";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@ID", updatedProduct.Number);
                    cmd.Parameters.AddWithValue("@DATE", updatedProduct.Date);
                    cmd.Parameters.AddWithValue("@INV_NUM", updatedProduct.Inventory_Number);
                    cmd.Parameters.AddWithValue("@NAME", updatedProduct.Object_Name);
                    cmd.Parameters.AddWithValue("@COUNT", updatedProduct.Count);
                    cmd.Parameters.AddWithValue("@PRICE", updatedProduct.Price);
                    cmd.Parameters.Add("@AVAIL", System.Data.SqlDbType.VarChar).Value = updatedProduct.isAvailable;//value
                    cmd.Parameters.Add("@PLASTIC", System.Data.SqlDbType.VarChar).Value = updatedProduct.rad_Plastic;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        public static void deleteProduct(int number)
        {
            using (SqlConnection con = new SqlConnection(ConnectionClass.connection))
            {
                try
                {
                    con.Open();
                    string Query = "EXEC spDELETEPRODUCT @ID";
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.Parameters.AddWithValue("@ID", number);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }

    }
}
