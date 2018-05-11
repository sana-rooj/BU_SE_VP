namespace DBConnectivity
{
    partial class Form1
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
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.labelStudentID = new System.Windows.Forms.Label();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelSearchStudentName = new System.Windows.Forms.Label();
            this.labelSearchStudentNameaval = new System.Windows.Forms.Label();
            this.tabControlStudent.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.tabPageSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabPageList);
            this.tabControlStudent.Controls.Add(this.tabPageSearch);
            this.tabControlStudent.Controls.Add(this.tabPageInsert);
            this.tabControlStudent.Location = new System.Drawing.Point(12, 12);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(441, 322);
            this.tabControlStudent.TabIndex = 1;
            this.tabControlStudent.SelectedIndexChanged += new System.EventHandler(this.tabControlStudent_SelectedIndexChanged);
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.dataGridViewStudentList);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(433, 296);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "List";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.buttonInsert);
            this.tabPageInsert.Controls.Add(this.textBoxStudentName);
            this.tabPageInsert.Controls.Add(this.labelStudentName);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(433, 296);
            this.tabPageInsert.TabIndex = 1;
            this.tabPageInsert.Text = "Insert";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.Size = new System.Drawing.Size(421, 284);
            this.dataGridViewStudentList.TabIndex = 0;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.labelSearchStudentNameaval);
            this.tabPageSearch.Controls.Add(this.labelSearchStudentName);
            this.tabPageSearch.Controls.Add(this.buttonSearch);
            this.tabPageSearch.Controls.Add(this.textBoxStudentID);
            this.tabPageSearch.Controls.Add(this.labelStudentID);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Size = new System.Drawing.Size(433, 296);
            this.tabPageSearch.TabIndex = 2;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(29, 36);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(75, 13);
            this.labelStudentName.TabIndex = 0;
            this.labelStudentName.Text = "Student Name";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(135, 33);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(241, 20);
            this.textBoxStudentName.TabIndex = 1;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(301, 74);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // labelStudentID
            // 
            this.labelStudentID.AutoSize = true;
            this.labelStudentID.Location = new System.Drawing.Point(23, 49);
            this.labelStudentID.Name = "labelStudentID";
            this.labelStudentID.Size = new System.Drawing.Size(58, 13);
            this.labelStudentID.TabIndex = 0;
            this.labelStudentID.Text = "Student ID";
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.Location = new System.Drawing.Point(117, 46);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(225, 20);
            this.textBoxStudentID.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(267, 96);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelSearchStudentName
            // 
            this.labelSearchStudentName.AutoSize = true;
            this.labelSearchStudentName.Location = new System.Drawing.Point(23, 183);
            this.labelSearchStudentName.Name = "labelSearchStudentName";
            this.labelSearchStudentName.Size = new System.Drawing.Size(58, 13);
            this.labelSearchStudentName.TabIndex = 3;
            this.labelSearchStudentName.Text = "Student ID";
            // 
            // labelSearchStudentNameaval
            // 
            this.labelSearchStudentNameaval.AutoSize = true;
            this.labelSearchStudentNameaval.Location = new System.Drawing.Point(114, 183);
            this.labelSearchStudentNameaval.Name = "labelSearchStudentNameaval";
            this.labelSearchStudentNameaval.Size = new System.Drawing.Size(58, 13);
            this.labelSearchStudentNameaval.TabIndex = 4;
            this.labelSearchStudentNameaval.Text = "Student ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 346);
            this.Controls.Add(this.tabControlStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlStudent.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Label labelSearchStudentNameaval;
        private System.Windows.Forms.Label labelSearchStudentName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Label labelStudentID;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label labelStudentName;
    }
}

