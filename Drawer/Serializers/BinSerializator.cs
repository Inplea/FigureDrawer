using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Drawer.Serializers
{
    class BinSerializator : FigureSerializator
    {
        protected override List<FigureData> ReadData(Stream stream)
        {
            BinaryFormatter formater = new BinaryFormatter();
            return (List<FigureData>)formater.Deserialize(stream);
        }

        protected override void WriteData(Stream stream, List<FigureData> data)
        {
            BinaryFormatter formater = new BinaryFormatter();
            formater.Serialize(stream, data);
        }
    }
}
