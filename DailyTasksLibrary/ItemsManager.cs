using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public class ItemsManager
{
    public List<Entry> entries;
    public BindingList<Entry> Entries;

    static DateOnly? currentDate = null;

    public ItemsManager()
    {
        entries = new List<Entry>();
        Entries = new BindingList<Entry>();
        Entries.AddingNew += new AddingNewEventHandler(Entries_AddingNew);
        Entries.ListChanged += new ListChangedEventHandler(Entries_ListChanged);
    }

    public int Count { get { return entries.Count; } }

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
        entries.Add(entry);
        Entries.Add(entry);
        SaveAll();
    }

    /*public void AddItem(int index, string item)
    {
        Entry parent = entries[index];
        parent.AddItem(item);
    }*/

    public Entry? GetItem(int index)
    {
        if (entries.Count == 0) return null;
        if (entries.Count <= index) return null;
        if (index < 0) return null;
        return entries[index];
    }

    public void PrintEntries(DateOnly date = new DateOnly(), bool showCompletedEntries = false)
    {
        int index = 0;
        foreach (var item in entries)
        {
            Console.WriteLine($"{index++}: {item.FullString()}");
        }
    }

    public void SaveAll()
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        const string fileName = "dailytasks.json";
        // ToDo - update archive (read if needed first), save current state of archive
        var current = Newtonsoft.Json.JsonConvert.SerializeObject(entries, Newtonsoft.Json.Formatting.Indented);
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
            entries = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entry>>(currentStr);
        }

        foreach(Entry entry in entries)
        {
            Entries.Add(entry);
        }
    }

    private void Entries_AddingNew(object sender, AddingNewEventArgs e)
    {

    }

    private void Entries_ListChanged(object sender, ListChangedEventArgs e)
    {

    }
}
