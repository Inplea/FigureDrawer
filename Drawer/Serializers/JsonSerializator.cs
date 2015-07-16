using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Drawer.Serializers
{
    class JsonSerializator : FigureSerializator
    {
        protected override void WriteData(Stream stream, List<FigureData> data)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<FigureData>));
            serializer.WriteObject(stream, data);
        }

        protected override List<FigureData> ReadData(Stream stream)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<FigureData>));
            return (List<FigureData>)serializer.ReadObject(stream);
        }
    }
}
