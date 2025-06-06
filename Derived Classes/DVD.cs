using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Library_Management_System___GUI.Derived_Classes
{
    internal class DVD : LibraryItem
    {
        public string Director { get; set; }
        public int Duration { get; set; }

        public static DVD Create()
        {
            string? title;
            do
            {
                title = Interaction.InputBox("DVD Title:", "Add DVD");
                if (string.IsNullOrWhiteSpace(title))
                    MessageBox.Show("Title is required.", "Missing Title");
            } while (string.IsNullOrWhiteSpace(title));

            string id = LibraryItem.GenerateUniqueId(title);

            int year;
            string? yearInput;
            do
            {
                yearInput = Interaction.InputBox("Year of Release:", "Add DVD");
                if (!int.TryParse(yearInput, out year))
                    MessageBox.Show("Enter a valid year.", "Invalid Year");
            } while (!int.TryParse(yearInput, out year));

            string? director;
            do
            {
                director = Interaction.InputBox("Director:", "Add DVD");
                if (string.IsNullOrWhiteSpace(director))
                    MessageBox.Show("Director is required.", "Missing Director");
            } while (string.IsNullOrWhiteSpace(director));

            int duration;
            string? durationInput;
            do
            {
                durationInput = Interaction.InputBox("Duration (minutes):", "Add DVD");
                if (!int.TryParse(durationInput, out duration))
                    MessageBox.Show("Enter a valid duration in minutes.", "Invalid Duration");
            } while (!int.TryParse(durationInput, out duration));

            return new DVD { ID = id, Title = title, YearPublished = year, Director = director, Duration = duration };
        }
    }
}

