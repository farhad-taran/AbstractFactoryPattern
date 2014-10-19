using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : IRepository<Customer>
    {
        public Customer Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            return new Customer();
        }
    }
}
