using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatorPattern.ColleagueBase;

namespace MediatorPattern.MediatorBase
{
    public interface IAirTrafficControl
    {
        void RegistrerAircraft(Aircraft aircraft);

        void SendWarningMessage(Aircraft aircraft);
    }
}
