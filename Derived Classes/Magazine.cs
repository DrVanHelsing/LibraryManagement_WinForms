using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System___GUI.Derived_Classes
{
    internal class Magazine : LibraryItem
    {
        public int IssueNumber { get; set; }
        public string Month { get; set; }

        public static Magazine Create()
        {
            string? title;
            do
            {
                title = Interaction.InputBox("Magazine Title:", "Add Magazine");
                if (string.IsNullOrWhiteSpace(title))
                    MessageBox.Show("Title is required.", "Missing Title");
            } while (string.IsNullOrWhiteSpace(title));

            string id = LibraryItem.GenerateUniqueId(title);

            int year;
            string? yearInput;
            do
            {
                yearInput = Interaction.InputBox("Year Published:", "Add Magazine");
                if (!int.TryParse(yearInput, out year))
                    MessageBox.Show("Enter a valid year.", "Invalid Year");
            } while (!int.TryParse(yearInput, out year));

            int issue;
            string? issueInput;
            do
            {
                issueInput = Interaction.InputBox("Issue Number:", "Add Magazine");
                if (!int.TryParse(issueInput, out issue))
                    MessageBox.Show("Enter a valid issue number.", "Invalid Issue Number");
            } while (!int.TryParse(issueInput, out issue));

            string? month;
            do
            {
                month = Interaction.InputBox("Month:", "Add Magazine");
                if (string.IsNullOrWhiteSpace(month))
                    MessageBox.Show("Month is required.", "Missing Month");
            } while (string.IsNullOrWhiteSpace(month));

            return new Magazine { ID = id, Title = title, YearPublished = year, IssueNumber = issue, Month = month };
        }
    }
}
