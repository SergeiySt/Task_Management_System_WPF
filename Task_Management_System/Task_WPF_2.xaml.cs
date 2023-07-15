using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Configuration;
using System.Threading;

namespace Task_Management_System
{
    /// <summary>
    /// Interaction logic for Task_WPF_2.xaml
    /// </summary>
    public partial class Task_WPF_2 : Window
    {
        private Task_model task;
        private TaskRepository taskRepository;
        private TaskController controller;

        public Task_WPF_2()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
            taskRepository = new TaskRepository(connectionString);
        }
        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.Abort();
            this.Close();
        }

        private void buttonAdd_Click_1(object sender, RoutedEventArgs e)
        {
            int taskNumber;
            if (!int.TryParse(textBoxTaskNumber2.Text, out taskNumber))
            {
                System.Windows.MessageBox.Show("Некорректний номер задачі", "Помилка", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
                return;
            }

            string taskName = textBoxTaskName2.Text;
            string taskStatus = textBoxStatus2.Text;
            string taskDescription = new TextRange(richTextBox2.Document.ContentStart, richTextBox2.Document.ContentEnd).Text;
            DateTime? taskDate = datePicker2.SelectedDate;


            taskRepository.AddTask(taskNumber, taskName, taskDescription, taskStatus, (DateTime)taskDate);

            this.Close();
        }
    }
}
