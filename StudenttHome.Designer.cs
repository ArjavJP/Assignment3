﻿namespace Assignment3
{
    partial class StudenttHome
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
            dgv_student = new DataGridView();
            button1 = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            txtsearch = new TextBox();
            lblSearch = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_student).BeginInit();
            SuspendLayout();
            // 
            // dgv_student
            // 
            dgv_student.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_student.Location = new Point(44, 85);
            dgv_student.Name = "dgv_student";
            dgv_student.RowHeadersWidth = 62;
            dgv_student.Size = new Size(1167, 591);
            dgv_student.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(117, 739);
            button1.Name = "button1";
            button1.Size = new Size(153, 62);
            button1.TabIndex = 1;
            button1.Text = "Add Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(344, 739);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(153, 62);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Update Student";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(574, 739);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(153, 62);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete Student";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(220, 48);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(485, 31);
            txtsearch.TabIndex = 4;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(141, 48);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(73, 25);
            lblSearch.TabIndex = 5;
            lblSearch.Text = "Search: ";
            // 
            // StudenttHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 864);
            Controls.Add(lblSearch);
            Controls.Add(txtsearch);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(button1);
            Controls.Add(dgv_student);
            Name = "StudenttHome";
            Text = "StudenttHome";
            Load += StudenttHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_student).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_student;
        private Button button1;
        private Button btn_edit;
        private Button btn_delete;
        private TextBox txtsearch;
        private Label lblSearch;
    }
}