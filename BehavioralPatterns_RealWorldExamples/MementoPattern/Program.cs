using System;
using MementoPattern.Caretaker;
using MementoPattern.Originator;

namespace MementoPattern
{
    class Program
    {
        static void Main()
        {//spomenut reverzne operacie namiesto ukladania stavov, pripadne ukladanie len zmien
            var person = new Person
                             {
                                    Address = "Under the Bridge 171",
                                    CellPhone = "122011233185",
                                    FirstName = "John",
                                    LastName = "Doe"
                                };

            var caretaker = new PersonCaretaker();
            caretaker.Add(person.CreateUnDo());

            person.ShowInfo();
            Console.WriteLine();

            person.Address = "Under the Tree 119";
            caretaker.Add(person.CreateUnDo());

            person.ShowInfo();
            Console.WriteLine();

            person.CellPhone = "987654321";
            person.ShowInfo();
            Console.WriteLine();

            person.UnDo(caretaker.GetMemento());
            person.ShowInfo();
            Console.WriteLine();

            person.UnDo(caretaker.GetMemento());
            person.ShowInfo();
            Console.WriteLine();
        }
    }
}
