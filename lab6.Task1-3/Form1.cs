using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations;


namespace lab6.Task1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author Author { get; set; }
        }

        public async static Task<List<string>> GetBooksAsync(IProgress<(int Percent, string Message)> progress)
        {
            using var context = new BookstoreContext();

            progress?.Report((10, "Opening database connection..."));

            var booksQuery = context.Books.Include(b => b.Author);

            progress?.Report((40, "Retrieving book list..."));

            var books = await booksQuery
                .Select(b => $"{b.Title} by {b.Author.Name}")
                .ToListAsync();

            progress?.Report((100, $"Loaded {books.Count} books successfully."));

            return books;
        }

        private System.Progress<(int Percent, string Message)> GetProgressReporter()
        {
            progressBar.Value = 0;
            lblProgressReport.Text = "Starting...";

            return new Progress<(int Percent, string Message)>(progress =>
            {
                progressBar.Value = progress.Percent;
                lblProgressReport.Text = progress.Message;
            });
        }

        public async static Task AddBookAsync(string title, string name, IProgress<(int, string)> progress)
        {
            using var context = new BookstoreContext();

            progress?.Report((10, "Connecting to database..."));

            var author = new Author { Name = name };
            var book = new Book { Title = title, Author = author };
            context.Books.Add(book);

            progress?.Report((50, $"Adding '{title}' to queue..."));

            await context.SaveChangesAsync();

            progress?.Report((100, "Book saved successfully!"));
        }

        public async static Task DeleteBookAsync(int id, IProgress<(int, string)> progress)
        {
            using var context = new BookstoreContext();

            progress?.Report((20, "Searching for record..."));
            var book = await context.Books.FindAsync(id);

            if (book != null)
            {
                context.Books.Remove(book);
                progress?.Report((60, "Removing from database..."));
                await context.SaveChangesAsync();
                progress?.Report((100, "Record deleted."));
            }
            else
            {
                progress?.Report((0, "Book not found."));
            }
        }

        public async static Task UpdateBookAsync(int bookID, string newTitle, string newName, IProgress<(int, string)> progress)
        {
            using var context = new BookstoreContext();
            progress?.Report((20, "Searching for book..."));

            var book = await context.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.BookID == bookID);
            if (book != null)
            {
                book.Title = newTitle;
                book.Author?.Name = newName;

                progress?.Report((60, "Applying changes..."));
                await context.SaveChangesAsync();
                progress?.Report((100, "Update complete!"));
            }
            else
            {
                progress?.Report((0, "Error: Book not found."));
            }
        }

        public async static Task<List<string>> SearchBooksByTitleAsync(string title, IProgress<(int, string)> progress)
        {
            using var context = new BookstoreContext();
            progress?.Report((20, "Searching for books..."));
            var books = await context.Books
                .Include(b => b.Author)
                .Where(b => b.Title.Contains(title))
                .Select(b => $"{b.Title} by {b.Author.Name}")
                .ToListAsync();
            progress?.Report((100, $"Found {books.Count} book(s)."));
            return books;
        }

        public async Task ShowBookbyBookID(int bookID, IProgress<(int, string)> progress)
        {
            using var context = new BookstoreContext();
            progress?.Report((30, "Fetching details..."));

            var book = await context.Books.Include(b => b.Author).AsNoTracking().FirstOrDefaultAsync(b => b.BookID == bookID);

            if (book != null)
            {
                txtBookTitle.Text = book.Title;
                txtAuthorName.Text = book.Author?.Name ?? "Unknown";
                progress?.Report((100, "Record loaded."));
            }
            else
            {
                txtBookTitle.Clear();
                txtAuthorName.Clear();
                progress?.Report((0, "No book matches this ID."));
            }
        }

        private async void BtnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;
            var progress = GetProgressReporter();

            await AddBookAsync(authorName, bookTitle, progress);
        }

        private async void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;
            var bookID = int.Parse(txtBookID.Text);
            var progress = GetProgressReporter();

            await UpdateBookAsync(bookID, bookTitle, authorName, progress);
        }

        private async void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            var bookID = int.Parse(txtBookID.Text);
            var progress = GetProgressReporter();

            await DeleteBookAsync(bookID, progress);
        }

        private async void BtnSearchBookbyTitle_Click(object sender, EventArgs e)
        {
            var title = textBoxSearchByTitle.Text;
            var progress = GetProgressReporter();

            await SearchBooksByTitleAsync(title, progress);
        }

        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var progress = GetProgressReporter();

            List<string> bookList = await GetBooksAsync(progress);
            listBoxBooks.DataSource = bookList;
        }

        private async void TextBoxBookID_TextChanged(object sender, EventArgs e)
        {
            var progress = GetProgressReporter();

            if (int.TryParse(txtBookID.Text, out var bookID))
            {
                await ShowBookbyBookID(bookID, progress);
            }
            else
            {
                txtAuthorName.Clear();
                txtBookTitle.Clear();
            }

        }

    }
}
