using System;
using System.Collections.Generic;
using System.Text;
using AdapterPattern.Adapters;
using AdapterPattern.Models;
using AdapterPattern.Target;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            var serializer = new DataSerializer(new XMLSerializerAdapter());
            Console.WriteLine(serializer.Render());

            serializer = new DataSerializer(new JSONSerializerAdapter());
            Console.WriteLine(serializer.Render());
        }
    }

    public class DataSerializer
    {
        private readonly ISerializerAdapter _serializer;

        public DataSerializer(ISerializerAdapter serializer)
        {
            _serializer = serializer;
        }

        public string Render()
        {
            var sb = new StringBuilder();

            var list = new List<PersonInfo>
                               {
                                   new PersonInfo
                                       {
                                           FirstName = "Robert", 
                                           LastName = "Kanasz", 
                                           BirthDate = new DateTime(1985,8,19),
                                           Height = 168,Weight = 71
                                       },
                                   new PersonInfo
                                       {
                                           FirstName = "John", 
                                           LastName = "Doe", 
                                           BirthDate = new DateTime(1981,9,25),
                                           Height = 189,
                                           Weight = 80
                                       },
                                   new PersonInfo
                                       {
                                           FirstName = "Jane", 
                                           LastName = "Doe", 
                                           BirthDate = new DateTime(1989,12,1),
                                           Height = 164,
                                           Weight = 45
                                       }
                               };

            foreach (var personInfo in list)
            {
                sb.AppendLine(_serializer.Serialize<PersonInfo>(personInfo));
            }

            return sb.ToString();
        }

    }
}
