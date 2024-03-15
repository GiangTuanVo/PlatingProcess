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
    public partial class Batch : UserControl
    {
        private string batchName;
        public string BatchName
        {
            get => batchName;
            set { batchName = value; lblBatch.Text = value; }
        }
        public Batch()
        {
            InitializeComponent();
        }
    }
}
