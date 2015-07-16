using System.Drawing;

namespace Drawer.Figures
{
    public class Rectungle : Figure
    {
        public override void Draw(Graphics args)
        {
            args.DrawRectangle(new Pen(borderColor), figureArea);
        }
        public override string GetFigureInfo()
        {
            return "Прямоугольник (Размер:" + figureArea.Size.Height + "x" + figureArea.Width + ")";
        }
        public override FigureData GetFigureData()
        {
            return GetData(FigureType.Rectungle);
        }
        public Rectungle(Point position, int width, int hight, Color borderColor, int velocity)
            : base(position, hight, width, borderColor, velocity)
        {

        }
        public Rectungle(FigureData data)
            : base(data)
        { }
        public Rectungle()
            : base()
        { }

    }
}
