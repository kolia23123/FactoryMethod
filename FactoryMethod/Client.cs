using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Client
    {
        public void BuySomething()
        {
            Console.WriteLine("You buy :");
            
            var product1 = new ChairCreator();
            Information(product1, 1);

            var product2 = new ArmchairCreator();
            Information(product2, 2);
        }
        private void Information(Creator creator, int i)
        {
            Console.WriteLine(i + ". " + creator.BuyProduct());   
        }
    }
}
