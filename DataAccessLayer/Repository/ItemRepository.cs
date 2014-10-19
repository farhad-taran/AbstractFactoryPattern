using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ItemRepository: IRepository<Item>
    {
        public Item Add(Item entity)
        {
            throw new NotImplementedException();
        }

        public Item Update(Item entity)
        {
            throw new NotImplementedException();
        }

        public Item Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Item Get(int id)
        {
            return new Item();
        }
    }
}
