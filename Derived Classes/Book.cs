using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System___GUI.Derived_Classes
{
    internal class Book : LibraryItem
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public static Book Create()
        {
            string? title;
            do
            {
                title = Interaction.InputBox("Book Title:", "Add Book");
                if (string.IsNullOrWhiteSpace(title))
                    MessageBox.Show("Title is required.", "Missing Title");
            } while (string.IsNullOrWhiteSpace(title));

            string id = LibraryItem.GenerateUniqueId(title);

            int year;
            string? yearInput;
            do
            {
                yearInput = Interaction.InputBox("Year Published:", "Add Book");
                if (!int.TryParse(yearInput, out year))
                    MessageBox.Show("Enter a valid year.", "Invalid Year");
            } while (!int.TryParse(yearInput, out year));

            string? author;
            do
            {
                author = Interaction.InputBox("Author:", "Add Book");
                if (string.IsNullOrWhiteSpace(author))
                    MessageBox.Show("Author is required.", "Missing Author");
            } while (string.IsNullOrWhiteSpace(author));

            string? genre;
            do
            {
                genre = Interaction.InputBox("Genre:", "Add Book");
                if (string.IsNullOrWhiteSpace(genre))
                    MessageBox.Show("Genre is required.", "Missing Genre");
            } while (string.IsNullOrWhiteSpace(genre));

            return new Book { ID = id, Title = title, YearPublished = year, Author = author, Genre = genre };
        }
    }
}
