using DataAccessLayer;
using DataAccessLayer.Entity;
using DataAccessLayer.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Sales
    {
        IRepository<Item> _itemRepository; 
        IRepository<Customer> _customerRepository; 
        
        public Sales(IItemRepository itemRepository, ICustomerRepository customerRepository)
        {
            _itemRepository = itemRepository;
            _customerRepository = customerRepository;
        }
    }
}
