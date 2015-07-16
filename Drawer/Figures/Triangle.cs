using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Drawer
{
    class Triangle : Figure
    {
        Point[] lines;
        public override void Draw(Graphics args)
        {
            BuildFigure();
            args.DrawLines(new Pen(borderColor), lines);
        }
        public override string GetFigureInfo()
        {
            return "Триугольник (Длинна стороны:" + figureArea.Size.Width + ")";
        }
        public override FigureData GetFigureData()
        {
            return GetData(FigureType.Triangle);
        }
        public void BuildFigure()
        {
            lines = new Point[4];
            lines[0] = new Point(figureArea.Left + figureArea.Width / 2, figureArea.Top);
            lines[1] = new Point(figureArea.Right, figureArea.Bottom);
            lines[2] = new Point(figureArea.Left, figureArea.Bottom);
            lines[3] = lines[0];
        }
        public Triangle(Point position, int size, Color borderColor, int velocity)
            : base(position, size, borderColor, velocity)
        {
            BuildFigure();
        }
        public Triangle(FigureData data)
            : base(data)
        { }
        public Triangle()
            : base()
        { }

    }
}
