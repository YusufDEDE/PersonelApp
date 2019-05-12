using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
    public class Personel
    {
        public Personel()
        {
            Department = new Department();
            DepatmentID = Department.Id;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DepatmentID { get; set; }
        public Department Department { get; set; }
    }
}
