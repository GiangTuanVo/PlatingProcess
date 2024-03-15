using PlatingProcess.Controls;
using PlatingProcess.Model;
using PlatingProcess.SubForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using PlatingProcess.Helper;

namespace PlatingProcess
{
    public partial class frmMain : UIForm
    {
        private const int tankWidth = 250;
        private const int tankHigh = 250;
        DataSet data = new DataSet();
        public frmMain()
        {
            InitializeComponent();
        }
        Color ActiveColor = Color.FromArgb(16, 110, 190);
        private void frmMain_Load(object sender, EventArgs e)
        {
            DataTable masterLine = new DataTable("masterLine");
            CSVFile.FileToTBL(Application.StartupPath, "File/MasterLineNickel.csv", data, masterLine);
            List<TankBase> tankList = CreateListTank.ListTank(data.Tables["masterLine"]);
            foreach (TankBase item in tankList)
            {
                WaterTank water = new WaterTank();
                water.Width = tankHigh;
                water.Height = tankWidth;
                water.Tag = item;
                water.MouseDown += Tank_MouseDown;
                TankLayout.Controls.Add(water);
            }
        }

        private void Feature_Click(object sender, EventArgs e)
        {
            ClearUI();
            UISymbolButton button = (UISymbolButton)sender;
            if (button.Tag.ToString() == "HOME")
            {
                btnHome.SymbolColor = ActiveColor;
                sigHome.BackColor = ActiveColor;
            }
            else if(button.Tag.ToString()=="SETTING")
            {
                btnSetting.SymbolColor = ActiveColor;
                sigSetting.BackColor = ActiveColor;
            }
            else if (button.Tag.ToString() == "REALTIME")
            {
                btnRealTime.SymbolColor = ActiveColor;
                sigRealTime.BackColor = ActiveColor;
            }
            else if (button.Tag.ToString() == "REPORT")
            {
                btnReport.SymbolColor = ActiveColor;
                sigReport.BackColor = ActiveColor;
            }
            else if (button.Tag.ToString() == "REPAIR")
            {
                btnRepair.SymbolColor = ActiveColor;
                sigRepair.BackColor = ActiveColor;
            }
            else if (button.Tag.ToString() == "WARNING")
            {
                btnWarning.SymbolColor = ActiveColor;
                sigWarning.BackColor = ActiveColor;
            }
            else
            {
                btnQuestion.SymbolColor = ActiveColor;
                sigQuestion.BackColor = ActiveColor;
            }
        }

        private void Tank_MouseDown(object sender, MouseEventArgs e)
        {
            WaterTank tank = (WaterTank)sender;
            ControlInfor control = new ControlInfor();
            control.Local = tank.PointToScreen(Point.Empty);
            control.Width = tank.Width;
            control.Heigh = tank.Height;

            frmRealTimeTank frmRealTime = new frmRealTimeTank();
            frmRealTime.position(control);
            frmRealTime.GetInstant(sender);
            frmRealTime.ShowDialog();
        }
        private void ClearUI()
        {
            btnHome.SymbolColor = Color.Black;
            sigHome.BackColor = Color.White;
            btnSetting.SymbolColor = Color.Black;
            sigSetting.BackColor = Color.White;
            btnRealTime.SymbolColor = Color.Black;
            sigRealTime.BackColor = Color.White;
            btnReport.SymbolColor = Color.Black;
            sigReport.BackColor = Color.White;
            btnRepair.SymbolColor = Color.Black;
            sigRepair.BackColor = Color.White;
            btnWarning.SymbolColor = Color.Black;
            sigWarning.BackColor = Color.White;
            btnQuestion.SymbolColor = Color.Black;
            sigQuestion.BackColor = Color.White;
        }
    }
}
