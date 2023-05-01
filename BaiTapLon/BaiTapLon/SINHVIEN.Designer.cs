namespace BaiTapLon
{
    partial class SINHVIEN
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Datagridshow = new System.Windows.Forms.DataGridView();
            this.lbusername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridshow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.lbusername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 98);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SINH VIÊN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.Datagridshow);
            this.panel2.Location = new System.Drawing.Point(13, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 570);
            this.panel2.TabIndex = 1;
            // 
            // Datagridshow
            // 
            this.Datagridshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridshow.Location = new System.Drawing.Point(18, 16);
            this.Datagridshow.Name = "Datagridshow";
            this.Datagridshow.RowHeadersWidth = 51;
            this.Datagridshow.RowTemplate.Height = 24;
            this.Datagridshow.Size = new System.Drawing.Size(1083, 535);
            this.Datagridshow.TabIndex = 0;
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.Location = new System.Drawing.Point(1060, 0);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(55, 22);
            this.lbusername.TabIndex = 1;
            this.lbusername.Text = "         ";
            // 
            // SINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1154, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SINHVIEN";
            this.Text = "SINHVIEN";
            this.Load += new System.EventHandler(this.SINHVIEN_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Datagridshow;
        private System.Windows.Forms.Label lbusername;
    }
}