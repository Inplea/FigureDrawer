using Drawer.Figures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawer
{
    public partial class MainForm : Form
    {
        public struct Randoms
        {
            private Random random;

            public int GetRandomSize()
            {
                return random.Next(10, 50);
            }
            public int GetRandomVelocity()
            {
                return random.Next(1, 4);
            }
            public Point GetRandomPositionPoint()
            {
                return new Point(random.Next(10, 300), random.Next(10, 300));
            }
            public void Init()
            {
                random = new Random();
            }

        }

        FigureManager figureManager;
        Randoms randoms;
        public MainForm()
        {
            InitializeComponent();
            randoms = new Randoms();
            randoms.Init();
            figureManager = new FigureManager(PictureBox, FigureTree);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            figureManager.MoveFigures();
            PictureBox.Refresh();
        }

        private void TriangleButton_Click(object sender, EventArgs e)
        {
            figureManager.AddFigure(new Triangle(randoms.GetRandomPositionPoint(), randoms.GetRandomSize(), Color.OrangeRed, randoms.GetRandomVelocity()));
        }

        private void SqareButton_Click(object sender, EventArgs e)
        {
            figureManager.AddFigure(new Sqare(randoms.GetRandomPositionPoint(), randoms.GetRandomSize(), Color.Red, randoms.GetRandomVelocity()));
        }

        private void CircleButton_Click(object sender, EventArgs e)
        {
            figureManager.AddFigure(new Circle(randoms.GetRandomPositionPoint(), randoms.GetRandomSize(), Color.Green, randoms.GetRandomVelocity()));
        }

        private void RectungleButton_Click(object sender, EventArgs e)
        {
            figureManager.AddFigure(new Rectungle(randoms.GetRandomPositionPoint(), randoms.GetRandomSize(), randoms.GetRandomSize(), Color.Brown, randoms.GetRandomVelocity()));
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            figureManager.PauseFigureAnimation(FigureTree.SelectedNode.Index);
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            figureManager.DrawFigures(e.Graphics);
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            figureManager.Save(saveFileDialog.FileName);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            figureManager.Load(openFileDialog.FileName);
        }

    }
}
