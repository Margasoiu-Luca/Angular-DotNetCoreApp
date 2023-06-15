using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iss.AvanMagazinOnline.DB.Interfaces
{
    public interface IDBCrud<T,Id>
    {
        public Task<T> Get(Id id);
        public Task<List<T>> GetAll();
        public Task Create(T entity);
        public Task Update(T entity,Id id);
        public Task Delete(Id id);

    }
}
