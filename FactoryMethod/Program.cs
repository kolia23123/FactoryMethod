using System;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.BuySomething();
        }
    }
}