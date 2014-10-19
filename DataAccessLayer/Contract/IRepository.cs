using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IRepository
    {
        //Empty base interface in case of any future changes to the contract 
    }

    public interface IRepository<T>: IRepository where T : class, new()
    {
        T Add(T entity);
        T Update(T entity);
        T Remove(int id);
        T Get(int id);
    }
}
