using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Task_Management_System
{
    /// <summary>
    /// Interaction logic for Task_WPF.xaml
    /// </summary>
    public partial class Task_WPF : Window
    {
        private Task_model task;
        private TaskRepository taskRepository;
        private TaskController controller;

        public delegate void TaskUpdatedEventHandler();
        public event TaskUpdatedEventHandler TaskUpdated;
        internal Task_WPF(Task_model selectedTask)
        {
            InitializeComponent();

            if (selectedTask != null)
            {
                this.task = selectedTask;

                textBoxTaskNumber.Text = task.TaskNumber.ToString();
                textBoxTaskName.Text = task.TaskName;
                textBoxStatus.Text = task.TaskStatus.ToString();

                FlowDocument flowDocument = new FlowDocument();
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(task.TaskDescription);
                flowDocument.Blocks.Add(paragraph);

                richTextBox.Document = flowDocument;


                string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
                taskRepository = new TaskRepository(connectionString);
            }
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            TaskUpdated?.Invoke();

            this.Close();
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            int taskNumber;
            if (!int.TryParse(textBoxTaskNumber.Text, out taskNumber))
            {
                System.Windows.MessageBox.Show("Некорректний номер задачі", "Помилка", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Error);
                return;
            }

            string taskName = textBoxTaskName.Text;
            string taskStatus = textBoxStatus.Text;
            string taskDescription = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text;


            taskRepository.UpdateTask(task.id_task_table, taskNumber, taskName, taskDescription, taskStatus, task.TaskDate);

            //TaskUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}
