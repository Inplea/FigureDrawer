using System.Collections.Generic;
using System.IO;

namespace Drawer.Serializers
{
    public abstract class FigureSerializator
    {
        public void Serialize(List<Figure> figures, string path)
        {
            Stream stream = File.OpenWrite(path);
            List<FigureData> data = new List<FigureData>();

            foreach (var figure in figures)
            {
                data.Add(figure.GetFigureData());
            }
            WriteData(stream, data);
            stream.Close();
        }

        public void Deserialize(List<Figure> figures, string path)
        {
            Stream stream = File.OpenRead(path);
            List<FigureData> data = ReadData(stream);
            stream.Close();
            figures.Clear();

            foreach (var figure in data)
            {
                if (figure.Type == FigureType.Circle)
                    figures.Add(new Circle(figure));
                else if (figure.Type == FigureType.Rectungle)
                    figures.Add(new Figures.Rectungle(figure));
                else if (figure.Type == FigureType.Sqare)
                    figures.Add(new Sqare(figure));
                else if (figure.Type == FigureType.Triangle)
                    figures.Add(new Triangle(figure));
            }

        }

        protected abstract void WriteData(Stream stream, List<FigureData> data);

        protected abstract List<FigureData> ReadData(Stream stream);
    }
}
