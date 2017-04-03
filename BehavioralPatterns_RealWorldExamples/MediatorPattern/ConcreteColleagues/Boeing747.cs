using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediatorPattern.ColleagueBase;
using MediatorPattern.MediatorBase;

namespace MediatorPattern.ConcreteColleagues
{
    public class Boeing747: Aircraft
    {
        public Boeing747(string registrationNumber, IAirTrafficControl atc) : base(registrationNumber, atc)
        {
        }
    }


}
