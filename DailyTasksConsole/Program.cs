using DailyTasksLibrary;

ItemsManager manager = new ItemsManager();

manager.LoadTasks();

while (true)
{
    Console.Write("Enter command ('list' for list of commands): ");
    string cmd = Console.ReadLine();
    DateTime now = DateTime.Now;
    switch (cmd.ToLower())
    {
        case "list":
            Console.WriteLine("List of commands: ");
            Console.WriteLine("- list - list of commands (this)");
            Console.WriteLine("- add  - add new entry");
            Console.WriteLine("- item - add new item to existing entry");
            Console.WriteLine("- print - print all entries for selected date");
            Console.WriteLine("- save - serialize and save all entries as JSON");
            Console.WriteLine("- note - add note to entry or item");
            Console.WriteLine("- exit - save all and quit");
            break;
        case "add":
            Console.Write("(format - [Name]\\t(Description)\\t(date): ");
            string entryStr = Console.ReadLine();
            string[] entryItems = entryStr.Split('\t');
            if (entryItems.Length < 1)
            {
                Console.WriteLine("ERROR: Invalid format");
                break;
            }
            string dateStr = entryItems.Length < 3 ? string.Empty : entryItems[2];
            DateOnly entryDate = string.IsNullOrEmpty(dateStr) ? new DateOnly(now.Year, now.Month, now.Day) : ParseDate(dateStr);
            manager.AddEntry(entryDate, entryItems[0], entryItems.Length > 1 ? entryItems[1] : string.Empty);
            break;
        case "print":
            Console.Write("- enter date (empty for today): ");
            string printStr = Console.ReadLine();
            DateOnly printDate = string.IsNullOrEmpty(printStr) ? new DateOnly(now.Year, now.Month, now.Day) : ParseDate(printStr);
            manager.PrintEntries(printDate);
            break;
        case "item":
            if (manager.Count == 0)
            {
                Console.WriteLine("No entries added yet");
                break;
            }
            Console.Write($"(format [Index](0-{manager.Count - 1})\\t[Item]): ");
            string itemStr = Console.ReadLine();
            string[] itemItems = itemStr.Split('\t');
            if (itemItems.Length < 2)
            {
                Console.WriteLine("ERROR: Invalid format");
                break;
            }
            int index = int.Parse(itemItems[0]);
            if (index > manager.Count)
            {
                Console.WriteLine("ERROR: Invalid entry index selected");
                break;
            }
            manager.AddItem(index, itemItems[1]);
            break;
        case "save":
            manager.SaveAll();
            break;
        case "note":
            Console.WriteLine($"(format [Entry Index]\t(Item index)\t[Note]): ");
            string noteStr = Console.ReadLine();
            string[] noteItems = noteStr.Split('\t');
            switch (noteItems.Length)
            {
                case 2:
                    throw new NotImplementedException();
                    break;
                case 3:
                    throw new NotImplementedException();
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid format");
                    break;
            }
            break;
        case "exit":
            manager.SaveAll();
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid command.");
            break;
    }
}

DateOnly ParseDate(string dateStr)
{
    DateTime now = DateTime.Now;
    string[] dateItems = dateStr.Split('-');
    if (dateItems.Length != 3) 
    {
        return new DateOnly(now.Year, now.Month, now.Day);
    }
    int year = -1;
    int month = -1;
    int day = -1;
    if (!(int.TryParse(dateItems[0], out year) && int.TryParse(dateItems[1], out month) && int.TryParse(dateItems[2], out day)))
    {
        return new DateOnly(now.Year, now.Month, now.Day);
    }

    return new DateOnly(year, month, day);
}