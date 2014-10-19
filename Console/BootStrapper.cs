using DataAccessLayer;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class BootStrapper
    {
        public static void Execute()
        {
            ObjectFactory.Configure(f =>
            {
                f.For<IRepositoryFactory>().Use<RepositoryFactory>();
            }); 
        }
    }
}
