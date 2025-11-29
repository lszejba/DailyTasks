using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyTasksLibrary;

public class JSONContents
{
    public BindingList<Entry>? Entries;
    public string Version { get; set; }

    public JSONContents()
    {
        Entries = new BindingList<Entry>();
        Version = "?";
    }
}

public class ItemsManager
{
    public BindingList<Entry> Entries { get; private set; }
    public BindingList<Entry>? _UnfilteredEntries;

    private JSONContents? _jsonContents;

    static DateOnly? currentDate = null;

    public ItemsManager()
    {
        Entries = new BindingList<Entry>();
        _UnfilteredEntries = new BindingList<Entry>();

        _jsonContents = new JSONContents();
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
        Entry entry = new Entry(date, name, description);
        Entries.Add(entry);
        _UnfilteredEntries?.Add(entry);
        _jsonContents?.Entries?.Add(entry);
        SaveAll();
    }

    public void AddItem(Entry parentEntry, DateOnly date, string name)
    {
        parentEntry.AddItem(date, name);
        SaveAll();
    }
    
    public void AddNotes(List<Tuple<TaskItem, string>> notes)
    {
        foreach (var noteTuple in notes)
        {
            noteTuple.Item1.Note = noteTuple.Item2;
        }
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

    public void CompleteItem(TaskItem item)
    {
        item.Complete(ItemsManager.CurrentDate);
        SaveAll();
    }

    public void CancelItem(TaskItem item)
    {
        item.Cancel(ItemsManager.CurrentDate);
        SaveAll();
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
        Save(string.Empty);
    }

    public void CreateBackup()
    {
        string prefix = DateTime.Now.ToString("yyyy-MM-dd_HH-mm_");
        Save(prefix);
    }

    void Save(string prefix)
    {
        var path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string fileName = prefix + "dailytasks.json";
        var current = Newtonsoft.Json.JsonConvert.SerializeObject(_jsonContents, Newtonsoft.Json.Formatting.Indented);

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

        if (!string.IsNullOrEmpty(currentStr))
        {
            _jsonContents = Newtonsoft.Json.JsonConvert.DeserializeObject<JSONContents>(currentStr);
        }

        if (_jsonContents is null)
        {
            return;
        }

        foreach (Entry? entry in _jsonContents.Entries)
        {
            if (!(entry.IsCanceled || entry.IsCompleted))
            {
                Entries.Add(entry);
            }
        }

        UpdateVersion();
        CreateBackup();
    }

    void UpdateVersion()
    {
        if (_jsonContents is not null || _jsonContents?.Version == CurrentVersion)
        {
            return;
        }
        // Perform any updates needed between versions
        _jsonContents.Version = CurrentVersion;
    }

    const string CurrentVersion = "1.2";
}
