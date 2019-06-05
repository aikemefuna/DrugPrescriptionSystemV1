using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugPrescriptionSystemVersion1.Repository.Interface
{
    public interface IRepository<T>
    {
        ICollection<T> SelectAll();
        Task<T> SelectByIdAsync(long Id);

    }
}
