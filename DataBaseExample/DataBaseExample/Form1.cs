using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.name = textBoxName.Text;
            obj.semester = int.Parse(textBoxSemester.Text);

            obj.AddStudent(obj);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> studentlist =  obj.LoadAllStudents();
            dataGridViewStudent.Rows.Clear();
            dataGridViewStudent.Refresh();
            dataGridViewStudent.ColumnCount = 3;
            dataGridViewStudent.Columns[0].Name = "Student ID";
            dataGridViewStudent.Columns[1].Name = "Student Name";
            dataGridViewStudent.Columns[2].Name = "Student Semester";

            foreach (Student std in studentlist)
            {
                string[] data = { std.id.ToString(), std.name, std.semester.ToString() };
                dataGridViewStudent.Rows.Add(data);
            }
        }

        private void tabControlStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlStudent.SelectedIndex == 0)
            {
                Form1_Load(sender, e);
            }
        }
    }
}
