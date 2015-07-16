using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Drawer.Serializers
{
    class XmlSerializator : FigureSerializator
    {
        protected override void WriteData(Stream stream, List<FigureData> data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FigureData>));
            serializer.Serialize(stream, data);
        }
        protected override List<FigureData> ReadData(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<FigureData>));
            return (List<FigureData>)serializer.Deserialize(stream);
        }
    }
}
