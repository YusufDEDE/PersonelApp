using PersonelApp.DAL.Repositories.Abstractions;
using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Concrates
{
    public class DepartmentsRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentsRepository(PersonelContext context) : base(context)
        {
            
        }
        public IEnumerable<Department> GetDepartments(int count)
        {
            return PersonelContext.Departments.Take(count);
        }

        public IEnumerable<Department> GetDepartmentsWithPersonels()
        {
            
            return PersonelContext.Departments.Include("Personels").ToList();
        }

        public PersonelContext PersonelContext { get { return _context as PersonelContext; } }
    }
}
