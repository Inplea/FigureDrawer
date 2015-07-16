using System.Drawing;

namespace Drawer
{
    class Sqare : Figure
    {
        public override void Draw(Graphics args)
        {
            args.DrawRectangle(new Pen(borderColor), figureArea);
        }
        public override string GetFigureInfo()
        {
            return "Квадрат (Размер:" + figureArea.Size.Height + "x" + figureArea.Width + ")";
        }
        public override FigureData GetFigureData()
        {
            return GetData(FigureType.Sqare);
        }
        public Sqare(Point position, int size, Color borderColor, int velocity)
            : base(position, size, borderColor, velocity)
        {

        }
        public Sqare(FigureData data)
            : base(data)
        { }
        public Sqare()
            : base()
        { }

    }
}
