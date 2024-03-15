using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatingProcess.Model
{
    public class CreateListTank
    {
        public static List<TankBase> ListTank(DataTable data)
        {
            List<TankBase> listTank = new List<TankBase>();
            try
            {
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    TankBase tankBase = new TankBase();
                    tankBase.TankName = data.Rows[0][i].ToString();
                    tankBase.Chemical = data.Rows[1][i].ToString();
                    tankBase.Tempmin = float.Parse(data.Rows[2][i].ToString());
                    tankBase.Tempmax = float.Parse(data.Rows[3][i].ToString());
                    tankBase.Temid = int.Parse(data.Rows[4][i].ToString());
                    tankBase.Temaddr = int.Parse(data.Rows[5][i].ToString());
                    tankBase.Conmin = float.Parse(data.Rows[6][i].ToString());
                    tankBase.Conmax = float.Parse(data.Rows[7][i].ToString());
                    tankBase.Conid = int.Parse(data.Rows[8][i].ToString());
                    tankBase.Conaddr = int.Parse(data.Rows[9][i].ToString());
                    tankBase.Phmin = float.Parse(data.Rows[10][i].ToString());
                    tankBase.Phmax = float.Parse(data.Rows[11][i].ToString());
                    tankBase.Phid = int.Parse(data.Rows[12][i].ToString());
                    tankBase.Phaddr = int.Parse(data.Rows[13][i].ToString());
                    tankBase.Turnmin = float.Parse(data.Rows[14][i].ToString());
                    tankBase.Turnmax = float.Parse(data.Rows[15][i].ToString());
                    tankBase.Turnid = int.Parse(data.Rows[16][i].ToString());
                    tankBase.Turnaddr = int.Parse(data.Rows[17][i].ToString());
                    tankBase.Ampemin = float.Parse(data.Rows[18][i].ToString());
                    tankBase.Ampemax = float.Parse(data.Rows[19][i].ToString());
                    tankBase.Ampeid = int.Parse(data.Rows[20][i].ToString());
                    tankBase.Ampeaddr = int.Parse(data.Rows[21][i].ToString());
                    tankBase.Time = int.Parse(data.Rows[22][i].ToString());
                    tankBase.Timeaddr = data.Rows[23][i].ToString();
                    listTank.Add(tankBase);
                }
                return listTank;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
