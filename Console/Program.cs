using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using StructureMap;
using DataAccessLayer.Contract;
using DataAccessLayer.Entity;

namespace Console
{
    public class Program
    {
        IRepositoryFactory _repositoryFactory;

        public Program(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public Customer GetCustomer()
        {
            var customerRepo = _repositoryFactory.GetRepository<CustomerRepository>();
            return customerRepo.Get(1);
        }

        public Item GetItem()
        {
            var itemRepo = _repositoryFactory.GetRepository<ItemRepository>();
            return itemRepo.Get(1);
        }

        static void Main(string[] args)
        {
            BootStrapper.Execute();

            var p = new Program(ObjectFactory.GetInstance<IRepositoryFactory>());           
        }
    }
}