using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBConnectivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlStudent.SelectedIndex == 0)
            {
                dataGridViewStudentList.Rows.Clear();
                dataGridViewStudentList.Refresh();
                dataGridViewStudentList.ColumnCount = 2;
                dataGridViewStudentList.Columns[0].Name = "Student ID";
                dataGridViewStudentList.Columns[1].Name = "Student Name";

                List<Student> studentlist = DBConnection.ConnObject.LoadAllStudentRecords();
                foreach(Student std in studentlist)
                {
                    string[] data = { std.id.ToString(), std.name };
                    dataGridViewStudentList.Rows.Add(data);
                }
                //dataGridViewStudentList.DataSource = DBConnection.ConnObject.LoadAllStudentRecords();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int studentid = int.Parse(textBoxStudentID.Text);
            Student obj = DBConnection.ConnObject.LoadStudentRecord(studentid);
            labelSearchStudentNameaval.Text = obj.name;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.name = textBoxStudentName.Text;
            DBConnection.ConnObject.SaveStudentRecord(obj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (tabControlStudent.SelectedIndex == 0)
            {
                dataGridViewStudentList.Rows.Clear();
                dataGridViewStudentList.Refresh();
                dataGridViewStudentList.ColumnCount = 2;
                dataGridViewStudentList.Columns[0].Name = "Student ID";
                dataGridViewStudentList.Columns[1].Name = "Student Name";

                List<Student> studentlist = DBConnection.ConnObject.LoadAllStudentRecords();
                foreach (Student std in studentlist)
                {
                    string[] data = { std.id.ToString(), std.name };
                    dataGridViewStudentList.Rows.Add(data);
                }
                //dataGridViewStudentList.DataSource = DBConnection.ConnObject.LoadAllStudentRecords();
            }
        }
    }
}
