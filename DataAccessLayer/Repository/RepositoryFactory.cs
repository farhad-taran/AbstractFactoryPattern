using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class RepositoryFactory: IRepositoryFactory
    {
        public T GetRepository<T>() where T : IRepository
        {
            return ObjectFactory.GetInstance<T>();
        }
    }
}
