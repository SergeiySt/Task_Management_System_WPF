using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_Management_System
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TaskController controller;
        private Task_WPF taskWindow;
        private TaskRepository repository;

        private List<Thread> threadList;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
            repository = new TaskRepository(connectionString);
            controller = new TaskController(repository);
            listBoxTasks.ItemsSource = repository.GetTasks();

            threadList = new List<Thread>();
        }

      
        private void listBoxTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task_model selectedTask = (Task_model)listBoxTasks.SelectedItem;

            // Создаем новый поток для открытия окна Task_WPF
            Thread thread = new Thread(() =>
            {
                taskWindow = new Task_WPF(selectedTask);
                taskWindow.ShowDialog();
            });

            thread.SetApartmentState(ApartmentState.STA); 
            thread.Start();

            threadList.Add(thread);
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            foreach (Thread thread in threadList)
            {
                thread.Join(); 
            }
            System.Windows.Application.Current.Shutdown();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxTasks.SelectedItems.Count == 0)
            {
                System.Windows.MessageBox.Show("Виберіть задачу для видалення.", "Увага", MessageBoxButton.OK, (MessageBoxImage)MessageBoxIcon.Warning);
                return;
            }

            Task_model selectedTask = (Task_model)listBoxTasks.SelectedItem;

            repository.DeleteTask(selectedTask.id_task_table);

            //listBoxTasks.ItemsSource = repository.GetTasks();
        }

        private void textBoxFinde_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = textBoxFinde.Text.ToLower();

            listBoxTasks.ItemsSource = controller.GetTasks().Where(task =>
                task.TaskNumber.ToString().ToLower().Contains(searchText) ||
                task.TaskName.ToLower().Contains(searchText)
            ).ToList();
        }

        private  void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                Task_WPF_2 task_WPF_2 = new Task_WPF_2();
                task_WPF_2.ShowDialog();
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void buttonUpdateList_Click(object sender, RoutedEventArgs e)
        {
            //listBoxTasks.ItemsSource = repository.GetTasks();
            listBoxTasks.ItemsSource = controller.GetTasks();
        }
    }
}
