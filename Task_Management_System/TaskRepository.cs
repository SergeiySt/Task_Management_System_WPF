using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    internal class TaskRepository
    {
        private string connectionString;

        public TaskRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Task_model> GetTasks()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Task_table";
                return connection.Query<Task_model>(query).ToList();
            }
        }


        //public List<Student> SelectedStudents()
        //{
        //    List<Student> students = dbConnection.Query<Student>("SELECT id_students, SName, SSurname, SAge FROM Students").ToList();
        //    return students;
        //}
    }
}
