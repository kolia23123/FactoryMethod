using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Creator
    {
        abstract public IProduct FactoryMethod();

        public string BuyProduct()
        {
            var product = FactoryMethod();

            return product.GetName();
        }
    }
}
