using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_Assignment4
{
    internal class Student
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Gender { get; set; }
        public DateTime Date_Of_Registeration { get; set; }
        public string Field { get; set; }

        public void Register()
        {
            MessageBox.Show("Registered Successfully!");
        }

        public void Cancel()
        {
            MessageBox.Show("Exited");
        }
    }
}
