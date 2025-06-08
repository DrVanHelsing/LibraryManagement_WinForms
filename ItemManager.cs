using Library_Management_System___GUI.Derived_Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace Library_Management_System___GUI
{
    internal class ItemManager
    {
        private readonly Dictionary<string, LibraryItem> items = new();

        public bool AddItem(LibraryItem item)
        {
            if (item == null || items.ContainsKey(item.ID))
                return false;
            items.Add(item.ID, item);
            return true;
        }

        public bool RemoveItem(string id) => items.Remove(id);

        public LibraryItem SearchItem(string id) =>
            items.TryGetValue(id, out var item) ? item : null;

        public IEnumerable<LibraryItem> GetItemsByType(Type type) =>
            items.Values.Where(item => item.GetType() == type);

                public void LoadFromFile(string filePath)
                {
                    if (!File.Exists(filePath))
                        return;

                    foreach (var line in File.ReadLines(filePath).Skip(1))
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        var parts = line.Split(',');
                        if (parts.Length < 8) continue;

                        string type = parts[0];
                        string id = parts[1];
                        string title = parts[2];
                        int year = int.TryParse(parts[3], out int y) ? y : 0;

                        switch (type)
                        {
                            case "Book":
                                AddItem(new Book
                                {
                                    ID = id,
                                    Title = title,
                                    YearPublished = year,
                                    Author = parts[4],
                                    Genre = parts[5]
                                });
                                break;
                            case "DVD":
                                AddItem(new DVD
                                {
                                    ID = id,
                                    Title = title,
                                    YearPublished = year,
                                    Director = parts[4],
                                    Duration = int.TryParse(parts[5], out int d) ? d : 0
                                });
                                break;
                            case "Magazine":
                                AddItem(new Magazine
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
