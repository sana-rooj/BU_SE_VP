namespace DataBaseExample
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
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSemester = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSemester = new System.Windows.Forms.TextBox();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.tabControlStudent.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabPageList);
            this.tabControlStudent.Controls.Add(this.tabPageAdd);
            this.tabControlStudent.Location = new System.Drawing.Point(12, 12);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(348, 263);
            this.tabControlStudent.TabIndex = 0;
            this.tabControlStudent.SelectedIndexChanged += new System.EventHandler(this.tabControlStudent_SelectedIndexChanged);
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.dataGridViewStudent);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(340, 237);
            this.tabPageList.TabIndex = 0;
            this.tabPageList.Text = "List Students";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.buttonInsert);
            this.tabPageAdd.Controls.Add(this.textBoxSemester);
            this.tabPageAdd.Controls.Add(this.textBoxName);
            this.tabPageAdd.Controls.Add(this.labelSemester);
            this.tabPageAdd.Controls.Add(this.labelName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(340, 237);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add Student";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(328, 225);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(25, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelSemester
            // 
            this.labelSemester.AutoSize = true;
            this.labelSemester.Location = new System.Drawing.Point(25, 77);
            this.labelSemester.Name = "labelSemester";
            this.labelSemester.Size = new System.Drawing.Size(51, 13);
            this.labelSemester.TabIndex = 1;
            this.labelSemester.Text = "Semester";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(112, 26);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxSemester
            // 
            this.textBoxSemester.Location = new System.Drawing.Point(112, 74);
            this.textBoxSemester.Name = "textBoxSemester";
            this.textBoxSemester.Size = new System.Drawing.Size(167, 20);
            this.textBoxSemester.TabIndex = 3;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(204, 134);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(75, 23);
            this.buttonInsert.TabIndex = 4;
            this.buttonInsert.Text = "Insert";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.tabControlStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlStudent.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.TabPage tabPageAdd;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxSemester;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelSemester;
        private System.Windows.Forms.Label labelName;
    }
}

