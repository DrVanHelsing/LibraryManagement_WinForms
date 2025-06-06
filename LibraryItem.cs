using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System___GUI
{
    internal abstract class LibraryItem
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public int YearPublished { get; set; }

        public static string GenerateUniqueId(string title)
        {
            var random = new Random();
            string cleanTitle = new string(title
                .Where(char.IsLetterOrDigit)
                .Take(3)
                .ToArray()).ToUpper();

            string randomDigits = random.Next(100, 999).ToString();
            return $"{cleanTitle}{randomDigits}";
        }
    }
}
