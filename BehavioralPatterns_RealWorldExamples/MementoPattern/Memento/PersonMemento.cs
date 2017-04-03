using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern.Memento
{
    public class PersonMemento
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string CellPhone { get; private set; }
        public string Address { get; private set; }

        public PersonMemento(string fName, string lName, string cell, string address)
        {
            FirstName = fName;
            LastName = lName;
            CellPhone = cell;
            Address = address;
        }
    }
}
