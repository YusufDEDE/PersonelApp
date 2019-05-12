using PersonelApp.DAL.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository DepartmentRepository { get; }
        IPersonelRepository PersonelRepository { get;  }
        int Complate();
    }
}
