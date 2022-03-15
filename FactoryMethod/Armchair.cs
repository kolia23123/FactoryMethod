using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Armchair : IProduct
    {
        public string GetName()
        {
            return "Armchair";
        }
    }
}
