using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLibrary
{
    public class BrokerFactory
    {
        private static IFlightBroker broker;
        public static IFlightBroker GetBroker(AirlineType type)
        {
            switch (type)
            {
                case AirlineType.AIRASIA:
                    broker = new AirAsiaBroker();
                    break;
                case AirlineType.INDIGO:
                    break;
                case AirlineType.SPICEJET:
                    break;
                case AirlineType.VISTARA:
                    break;
                default:
                    break;
            }
            return broker;
        }
    }
}
