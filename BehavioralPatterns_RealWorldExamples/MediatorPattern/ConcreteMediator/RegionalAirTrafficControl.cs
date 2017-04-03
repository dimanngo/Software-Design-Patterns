using System;
using System.Collections.Generic;
using System.Linq;
using MediatorPattern.ColleagueBase;
using MediatorPattern.MediatorBase;

namespace MediatorPattern.ConcreteMediator
{
    public class RegionalAirTrafficControl : IAirTrafficControl
    {
        readonly List<Aircraft> _registeredAircrafts = new List<Aircraft>();

        public void RegistrerAircraft(Aircraft aircraft)
        {
            if (!_registeredAircrafts.Contains(aircraft))
            {
                _registeredAircrafts.Add(aircraft);
            }
        }

        public void SendWarningMessage(Aircraft aircraft)
        {
            var list = from a in _registeredAircrafts
                       where a != aircraft &&
                             Math.Abs(a.Altitude - aircraft.Altitude) < 1000
                       select a;
            foreach (var a in list)
            {
                a.ReceiveWarning(aircraft);
                aircraft.Climb(1000);
            }
        }
    }
}
