using Drawer.Serializers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public class FigureManager
    {
        PictureBox pictureBoxToDraw;
        TreeView figureTree;
        List<Figure> figures;

        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
            figureTree.Nodes.Add(figure.GetFigureInfo());
        }
        public void DrawFigures(Graphics args)
        {
            foreach (var figure in figures)
            {
                figure.Draw(args);
            }
        }
        public void MoveFigures()
        {
            for (int i = 0; i < figures.Count; i++)
            {
                figures[i].Move(pictureBoxToDraw.Size);
            }

        }
        public void PauseFigureAnimation(int figureIndex)
        {
            if (figureTree.Nodes.Count > 0)
            {
                figures[figureIndex].PlayOrStop();
            }
        }
        public FigureManager(PictureBox pictureBoxToDraw, TreeView figureTree)
        {
            figures = new List<Figure>();
            this.pictureBoxToDraw = pictureBoxToDraw;
            this.figureTree = figureTree;
        }
        public void Load(string path)
        {
            try
            {
                string extention = Path.GetExtension(path);
                if (extention == ".bin")
                {
                    BinSerializator serializator = new BinSerializator();
                    serializator.Deserialize(figures, path);
                }
                else if (extention == ".xml")
                {
                    XmlSerializator serializator = new XmlSerializator();
                    serializator.Deserialize(figures, path);
                }
                else if (extention == ".json")
                {
                    JsonSerializator serializator = new JsonSerializator();
                    serializator.Deserialize(figures, path);
                }
                RefreshTree();

            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка при загрузке: " + e.Message);
            }
        }
        public void Save(string path)
        {
            try
            {
                string extention = Path.GetExtension(path);
                if (extention == ".bin")
                {
                    BinSerializator serializator = new BinSerializator();
                    serializator.Serialize(figures, path);
                }
                else if (extention == ".xml")
                {
                    XmlSerializator serializator = new XmlSerializator();
                    serializator.Serialize(figures, path);
                }
                else if (extention == ".json")
                {
                    JsonSerializator serializator = new JsonSerializator();
                    serializator.Serialize(figures, path);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Возникла ошибка при сохранении: " + e.Message);
            }

        }
        private void RefreshTree()
        {
            figureTree.Nodes.Clear();
            foreach (var figure in figures)
            {
                figureTree.Nodes.Add(figure.GetFigureInfo());
            }

        }

    }
}
