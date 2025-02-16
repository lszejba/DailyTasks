using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public class ItemsManager
{
    public BindingList<Entry> Entries { get; private set; }

    static DateOnly? currentDate = null;

    public ItemsManager()
    {
        Entries = new BindingList<Entry>();
    }

    public int Count => Entries.Count;

    public static DateOnly CurrentDate
    {
        get
        {
            if (currentDate == null)
            {
                DateTime now = DateTime.Now;
                currentDate = new DateOnly(now.Year, now.Month, now.Day);
            }
            return (DateOnly)currentDate;
        }
    }

    public void AddEntry(DateOnly date, string name, string description)
    {
        Console.WriteLine($"[DEBUG] new entry with name: {name}, description: {description} and date: {date}");
        Entry entry = new Entry(date, name, description);
        Entries.Add(entry);
        SaveAll();
    }

    public Entry? GetItem(int index)
    {
        if (index < 0 || Count == 0 || Count <= index)
        {
            return null;
        }
        return Entries[index];
    }

    public void PrintEntries(DateOnly date = new DateOnly(), bool showCompletedEntries = false)
    {
        int index = 0;
        foreach (var item in Entries)
        {
            Console.WriteLine($"{index++}: {item.FullString()}");
        }
    }

    public void SaveAll()
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        const string fileName = "dailytasks.json";
        var current = Newtonsoft.Json.JsonConvert.SerializeObject(Entries, Newtonsoft.Json.Formatting.Indented);
        Console.WriteLine(current);

        File.WriteAllText(Path.Combine(path, fileName), current);
        Console.WriteLine($"Tasks saved to {path}");
    }

    public void LoadTasks()
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        const string fileName = "dailytasks.json";
        var fullPath = Path.Combine(path, fileName);
        if (!File.Exists(fullPath))
        {
            return;
        }

        var currentStr = File.ReadAllText(fullPath);
        Console.WriteLine(currentStr);

        if (!string.IsNullOrEmpty(currentStr))
        {
            Entries = Newtonsoft.Json.JsonConvert.DeserializeObject<BindingList<Entry>>(currentStr);
        }
    }
}
