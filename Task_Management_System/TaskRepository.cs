using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

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

        public bool IsTaskExist(int number_task)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT COUNT(*) FROM Task_table WHERE TaskNumber = @Task_Number";
                int count = connection.QuerySingle<int>(sqlQuery, new { Task_Number = number_task });
                return count > 0;
            }
        }

        public void AddTask(int TaskNumber, string TaskName, string TaskDescription, string TaskStatus, DateTime TaskDate)
        {
            if (IsTaskExist(TaskNumber))
            {
                System.Windows.MessageBox.Show("Такий номер задачі вже існує", "Увага", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                connection.Execute("INSERT INTO Task_table (TaskNumber, TaskName, TaskDescription,  TaskStatus, TaskDate) VALUES (@Task_Number, @Task_Name, @Task_Description,  @Task_Status, @Task_Date)",
                                  new { Task_Number = TaskNumber, Task_Name = TaskName, Task_Description = TaskDescription, Task_Status = TaskStatus, Task_Date = TaskDate });
                System.Windows.MessageBox.Show("Задачу успішно створено", "Успішно", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
            }
        }

        public void UpdateTask(int id, int TaskNumber, string TaskName, string TaskDescription, string TaskStatus, DateTime TaskDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE Task_table SET TaskNumber = @Task_Number, TaskName = @Task_Name, TaskDescription = @Task_Description,  TaskStatus = @Task_Status, TaskDate = @Task_Date  WHERE id_task_table = @Id_Task_Table";
                connection.Execute(sql, new { Task_Number = TaskNumber, Task_Name  = TaskName, Task_Description = TaskDescription, Task_Status = TaskStatus, Task_Date = TaskDate, Id_Task_Table  = id});
                System.Windows.MessageBox.Show("Дані успішно оновлені", "Успішно", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
            }        
        }

        public void DeleteTask(int id)
        {

            if (System.Windows.MessageBox.Show("Ви точно хочете видалити задачу?", "Попередження", MessageBoxButton.YesNo, (MessageBoxImage)MessageBoxIcon.Question) == MessageBoxResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sqlQuery = "DELETE FROM Task_table WHERE id_task_table = @Id_Task_Table";
                    connection.Execute(sqlQuery, new { Id_Task_Table = id });
                    System.Windows.MessageBox.Show("Успішно видалено", "Успішно", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Information);
                }
            }
        }
    }
}
