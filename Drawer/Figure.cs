using System;
using System.ComponentModel;
using System.Drawing;
using System.Xml.Serialization;

namespace Drawer
{
    #region Extended types
    [Serializable]
    public struct FigureData
    {
        public Velocity Velocity;
        public bool IsMoved;
        public Rectangle Area;
        [XmlIgnore]
        public Color BorderColor;
        public FigureType Type;

        [XmlElement("BorderColor")]
        public string BorderColorSerializable
        {
            get { return TypeDescriptor.GetConverter(typeof(Color)).ConvertToString(BorderColor); }
            set { BorderColor = (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString(value); }
        }
        public FigureData(Velocity velocity, bool isMoved, Color borderColor, Rectangle area, FigureType type)
        {
            Velocity = velocity;
            IsMoved = isMoved;
            Area = area;
            BorderColor = borderColor;
            Type = type;
        }

    }
    [Serializable]
    public enum FigureType { Circle, Rectungle, Sqare, Triangle }
    [Serializable]
    public struct Velocity
    {
        public int x { get; set; }
        public int y { get; set; }

        public void InverseX()
        {
            x = -x;
        }
        public void InverseY()
        {
            y = -y;
        }
        public Velocity(int value)
            : this()
        {
            x = value;
            y = value;
        }
    }
    #endregion
    public abstract class Figure
    {
        private Velocity velocity;
        private bool isMoved;
        protected Rectangle figureArea;
        protected Color borderColor;

        public abstract void Draw(Graphics args);

        public abstract string GetFigureInfo();

        public abstract FigureData GetFigureData();

        public void Move(Size picBoxSize)
        {
            if (isMoved)
            {
                Rectangle picBoxArea = new Rectangle(new Point(0, 0), picBoxSize);

                if (figureArea.X <= 0 || figureArea.Right >= picBoxArea.Width)
                {
                    velocity.InverseX();
                }
                if (figureArea.Y <= 0 || figureArea.Bottom >= picBoxArea.Height)
                {
                    velocity.InverseY();
                }

                    figureArea.X += velocity.x;
                    figureArea.Y += velocity.y;
            }
        }

        public void PlayOrStop()
        {
            if (isMoved)
                isMoved = false;
            else
                isMoved = true;
        }

        protected FigureData GetData(FigureType type)
        {
            return new FigureData(velocity, isMoved, borderColor, figureArea, type);
        }

        #region Constructors
        public Figure()
        {

        }

        public Figure(Point position, Color borderColor, int velocity)
        {
            figureArea = new Rectangle(position.X, position.Y, 1, 1);
            this.borderColor = borderColor;
            this.velocity = new Velocity(velocity);
            isMoved = true;
        }

        public Figure(Point position, int size, Color borderColor, int velocity)

            : this(position, borderColor, velocity)
        {
            figureArea.Width = size;
            figureArea.Height = size;
        }

        public Figure(Point position, int height, int widht, Color borderColor, int velocity)
            : this(position, borderColor, velocity)
        {
            figureArea.Width = widht;
            figureArea.Height = height;
        }

        public Figure(FigureData data)
        {
            figureArea = data.Area;
            isMoved = data.IsMoved;
            velocity = data.Velocity;
            borderColor = data.BorderColor;
        }
#endregion
    }
}
