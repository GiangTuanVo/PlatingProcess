using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using PlatingProcess.Model;

namespace PlatingProcess.Controls
{
    public partial class WaterTank : UserControl
    {
        //
        private bool tankstatus;
        private Font lablesize;
        private Color backgroud;
        //
        TankBase tank = new TankBase();

        public bool Tankstatus { get => tankstatus; set => tankstatus = value; }
        public Font LableSize 
        { 
            get => lablesize;
            set 
            {
                lablesize = value;
                lblProcess.Font = value;
            } 
        }

        public Color BackGroud
        {
            get => backgroud;
            set
            {
                backgroud = value;
                BackColor = value;
            }
        }
        public WaterTank()
        {
            InitializeComponent();
        }
        //Creat properties for variable
        

        private void Image_MouseDown(object sender, MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }
        Random random = new Random();
        private void TimerLoad_Tick(object sender, EventArgs e)
        {
            tank.Ampe = random.Next(0, 100);
        }

        private void WaterTank_Load(object sender, EventArgs e)
        {
            TimerLoad.Start();
            tank = (TankBase)this.Tag;
            lblProcess.Text = tank.TankName;
        }
    }
}
