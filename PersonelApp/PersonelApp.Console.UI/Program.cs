using PersonelApp.DAL;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonelContext());

            /*unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name ="Muhasebe",
                IsActive = true,
                CreatedTime =DateTime.Now
            });
            unitOfWork.DepartmentRepository.Add(new Department()
            {
                Name = "Pazarlama",
                IsActive = true,
                CreatedTime = DateTime.Now
            });*/

            
            unitOfWork.DepartmentRepository.GetAll().ToList();
            
            
        }
    }
}
