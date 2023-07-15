﻿using System;
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
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString;
            TaskRepository repository = new TaskRepository(connectionString);
            controller = new TaskController(repository);
            listBoxTasks.ItemsSource = repository.GetTasks();

            

        }

        private void TaskWindow_TaskUpdated()
        {
            // Обновляем список задач
            Dispatcher.Invoke(() =>
            {
                listBoxTasks.ItemsSource = controller.GetTasks();
            });
        }
        //private void TaskWindow_Closed(object sender, EventArgs e)
        //{
        //    // Обновляем список задач в listBox
        //        listBoxTasks.ItemsSource = controller.GetTasks();
        //}

        private void listBoxTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Task_model selectedTask = (Task_model)listBoxTasks.SelectedItem;

            // Создаем новый поток для открытия окна Task_WPF
            Thread thread = new Thread(() =>
            {
                Task_WPF taskWindow = new Task_WPF(selectedTask);
               // taskWindow.Closed += TaskWindow_Closed; // Подписываемся на событие Closed окна
                taskWindow.TaskUpdated += TaskWindow_TaskUpdated; // Подписываемся на событие TaskUpdated
                taskWindow.ShowDialog();
            });

            thread.SetApartmentState(ApartmentState.STA); 
            thread.Start();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
