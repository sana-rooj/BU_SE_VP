using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectivity
{
    class DBConnection
    {
        private MySqlConnection mysqlconnection = null;
        private string databaseName = "mydb";
        private static DBConnection connection;
        public static DBConnection ConnObject
        {
            get
            {
                if (connection == null)
                    connection = new DBConnection();
                return connection;
            }
        }
        private DBConnection()
        {

        }

        public bool IsConnect()
        {
            if (mysqlconnection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server=127.0.0.1; database={0}; UID=root; password=root; SslMode=none", databaseName);
                mysqlconnection = new MySqlConnection(connstring);
                mysqlconnection.Open();
            }

            return true;
        }

        public void SaveStudentRecord(Student std)
        {
            if(IsConnect())
            {
                string query = "INSERT INTO STUDENT(name) VALUES (?name)";
                var command = new MySqlCommand(query, mysqlconnection);
                command.Parameters.AddWithValue("?name", std.name);
                command.ExecuteNonQuery();                
            }
        }

        public Student LoadStudentRecord(int studentid)
        {
            Student obj = new Student();
            if (IsConnect())
            {
                string query = "SELECT *FROM STUDENT where id=?id";
                var command = new MySqlCommand(query, mysqlconnection);
                command.Parameters.AddWithValue("?id", studentid);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    obj.id = reader.GetInt32(0);
                    obj.name = reader.GetString(1);
                }
                reader.Close();
            }
            return obj;
        }

        public List<Student> LoadAllStudentRecords()
        {
            List<Student> studentlist = new List<Student>();
            if (IsConnect())
            {                
                string query = "SELECT *FROM STUDENT";
                var command = new MySqlCommand(query, mysqlconnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Student obj = new Student();
                    obj.id = reader.GetInt32(0);
                    obj.name = reader.GetString(1);
                    studentlist.Add(obj);
                }
                reader.Close();
            }
            return studentlist;
        }
    }
}
