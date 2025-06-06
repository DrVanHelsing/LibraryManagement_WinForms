using Library_Management_System___GUI.Derived_Classes;

namespace Library_Management_System___GUI
{
    public partial class Form1 : Form
    {
        private readonly ItemManager manager = new ItemManager();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void AddItem(string itemType)
        {
            try
            {
                LibraryItem? item = itemType switch
                {
                    "Book" => Book.Create(),
                    "DVD" => DVD.Create(),
                    "Magazine" => Magazine.Create(),
                    _ => null
                };

                if (item == null)
                    return;

                if (!ValidateInput(item.Title, "Title") ||
                    !ValidateInput(item.YearPublished.ToString(), "Year Published", true))
                    return;

                if (item is Book book)
                {
                    if (!ValidateInput(book.Author, "Author") ||
                        !ValidateInput(book.Genre, "Genre"))
                        return;
                }
                else if (item is DVD dvd)
                {
                    if (!ValidateInput(dvd.Director, "Director") ||
                        !ValidateInput(dvd.Duration.ToString(), "Duration", true))
                        return;
                }
                else if (item is Magazine mag)
                {
                    if (!ValidateInput(mag.Month, "Month") ||
                        !ValidateInput(mag.IssueNumber.ToString(), "Issue Number", true))
                        return;
                }

                if (manager.AddItem(item))
                {
                    MessageBox.Show($"{itemType} added successfully. Generated ID: {item.ID}");
                    RefreshAllGrids();
                }
                else
                {
                    MessageBox.Show("ID already exists. Item not added.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter correct data types.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DeleteSelectedItem(DataGridView grid)
        {
            if (grid.CurrentRow == null) return;
            var id = grid.CurrentRow.Cells["ID"].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;

            if (MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (manager.RemoveItem(id))
                {
                    MessageBox.Show("Item deleted.");
                    RefreshAllGrids();
                }
                else
                {
                    MessageBox.Show("Item not found.");
                }
            }
        }

        private void UpdateSelectedItem(DataGridView grid)
        {
            if (grid.CurrentRow == null) return;
            var id = grid.CurrentRow.Cells["ID"].Value?.ToString();
            if (string.IsNullOrEmpty(id)) return;
            var item = manager.SearchItem(id);
            if (item == null) return;

            string? title = Microsoft.VisualBasic.Interaction.InputBox("Edit Title:", "Update Item", item.Title);
            if (!ValidateInput(title, "Title")) return;

            string? yearStr = Microsoft.VisualBasic.Interaction.InputBox("Edit Year:", "Update Item", item.YearPublished.ToString());
            if (!ValidateInput(yearStr, "Year Published", true)) return;
            int year = int.TryParse(yearStr, out int y) ? y : item.YearPublished;

            item.Title = title;
            item.YearPublished = year;

            switch (item)
            {
                case Book book:
                    string? author = Microsoft.VisualBasic.Interaction.InputBox("Edit Author:", "Update Book", book.Author);
                    if (!ValidateInput(author, "Author")) return;
                    string? genre = Microsoft.VisualBasic.Interaction.InputBox("Edit Genre:", "Update Book", book.Genre);
                    if (!ValidateInput(genre, "Genre")) return;
                    book.Author = author;
                    book.Genre = genre;
                    break;
                case DVD dvd:
                    string? director = Microsoft.VisualBasic.Interaction.InputBox("Edit Director:", "Update DVD", dvd.Director);
                    if (!ValidateInput(director, "Director")) return;
                    string? durationStr = Microsoft.VisualBasic.Interaction.InputBox("Edit Duration:", "Update DVD", dvd.Duration.ToString());
                    if (!ValidateInput(durationStr, "Duration", true)) return;
                    dvd.Director = director;
                    dvd.Duration = int.TryParse(durationStr, out int d) ? d : dvd.Duration;
                    break;
                case Magazine mag:
                    string? month = Microsoft.VisualBasic.Interaction.InputBox("Edit Month:", "Update Magazine", mag.Month);
                    if (!ValidateInput(month, "Month")) return;
                    string? issueStr = Microsoft.VisualBasic.Interaction.InputBox("Edit Issue Number:", "Update Magazine", mag.IssueNumber.ToString());
                    if (!ValidateInput(issueStr, "Issue Number", true)) return;
                    mag.Month = month;
                    mag.IssueNumber = int.TryParse(issueStr, out int i) ? i : mag.IssueNumber;
                    break;
            }

            RefreshAllGrids();
        }

        private void RefreshAllGrids()
        {
            // Books: ID, Title, YearPublished, Author, Genre
            var books = manager.GetItemsByType(typeof(Book))
                .Cast<Book>()
                .Select(b => new
                {
                    b.ID,
                    b.Title,
                    YearPublished = b.YearPublished,
                    b.Author,
                    b.Genre
                })
                .ToList();
            dataGridView4.DataSource = null;
            dataGridView4.DataSource = books;

            // DVDs: ID, Title, Year, Director, Duration
            var dvds = manager.GetItemsByType(typeof(DVD))
                .Cast<DVD>()
                .Select(d => new
                {
                    d.ID,
                    d.Title,
                    Year = d.YearPublished,
                    d.Director,
                    d.Duration
                })
                .ToList();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = dvds;

            // Magazines: ID, Title, YearPublished, IssueNumber, Month
            var magazines = manager.GetItemsByType(typeof(Magazine))
                .Cast<Magazine>()
                .Select(m => new
                {
                    m.ID,
                    m.Title,
                    YearPublished = m.YearPublished,
                    m.IssueNumber,
                    m.Month
                })
                .ToList();
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = magazines;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager.LoadFromFile("library_items.txt");
            RefreshAllGrids();
        }

        // --- ADD BUTTONS ---
        private void button1_Click(object sender, EventArgs e) => AddItem("DVD");      // DVD Add
        private void button12_Click(object sender, EventArgs e) => AddItem("Book");    // Book Add
        private void button8_Click(object sender, EventArgs e) => AddItem("Magazine"); // Magazine Add

        // --- UPDATE BUTTONS ---
        private void btnDVDUpdate_Click(object sender, EventArgs e) => UpdateSelectedItem(dataGridView2); // DVD Update
        private void button11_Click(object sender, EventArgs e) => UpdateSelectedItem(dataGridView4);     // Book Update
        private void button7_Click(object sender, EventArgs e) => UpdateSelectedItem(dataGridView3);      // Magazine Update

        // --- DELETE BUTTONS ---
        private void btnDVDDel_Click(object sender, EventArgs e) => DeleteSelectedItem(dataGridView2);    // DVD Delete
        private void button10_Click(object sender, EventArgs e) => DeleteSelectedItem(dataGridView4);     // Book Delete
        private void button6_Click(object sender, EventArgs e) => DeleteSelectedItem(dataGridView3);      // Magazine Delete

        // --- SEARCH BUTTONS ---
        private void btnDVDSearch_Click(object sender, EventArgs e) => SearchAndHighlight(dataGridView2, "DVD");
        private void button9_Click(object sender, EventArgs e) => SearchAndHighlight(dataGridView4, "Book");
        private void button5_Click(object sender, EventArgs e) => SearchAndHighlight(dataGridView3, "Magazine");

        // --- SEARCH FUNCTIONALITY ---
        private void SearchAndHighlight(DataGridView grid, string type)
        {
            string id = Microsoft.VisualBasic.Interaction.InputBox($"Enter {type} ID to search:", $"Search {type}");
            if (string.IsNullOrWhiteSpace(id)) return;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells["ID"].Value?.ToString()?.Equals(id, StringComparison.OrdinalIgnoreCase) == true)
                {
                    row.Selected = true;
                    grid.FirstDisplayedScrollingRowIndex = row.Index;
                    MessageBox.Show($"{type} found: {id}");
                    return;
                }
            }
            MessageBox.Show($"{type} with ID '{id}' not found.");
        }

        private bool ValidateInput(string? value, string fieldName, bool isInt = false)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show($"{fieldName} cannot be empty.", $"Please enter a valid {fieldName}");
                return false;
            }
            if (isInt && !int.TryParse(value, out _))
            {
                MessageBox.Show($"{fieldName} must be a valid number.", $"Please enter a valid {fieldName}");
                return false;
            }
            return true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}