using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary
{
    public abstract class TaskItem
    {
        public bool IsCompleted { get; set; }
        public DateOnly CreationDate { get; set; }
        public DateOnly CloseDate { get; set; }

        public List<string>? Notes { get; set; }
    }
}
