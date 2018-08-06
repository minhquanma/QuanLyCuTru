namespace QuanLyCuTru_WinForm
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Transparent;
            this.line1.ForeColor = System.Drawing.Color.DimGray;
            this.line1.Location = new System.Drawing.Point(66, 88);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(375, 11);
            this.line1.TabIndex = 0;
            this.line1.Text = "line1";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.LightGray;
            this.txtUsername.Location = new System.Drawing.Point(68, 64);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(375, 29);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.Transparent;
            this.line2.ForeColor = System.Drawing.Color.DimGray;
            this.line2.Location = new System.Drawing.Point(68, 165);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(375, 11);
            this.line2.TabIndex = 2;
            this.line2.Text = "line2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "LOGIN";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.LightGray;
            this.btnDangNhap.Location = new System.Drawing.Point(68, 212);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(377, 37);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // ptbExit
            // 
            this.ptbExit.Image = ((System.Drawing.Image)(resources.GetObject("ptbExit.Image")));
            this.ptbExit.Location = new System.Drawing.Point(487, 2);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(26, 24);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 6;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.LightGray;
            this.txtPassword.Location = new System.Drawing.Point(68, 141);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(375, 29);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(514, 291);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.ptbExit);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.line1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.Name = "FormDangNhap";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormDangNhap_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.Line line1;
        private System.Windows.Forms.TextBox txtUsername;
        private DevComponents.DotNetBar.Controls.Line line2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.TextBox txtPassword;
    }
}