using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatingProcess.Controls
{
    public partial class ProcessGuide : UserControl
    {
        public ProcessGuide()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.UserControl_Paint);
        }
        private string _StringText = "label";
        public string Labels
        {
            get
            {
                return _StringText;
            }
            set
            {
                _StringText = value;
                Invalidate();
            }
        }
        private Brush _TextColor = Brushes.Black;
        public Brush TextColor
        {
            get
            {
                return _TextColor;
            }
            set
            {
                _TextColor = value;
                Invalidate();
            }
        }
        private Font _TextFont = new Font("Century Gothic", 12);
        public Font TextFont
        {
            get
            {
                return _TextFont;
            }
            set
            {
                _TextFont = value;
                Invalidate();
            }
        }
        private Color _BackGround = Color.Gray;
        public Color BackGround
        {
            get
            {
                return _BackGround;
            }
            set
            {
                _BackGround = value;
                Invalidate();
            }
        }
        private int _Angle = 30;
        public int Angle
        {
            get
            {
                return _Angle;
            }
            set
            {
                _Angle = value;
                Invalidate();
            }
        }

        private void UserControl_Paint(object sender, PaintEventArgs e)
        {
            //create a graphics object from the form
            int dim = (int)(Math.Tan((_Angle * 3.14) / 180) * (this.Height / 2));
            Graphics g = this.CreateGraphics();
            Brush b = new SolidBrush(_BackGround);
            Point[] points = new Point[]
            {
            new Point(0, 0),
            new Point(this.Width-dim, 0),
            new Point(this.Width, this.Height/2),
            new Point(this.Width-dim, this.Height),
            new Point(0, this.Height),
            new Point(dim,this.Height/2)};
            g.FillPolygon(b, points);
            //
            int textWidth = TextRenderer.MeasureText(_StringText, _TextFont).Width;
            int textHeigh = TextRenderer.MeasureText(_StringText, _TextFont).Height;
            g.DrawString(_StringText, _TextFont, _TextColor, (this.Width - textWidth) / 2, (this.Height - textHeigh) / 2);
        }
    }
}
