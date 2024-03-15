using PlatingProcess.Controls;
using PlatingProcess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatingProcess.SubForm
{
    public partial class frmRealTimeTank : Form
    {
        //Get position control
        public delegate void ControlPosition(object control);
        public ControlPosition position;
        //Get object
        public delegate void Instant(object _object);

        public Instant GetInstant;
        private Point _Location = new Point();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public WaterTank tank { get; set; }
        public frmRealTimeTank()
        {
            InitializeComponent();
            position = new ControlPosition(GetMessage);
            GetInstant = new Instant(GetObject);
        }
        private void GetMessage(object control)
        {
            ControlInfor controlPosition = (ControlInfor)control;
            _Location = controlPosition.Local;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = _Location;
        }

        private void GetObject(object _object)
        {
            tank = (WaterTank)_object;
        }
        private void lblTheme_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RealTime_Tick(object sender, EventArgs e)
        {
            TankBase tankBase = (TankBase)tank.Tag;
            //Get
            txtChemicalName.Text = tankBase.Chemical;
            txtCurrent.Text = tankBase.Ampe.ToString();
        }

        private void frmRealTimeTank_Load(object sender, EventArgs e)
        {
            RealTime.Start();
        }
    }
}
