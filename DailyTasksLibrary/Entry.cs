using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary
{
    public class Entry : TaskItem
    {
        public Entry(DateOnly date, string name, string description)
        {
            Name = name;
            Description = description;
            CreationDate = date;
            Items = new List<ChecklistItem>();
        }

        public string Name { get; }

        public string Description { get; }

        public List<ChecklistItem> Items { get; }

        public override string ToString()
        {
            string result = Name + (string.IsNullOrEmpty(Description) ? "" : "\n" + Description) + "\n";
            foreach (var item in Items)
            {
                result += "\t" + item.Value + "\n";
            }
            return result;
        }

        public void AddItem(string itemStr)
        {
            AddItem(itemStr, Items.Count * 10);
        }

        public void AddItem(string itemStr, int seq)
        {
            ChecklistItem item = new ChecklistItem(itemStr, seq/*, this*/);
            Items.Add(item);
        }

        //List<ChecklistItem> items;
    }
}
