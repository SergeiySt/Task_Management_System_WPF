using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
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
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
            TaskRepository repository = new TaskRepository(connectionString);
            controller = new TaskController(repository);
            // listBoxTasks.ItemsSource = controller.GetTasks();
            listBoxTasks.ItemsSource = repository.GetTasks();


        }

        private void listBoxTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
