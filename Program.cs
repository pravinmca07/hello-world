using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMathod;
using BussinesLibrary;
namespace FactoryMathod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var broker = BrokerFactory.GetBroker(AirlineType.AIRASIA);

            var a = new Program().Add(1, 2, 3);
            ///var b = new Program().Add(2, 3, 50,34,34,343,43,43,43,4);
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a,  params int[] c)
        {
            return a +  c[0];
        }
    }
}
