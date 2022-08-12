using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public double Price { get; set; }
        public bool isAvailable { get; set; }
        public bool rad_Plastic { get; set; }
        public bool rad_NonPlastic { get; set; }

       
        public static Product findOne(string name)//for search
        {
            return Products.Find(p => p.Object_Name == name); // arrow function
        }

        public void save()
        {
            Products.Add(this);
            //MessageBox.Show("Saved Successfully");
        }
        public static List<Product> GetAllProduct()
        {
            return Products;
        }

    }
}
