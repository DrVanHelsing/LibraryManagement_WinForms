using Library_Management_System___GUI.Derived_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System___GUI
{
    internal class ItemManager
    {
        private readonly Dictionary<string, LibraryItem> items = new();

        public bool AddItem(LibraryItem item)
        {
            if (items.ContainsKey(item.ID))
                return false;
            items.Add(item.ID, item);
            return true;
        }

        public bool RemoveItem(string id)
        {
            return items.Remove(id);
        }

        public LibraryItem SearchItem(string id)
        {
            items.TryGetValue(id, out var item);
            return item;
        }

        public IEnumerable<LibraryItem> GetItemsByType(Type type)
        {
            foreach (var item in items.Values)
            {
                if (item.GetType() == type)
                    yield return item;
            }
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            using var reader = new StreamReader(filePath);
            string? header = reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                string type = parts[0];
                string id = parts[1];
                string title = parts[2];
                int year = int.TryParse(parts[3], out int y) ? y : 0;

                switch (type)
                {
                    case "Book":
                        string author = parts[4];
                        string genre = parts[5];
                        AddItem(new Book
                        {
                            ID = id,
                            Title = title,
                            YearPublished = year,
                            Author = author,
                            Genre = genre
                        });
                        break;
                    case "DVD":
                        string director = parts[4];
                        int duration = int.TryParse(parts[5], out int d) ? d : 0;
                        AddItem(new DVD
                        {
                            ID = id,
                            Title = title,
                            YearPublished = year,
                            Director = director,
                            Duration = duration
                        });
                        break;
                    case "Magazine":
                        int issue = int.TryParse(parts[6], out int i) ? i : 0;
                        string month = parts[7];
                        AddItem(new Magazine
                        {
                            ID = id,
                            Title = title,
                            YearPublished = year,
                            IssueNumber = issue,
                            Month = month
                        });
                        break;
                }
            }
        }

        public static List<LibraryItem> LoadItemsFromFile(string filePath)
        {
            var items = new List<LibraryItem>();
            var lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');

                string type = parts[0];
                string id = parts[1];
                string title = parts[2];
                int year = int.TryParse(parts[3], out int y) ? y : 0;

                switch (type)
                {
                    case "Book":
                        items.Add(new Book
                        {
                            ID = id,
                            Title = title,
                            YearPublished = year,
                            Author = parts[4],
                            Genre = parts[5]
                        });
                        break;
                    case "DVD":
                        items.Add(new DVD
                        {
                            ID = id,
                            Title = title,
                            YearPublished = year,
                            Director = parts[4],
                            Duration = int.TryParse(parts[5], out int d) ? d : 0
                        });
                        break;
                    case "Magazine":
                        items.Add(new Magazine
                        {
                            ID = id,
                            Title = title,
                            YearPublished = year,
                            IssueNumber = int.TryParse(parts[6], out int issue) ? issue : 0,
                            Month = parts[7]
                        });
                        break;
                }
            }
            return items;
        }
    }
}
