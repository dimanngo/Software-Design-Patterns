using System.IO;
using System.Xml.Serialization;
using AdapterPattern.Target;

namespace AdapterPattern
{
    public class XMLSerializerAdapter:ISerializerAdapter
    {
        public string Serialize<T>(object objToSerialize)
        {
            using(var writer = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, objToSerialize);
                return writer.ToString();
            }
        }
    }
}
