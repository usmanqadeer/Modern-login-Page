namespace ModernThreeDLogInPage
{
    partial class frmLoginPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginPage));
            this.dragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.picImageThreeD = new System.Windows.Forms.PictureBox();
            this.panUserName = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.panUserPassword = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.picUserNameIndicator = new System.Windows.Forms.PictureBox();
            this.picUserNameEmpty = new System.Windows.Forms.PictureBox();
            this.picUserPasswordEmpty = new System.Windows.Forms.PictureBox();
            this.picUserPasswordOk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImageThreeD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserNameIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserNameEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPasswordEmpty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPasswordOk)).BeginInit();
            this.SuspendLayout();
            // 
            // dragControl
            // 
            this.dragControl.Fixed = true;
            this.dragControl.Horizontal = true;
            this.dragControl.TargetControl = this;
            this.dragControl.Vertical = true;
            // 
            // picImageThreeD
            // 
            this.picImageThreeD.Image = ((System.Drawing.Image)(resources.GetObject("picImageThreeD.Image")));
            this.picImageThreeD.Location = new System.Drawing.Point(1, -1);
            this.picImageThreeD.Name = "picImageThreeD";
            this.picImageThreeD.Size = new System.Drawing.Size(298, 295);
            this.picImageThreeD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageThreeD.TabIndex = 0;
            this.picImageThreeD.TabStop = false;
            // 
            // panUserName
            // 
            this.panUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(162)))), ((int)(((byte)(11)))));
            this.panUserName.Location = new System.Drawing.Point(341, 134);
            this.panUserName.Name = "panUserName";
            this.panUserName.Size = new System.Drawing.Size(326, 1);
            this.panUserName.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(162)))), ((int)(((byte)(11)))));
            this.txtUserName.Location = new System.Drawing.Point(342, 110);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(295, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "Name";
            this.txtUserName.MouseLeave += new System.EventHandler(this.txtUserName_MouseLeave);
            this.txtUserName.MouseHover += new System.EventHandler(this.txtUserName_MouseHover);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(162)))), ((int)(((byte)(11)))));
            this.txtUserPassword.Location = new System.Drawing.Point(341, 148);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(296, 20);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.Text = "Password";
            this.txtUserPassword.Enter += new System.EventHandler(this.txtUserPassword_Enter);
            this.txtUserPassword.MouseLeave += new System.EventHandler(this.txtUserPassword_MouseLeave);
            this.txtUserPassword.MouseHover += new System.EventHandler(this.txtUserPassword_MouseHover);
            // 
            // panUserPassword
            // 
            this.panUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(162)))), ((int)(((byte)(11)))));
            this.panUserPassword.Location = new System.Drawing.Point(340, 174);
            this.panUserPassword.Name = "panUserPassword";
            this.panUserPassword.Size = new System.Drawing.Size(326, 1);
            this.panUserPassword.TabIndex = 3;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(100)))), ((int)(((byte)(254)))));
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(162)))), ((int)(((byte)(11)))));
            this.btnLogIn.FlatAppearance.BorderSize = 2;
            this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(43)))), ((int)(((byte)(228)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(340, 199);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(326, 42);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "LogIn";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Gray;
            this.lblClose.Location = new System.Drawing.Point(693, 2);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 19);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.Gray;
            this.lblMinimize.Location = new System.Drawing.Point(664, -9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(22, 23);
            this.lblMinimize.TabIndex = 7;
            this.lblMinimize.Text = "_";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            // 
            // picUserNameIndicator
            // 
            this.picUserNameIndicator.Image = ((System.Drawing.Image)(resources.GetObject("picUserNameIndicator.Image")));
            this.picUserNameIndicator.Location = new System.Drawing.Point(643, 110);
            this.picUserNameIndicator.Name = "picUserNameIndicator";
            this.picUserNameIndicator.Size = new System.Drawing.Size(20, 20);
            this.picUserNameIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserNameIndicator.TabIndex = 8;
            this.picUserNameIndicator.TabStop = false;
            this.picUserNameIndicator.Visible = false;
            // 
            // picUserNameEmpty
            // 
            this.picUserNameEmpty.Image = ((System.Drawing.Image)(resources.GetObject("picUserNameEmpty.Image")));
            this.picUserNameEmpty.Location = new System.Drawing.Point(643, 110);
            this.picUserNameEmpty.Name = "picUserNameEmpty";
            this.picUserNameEmpty.Size = new System.Drawing.Size(20, 20);
            this.picUserNameEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserNameEmpty.TabIndex = 9;
            this.picUserNameEmpty.TabStop = false;
            this.picUserNameEmpty.Visible = false;
            // 
            // picUserPasswordEmpty
            // 
            this.picUserPasswordEmpty.Image = ((System.Drawing.Image)(resources.GetObject("picUserPasswordEmpty.Image")));
            this.picUserPasswordEmpty.Location = new System.Drawing.Point(643, 150);
            this.picUserPasswordEmpty.Name = "picUserPasswordEmpty";
            this.picUserPasswordEmpty.Size = new System.Drawing.Size(20, 20);
            this.picUserPasswordEmpty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserPasswordEmpty.TabIndex = 10;
            this.picUserPasswordEmpty.TabStop = false;
            this.picUserPasswordEmpty.Visible = false;
            // 
            // picUserPasswordOk
            // 
            this.picUserPasswordOk.Image = ((System.Drawing.Image)(resources.GetObject("picUserPasswordOk.Image")));
            this.picUserPasswordOk.Location = new System.Drawing.Point(643, 150);
            this.picUserPasswordOk.Name = "picUserPasswordOk";
            this.picUserPasswordOk.Size = new System.Drawing.Size(20, 20);
            this.picUserPasswordOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserPasswordOk.TabIndex = 11;
            this.picUserPasswordOk.TabStop = false;
            this.picUserPasswordOk.Visible = false;
            // 
            // frmLoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 295);
            this.Controls.Add(this.picUserPasswordOk);
            this.Controls.Add(this.picUserPasswordEmpty);
            this.Controls.Add(this.picUserNameEmpty);
            this.Controls.Add(this.picUserNameIndicator);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtUserPassword);
            this.Controls.Add(this.panUserPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.panUserName);
            this.Controls.Add(this.picImageThreeD);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInPage";
            ((System.ComponentModel.ISupportInitialize)(this.picImageThreeD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserNameIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserNameEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPasswordEmpty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPasswordOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl dragControl;
        private System.Windows.Forms.PictureBox picImageThreeD;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Panel panUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Panel panUserName;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox picUserPasswordOk;
        private System.Windows.Forms.PictureBox picUserPasswordEmpty;
        private System.Windows.Forms.PictureBox picUserNameEmpty;
        private System.Windows.Forms.PictureBox picUserNameIndicator;
    }
}

