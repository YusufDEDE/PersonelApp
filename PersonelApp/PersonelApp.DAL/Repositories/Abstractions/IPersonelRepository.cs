using PersonelApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL.Repositories.Abstractions
{
    public interface IPersonelRepository : IRepository<Personel>
    {
        IEnumerable<Personel> GetPersonelsWithDepartments();
    }
}
