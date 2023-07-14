using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System
{
    internal class Task_model
    {
       public int id_task_table { get; set; }
       public int TaskNumber { get; set; }
       public string TaskDescription { get; set; }
       public string TaskStatus { get; set; }
       public DateTime TaskDate { get; set; }
    }
}
