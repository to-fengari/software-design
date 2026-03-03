using Microsoft.EntityFrameworkCore;

namespace lab5.Task1_7
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

        public void AddAuthorWithBook(string authorName, string bookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };
                context.Authors.Add(author);
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public void UpdateBookAndAuthor(int bookId, string newBookTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Include(b => b.Author).FirstOrDefault(b => b.BookID == bookId);
                if (book != null)
                {
                    book.Title = newBookTitle;
                    book.Author.Name = newAuthorName;
                    context.SaveChanges();
                }
            }
        }

        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
        }

        public List<string> Search(string authorName)
        {
            using (var context = new BookstoreContext())
            {
                return context.Books
                    .Include(b => b.Author)
                    .Where(b => b.Author.Name.Contains(authorName))
                    .Select(b => $"{b.BookID}: {b.Title} by {b.Author.Name}")
                    .ToList();
            }
        }

        public bool TestConnection()
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    return context.Database.CanConnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<string> GetBooksWithAuthors()
        {
            using (var context = new BookstoreContext())
            {
                var booksWithAuthors = context.Books
                    .Include(b => b.Author)
                    .Select(b => $"{b.Title} by {b.Author.Name}")
                    .ToList();
                return booksWithAuthors;
            }

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string authorName = txtAuthorName.Text;
            string bookTitle = txtBookTitle.Text;
            AddAuthorWithBook(authorName, bookTitle);
            MessageBox.Show("Book added successfully!");
        }

        private void btnUpdateBook_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                string newBookTitle = txtBookTitle.Text;
                string newAuthorName = txtAuthorName.Text;
                UpdateBookAndAuthor(bookId, newBookTitle, newAuthorName);
                MessageBox.Show("Book and author updated successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                MessageBox.Show("Successfully connected to BookstoreDB!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Could not connect. Check your LocalDB instance.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBookID.Text, out int bookId))
            {
                DeleteBook(bookId);
                MessageBox.Show("Book deleted successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid Book ID.");
            }
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            var results = Search(searchName);
            listBoxBooks.DataSource = null;
            listBoxBooks.DataSource = results;
        }

        private void btnShowBooks_Click(object sender, EventArgs e)
        {
            var books = GetBooksWithAuthors();
            listBoxBooks.DataSource = books;
        }
    }
}
