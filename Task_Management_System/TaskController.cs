using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    internal class TaskController
    {
        private TaskRepository repository;

        public TaskController(TaskRepository repository)
        {
            this.repository = repository;
        }

        public List<Task> GetTasks()
        {
            return repository.GetTasks();
        }
    }
}
