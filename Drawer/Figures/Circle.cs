using System.Drawing;

namespace Drawer
{
    public class Circle : Figure
    {
        public override void Draw(Graphics args)
        {
            args.DrawEllipse(new Pen(borderColor), figureArea);
        }
        public override string GetFigureInfo()
        {
            return "Круг (Радиус:" + figureArea.Size.Width / 2 + ")";
        }
        public override FigureData GetFigureData()
        {
            return GetData(FigureType.Circle);
        }
        public Circle(Point position, int size, Color borderColor, int velocity)
            : base(position, size, borderColor, velocity)
        {

        }
        public Circle(FigureData data)
            : base(data)
        {

        }
        public Circle()
            : base()
        {

        }
    }
}
