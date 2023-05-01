namespace BaiTapLon
{
    partial class DANGNHAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DANGNHAP));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Button();
            this.btdangkymoi = new System.Windows.Forms.Button();
            this.cbhienthimk = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbusers = new System.Windows.Forms.TextBox();
            this.lbpass = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cbhienthimk);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btdangnhap);
            this.panel1.Controls.Add(this.tbpass);
            this.panel1.Controls.Add(this.tbusers);
            this.panel1.Controls.Add(this.lbpass);
            this.panel1.Controls.Add(this.lbuser);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 642);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btexit);
            this.panel2.Controls.Add(this.btdangkymoi);
            this.panel2.Location = new System.Drawing.Point(-1, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 100);
            this.panel2.TabIndex = 1;
            // 
            // btexit
            // 
            this.btexit.BackColor = System.Drawing.Color.ForestGreen;
            this.btexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.ForeColor = System.Drawing.SystemColors.Control;
            this.btexit.Location = new System.Drawing.Point(183, 59);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(123, 36);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "EXIT";
            this.btexit.UseVisualStyleBackColor = false;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btdangkymoi
            // 
            this.btdangkymoi.BackColor = System.Drawing.Color.ForestGreen;
            this.btdangkymoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangkymoi.ForeColor = System.Drawing.SystemColors.Control;
            this.btdangkymoi.Location = new System.Drawing.Point(99, 3);
            this.btdangkymoi.Name = "btdangkymoi";
            this.btdangkymoi.Size = new System.Drawing.Size(298, 52);
            this.btdangkymoi.TabIndex = 0;
            this.btdangkymoi.Text = "Tạo tài khoản Sinh Viên";
            this.btdangkymoi.UseVisualStyleBackColor = false;
            this.btdangkymoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbhienthimk
            // 
            this.cbhienthimk.AutoSize = true;
            this.cbhienthimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhienthimk.Location = new System.Drawing.Point(166, 423);
            this.cbhienthimk.Name = "cbhienthimk";
            this.cbhienthimk.Size = new System.Drawing.Size(162, 24);
            this.cbhienthimk.TabIndex = 8;
            this.cbhienthimk.Text = "Hiển thị mật khẩu";
            this.cbhienthimk.UseVisualStyleBackColor = true;
            this.cbhienthimk.CheckedChanged += new System.EventHandler(this.cbhienthimk_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Tan;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(173, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 121);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateBlue;
            this.label1.Location = new System.Drawing.Point(146, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // btdangnhap
            // 
            this.btdangnhap.BackColor = System.Drawing.SystemColors.Highlight;
            this.btdangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdangnhap.ForeColor = System.Drawing.SystemColors.Control;
            this.btdangnhap.Location = new System.Drawing.Point(99, 469);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(298, 46);
            this.btdangnhap.TabIndex = 4;
            this.btdangnhap.Text = "Đăng Nhập";
            this.btdangnhap.UseVisualStyleBackColor = false;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // tbpass
            // 
            this.tbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpass.Location = new System.Drawing.Point(152, 355);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '✱';
            this.tbpass.Size = new System.Drawing.Size(278, 32);
            this.tbpass.TabIndex = 3;
            // 
            // tbusers
            // 
            this.tbusers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusers.Location = new System.Drawing.Point(152, 264);
            this.tbusers.Name = "tbusers";
            this.tbusers.Size = new System.Drawing.Size(278, 32);
            this.tbusers.TabIndex = 2;
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.Location = new System.Drawing.Point(16, 358);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(126, 29);
            this.lbpass.TabIndex = 1;
            this.lbpass.Text = "Password:";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbuser.Location = new System.Drawing.Point(16, 267);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(130, 29);
            this.lbuser.TabIndex = 0;
            this.lbuser.Text = "Username:";
            // 
            // DANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(526, 666);
            this.Controls.Add(this.panel1);
            this.Name = "DANGNHAP";
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.DANGNHAP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbusers;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btdangkymoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbhienthimk;
    }
}

