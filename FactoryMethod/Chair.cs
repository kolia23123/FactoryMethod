using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Chair : IProduct
    {
        public string GetName()
        {
            return "Chair";
        }
    }
}
