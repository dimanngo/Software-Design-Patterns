using AdapterPattern.Target;
using System.Web.Script.Serialization;

namespace AdapterPattern.Adapters
{
    public class JSONSerializerAdapter:ISerializerAdapter
    {
        public string Serialize<T>(object objToSerialize)
        {
            var serializer = new JavaScriptSerializer();
            return serializer.Serialize(objToSerialize);
        }
    }
}
