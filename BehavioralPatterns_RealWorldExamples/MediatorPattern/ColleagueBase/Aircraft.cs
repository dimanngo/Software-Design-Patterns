using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatorPattern.MediatorBase;

namespace MediatorPattern.ColleagueBase
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _atc;
        private int _altitude;

        public string RegistrationNumber { get; set; }

        public int Altitude
        {
            get { return _altitude; }
            set
            {
                _altitude = value;
                _atc.SendWarningMessage(this);
            }
        }

        public Aircraft(string registrationNumber, IAirTrafficControl atc)
        {

            RegistrationNumber = registrationNumber;
            _atc = atc;
            _atc.RegistrerAircraft(this);
        }

        public void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }

        public void ReceiveWarning(Aircraft reportingAircraft)
        {
            Console.WriteLine("ATC: ({0}) - {1} is at your flight altitude!!!",this.RegistrationNumber,reportingAircraft.RegistrationNumber);
        }
    }
}
