//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DataBaseExample
//{
    
//    class Student: DBOperation
//    {
//        private static Student std;
//        public static Student StudentObject
//        {
//            get
//            {
//                if (std == null)
//                    std = new Student();
//                return std;
//            }
//        }
//        public Student()
//        {

//        }

//        public int id;
//        public string name;
//        public int semester;

//        public void AddStudent(Student obj)
//        {
//            if(IsConnected())
//            {
//                string query = "INSERT INTO STUDENT(name, semester) VALUES(?name, ?semester)";
//                MySqlCommand command = new MySqlCommand(query, connection);

//                command.Parameters.AddWithValue("?name", obj.name);
//                command.Parameters.AddWithValue("?semester", obj.semester);
//                command.ExecuteNonQuery();
//            }
//        }

//        public List<Student> LoadAllStudents()
//        {
//            List<Student> studentlist = new List<Student>();

//            if(IsConnected())
//            {
//                string query = "SELECT *FROM STUDENT";
//                MySqlCommand command = new MySqlCommand(query, connection);
//                MySqlDataReader reader = command.ExecuteReader();
//                while(reader.Read())
//                {
//                    Student obj = new Student();
//                    obj.id = int.Parse(reader["id"].ToString());
//                    obj.name = reader["name"].ToString();
//                    obj.semester = int.Parse(reader["semester"].ToString());
//                    studentlist.Add(obj);
//                }
//            }
//            return studentlist;
//        }
//    }
//}
