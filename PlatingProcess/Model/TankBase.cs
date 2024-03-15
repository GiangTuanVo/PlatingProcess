using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatingProcess.Model
{
    public class TankBase
    {
        private string tankname;
        private string chemical;
        private float temperature;
        private float concentration;
        private float ph;
        private float turn;
        private float ampe;
        private int time;

        private float tempmax;
        private float tempmin;
        private float conmax;
        private float conmin;
        private float phmax;
        private float phmin;
        private float turnmax;
        private float turnmin;
        private float ampemax;
        private float ampemin;

        private int temid;
        private int temaddr;
        private int conid;
        private int conaddr;
        private int phid;
        private int phaddr;
        private int turnid;
        private int turnaddr;
        private int ampeid;
        private int ampeaddr;
        private string timeaddr;
        public string TankName { get => tankname; set => tankname = value; }
        public string Chemical { get => chemical; set => chemical = value; }
        public float Temperature { get => temperature; set => temperature = value; }
        public float Concentration { get => concentration; set => concentration = value; }
        public float Ph { get => ph; set => ph = value; }
        public float Turn { get => turn; set => turn = value; }
        public float Ampe { get => ampe; set => ampe = value; }
        public float Tempmax { get => tempmax; set => tempmax = value; }
        public float Tempmin { get => tempmin; set => tempmin = value; }
        public float Conmax { get => conmax; set => conmax = value; }
        public float Conmin { get => conmin; set => conmin = value; }
        public float Phmax { get => phmax; set => phmax = value; }
        public float Phmin { get => phmin; set => phmin = value; }
        public float Turnmax { get => turnmax; set => turnmax = value; }
        public float Turnmin { get => turnmin; set => turnmin = value; }
        public float Ampemax { get => ampemax; set => ampemax = value; }
        public float Ampemin { get => ampemin; set => ampemin = value; }
        public int Temid { get => temid; set => temid = value; }
        public int Temaddr { get => temaddr; set => temaddr = value; }
        public int Conid { get => conid; set => conid = value; }
        public int Conaddr { get => conaddr; set => conaddr = value; }
        public int Phid { get => phid; set => phid = value; }
        public int Phaddr { get => phaddr; set => phaddr = value; }
        public int Turnid { get => turnid; set => turnid = value; }
        public int Turnaddr { get => turnaddr; set => turnaddr = value; }
        public int Ampeid { get => ampeid; set => ampeid = value; }
        public int Ampeaddr { get => ampeaddr; set => ampeaddr = value; }
        public string Timeaddr { get => timeaddr; set => timeaddr = value; }
        public int Time { get => time; set => time = value; }
    }
}
