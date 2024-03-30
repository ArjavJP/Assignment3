namespace Assignment3
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbltitle = new Label();
            lblusername = new Label();
            lblPass = new Label();
            txtuser = new TextBox();
            txtpass = new TextBox();
            btn_register = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(428, 87);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(149, 48);
            lbltitle.TabIndex = 0;
            lbltitle.Text = "Register";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Location = new Point(349, 184);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(103, 25);
            lblusername.TabIndex = 1;
            lblusername.Text = "User Name:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(361, 269);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(91, 25);
            lblPass.TabIndex = 2;
            lblPass.Text = "Password:";
            // 
            // txtuser
            // 
            txtuser.Location = new Point(498, 188);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(150, 31);
            txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(498, 263);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(150, 31);
            txtpass.TabIndex = 4;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(446, 398);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(115, 34);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(574, 398);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(219, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have an Account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 808);
            Controls.Add(linkLabel1);
            Controls.Add(btn_register);
            Controls.Add(txtpass);
            Controls.Add(txtuser);
            Controls.Add(lblPass);
            Controls.Add(lblusername);
            Controls.Add(lbltitle);
            Name = "Register";
            Text = "Form1";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label lblusername;
        private Label lblPass;
        private TextBox txtuser;
        private TextBox txtpass;
        private Button btn_register;
        private LinkLabel linkLabel1;
    }
}
