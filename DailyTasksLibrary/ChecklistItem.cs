using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DailyTasksLibrary
{
    public class ChecklistItem : TaskItem
    {
        public ChecklistItem(string value, int seq/*, Entry parent*/)
        {
            Value = value;
            DateTime now = DateTime.Now;
            CreationDate = new DateOnly(now.Year, now.Month, now.Day);
            SequenceNumber = seq;
            //Parent = parent;
        }

        public string Value { get; }

        public int SequenceNumber { get; set; }

        //[JsonIgnore]
        //public Entry Parent { get; }
    }
}
