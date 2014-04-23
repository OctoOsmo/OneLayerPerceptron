using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace OneLayerPerceptron
{
    public partial class MainForm : Form
    {
        Boolean draw;
        Graphics g;
        int xPos, yPos;
        Pen blackPen = new Pen(Color.Black, 0);
        int sizeX = 50;
        int sizeY = 50;

        public MainForm()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(pictureBoxInput.Height, pictureBoxInput.Width);
            g = Graphics.FromImage(bm);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, bm.Width, bm.Height);
            pictureBoxInput.Image = bm;
            trackBarBrushSize.Minimum = 1;
            trackBarBrushSize.Maximum = 50;
            trackBarBrushSize.Value = 20;
            blackPen.Width = trackBarBrushSize.Value;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxInput_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxInput_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            int size = trackBarBrushSize.Value;
            g = Graphics.FromImage(pictureBoxInput.Image);
            //g.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y, 6, 6);
            //g.FillRectangle(new SolidBrush(Color.Black), e.X, e.Y, 6, 6);
            //g.FillRectangle(new SolidBrush(Color.Black), e.X, e.Y, 4, 4);
            g.FillEllipse(new SolidBrush(Color.Black), e.X - size / 2, e.Y - size / 2, size, size);
            Point to = new Point(e.X, e.Y);
            blackPen.Width = trackBarBrushSize.Value;
            //g.DrawLine(this.blackPen, to, to);
            this.xPos = e.X;
            this.yPos = e.Y;
            pictureBoxInput.Refresh();

        }

        private void pictureBoxInput_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                int size = trackBarBrushSize.Value;
                Point from = new Point(this.xPos, this.yPos);
                Point to = new Point(e.X, e.Y);
                Point[] points = { from, to };
                //g.DrawCurve(this.blackPen, points);
                g.FillEllipse(new SolidBrush(Color.Black), e.X-size/2, e.Y-size/2, size, size);
                blackPen.Width = trackBarBrushSize.Value;
                g.DrawLine(this.blackPen, from, to);
                this.xPos = e.X;
                this.yPos = e.Y;
                pictureBoxInput.Refresh();
            }

        }

        private void pictureBoxInput_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(pictureBoxInput.Image);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, pictureBoxInput.Image.Width, pictureBoxInput.Image.Height);
            g.Dispose();
            pictureBoxInput.Refresh();

        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
            //Image im = pictureBoxInput.Image();
            Bitmap bm = new Bitmap(pictureBoxInput.Image);
            InputVector V = new InputVector(this.sizeX * this.sizeY);
            V.BmbToVector(bm, this.sizeX, this.sizeY);
        }
    }
}
