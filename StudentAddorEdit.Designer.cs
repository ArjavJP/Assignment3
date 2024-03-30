namespace Assignment3
{
    partial class StudentAddorEdit
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
            btn_AddorEdit = new Button();
            txtfname = new TextBox();
            txtstdid = new TextBox();
            lblPass = new Label();
            lblstdid = new Label();
            lbltitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtgender = new TextBox();
            txtlname = new TextBox();
            txtage = new TextBox();
            txtclassname = new TextBox();
            txtgrade = new TextBox();
            SuspendLayout();
            // 
            // btn_AddorEdit
            // 
            btn_AddorEdit.Location = new Point(449, 699);
            btn_AddorEdit.Name = "btn_AddorEdit";
            btn_AddorEdit.Size = new Size(115, 34);
            btn_AddorEdit.TabIndex = 12;
            btn_AddorEdit.Text = "Add";
            btn_AddorEdit.UseVisualStyleBackColor = true;
            btn_AddorEdit.Click += btn_AddorEdit_Click;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(515, 238);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(150, 31);
            txtfname.TabIndex = 11;
            // 
            // txtstdid
            // 
            txtstdid.Location = new Point(515, 163);
            txtstdid.Name = "txtstdid";
            txtstdid.Size = new Size(150, 31);
            txtstdid.TabIndex = 10;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(378, 244);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(101, 25);
            lblPass.TabIndex = 9;
            lblPass.Text = "First Name:";
            // 
            // lblstdid
            // 
            lblstdid.AutoSize = true;
            lblstdid.Location = new Point(378, 169);
            lblstdid.Name = "lblstdid";
            lblstdid.Size = new Size(98, 25);
            lblstdid.TabIndex = 8;
            lblstdid.Text = "Student Id:";
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltitle.Location = new Point(401, 66);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(217, 48);
            lbltitle.TabIndex = 7;
            lbltitle.Text = "Add Student";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 324);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 13;
            label1.Text = "Last Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 409);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 14;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 479);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 15;
            label3.Text = "Gender: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 546);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 16;
            label4.Text = "Class Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(413, 611);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 17;
            label5.Text = "Grade:";
            // 
            // txtgender
            // 
            txtgender.Location = new Point(515, 473);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(150, 31);
            txtgender.TabIndex = 18;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(515, 324);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(150, 31);
            txtlname.TabIndex = 19;
            // 
            // txtage
            // 
            txtage.Location = new Point(515, 403);
            txtage.Name = "txtage";
            txtage.Size = new Size(150, 31);
            txtage.TabIndex = 20;
            // 
            // txtclassname
            // 
            txtclassname.Location = new Point(515, 546);
            txtclassname.Name = "txtclassname";
            txtclassname.Size = new Size(150, 31);
            txtclassname.TabIndex = 21;
            // 
            // txtgrade
            // 
            txtgrade.Location = new Point(515, 611);
            txtgrade.Name = "txtgrade";
            txtgrade.Size = new Size(150, 31);
            txtgrade.TabIndex = 22;
            // 
            // StudentAddorEdit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 962);
            Controls.Add(txtgrade);
            Controls.Add(txtclassname);
            Controls.Add(txtage);
            Controls.Add(txtlname);
            Controls.Add(txtgender);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_AddorEdit);
            Controls.Add(txtfname);
            Controls.Add(txtstdid);
            Controls.Add(lblPass);
            Controls.Add(lblstdid);
            Controls.Add(lbltitle);
            Name = "StudentAddorEdit";
            Text = "StudentAddorEdit";
            Load += StudentAddorEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddorEdit;
        private TextBox txtfname;
        private TextBox txtstdid;
        private Label lblPass;
        private Label lblstdid;
        private Label lbltitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtgender;
        private TextBox txtlname;
        private TextBox txtage;
        private TextBox txtclassname;
        private TextBox txtgrade;
    }
}