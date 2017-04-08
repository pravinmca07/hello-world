using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLibrary
{
    public interface IFlightBroker
    {
        object BookFlight();
        object VerifyFlight();
    }
}
