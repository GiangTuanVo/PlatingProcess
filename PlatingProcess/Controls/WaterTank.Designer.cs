
namespace PlatingProcess.Controls
{
    partial class WaterTank
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterTank));
            this.LayoutControl = new System.Windows.Forms.TableLayoutPanel();
            this.Image = new System.Windows.Forms.PictureBox();
            this.lblProcess = new System.Windows.Forms.Label();
            this.TimerLoad = new System.Windows.Forms.Timer(this.components);
            this.LayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutControl
            // 
            this.LayoutControl.BackColor = System.Drawing.Color.Transparent;
            this.LayoutControl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.LayoutControl.ColumnCount = 1;
            this.LayoutControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutControl.Controls.Add(this.Image, 0, 1);
            this.LayoutControl.Controls.Add(this.lblProcess, 0, 0);
            this.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutControl.Location = new System.Drawing.Point(0, 0);
            this.LayoutControl.Name = "LayoutControl";
            this.LayoutControl.RowCount = 2;
            this.LayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.LayoutControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutControl.Size = new System.Drawing.Size(200, 200);
            this.LayoutControl.TabIndex = 0;
            // 
            // Image
            // 
            this.Image.BackColor = System.Drawing.Color.Transparent;
            this.Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.Location = new System.Drawing.Point(6, 35);
            this.Image.Margin = new System.Windows.Forms.Padding(5);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(188, 159);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Image_MouseDown);
            // 
            // lblProcess
            // 
            this.lblProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProcess.AutoSize = true;
            this.lblProcess.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcess.Location = new System.Drawing.Point(32, 4);
            this.lblProcess.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(135, 22);
            this.lblProcess.TabIndex = 1;
            this.lblProcess.Text = "Process No.01";
            this.lblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerLoad
            // 
            this.TimerLoad.Enabled = true;
            this.TimerLoad.Tick += new System.EventHandler(this.TimerLoad_Tick);
            // 
            // WaterTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.LayoutControl);
            this.Name = "WaterTank";
            this.Size = new System.Drawing.Size(200, 200);
            this.Load += new System.EventHandler(this.WaterTank_Load);
            this.LayoutControl.ResumeLayout(false);
            this.LayoutControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutControl;
        private System.Windows.Forms.PictureBox Image;
        protected System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Timer TimerLoad;
    }
}
