namespace lab3.Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Book> bookList1 = new List<Book>
        {
            new Book {Title = "The Great Gatsby", Author = "F. Scott Fitzgerald"},
            new Magazine {Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45},
            new Ebook {Title = "C# Programming", Author = "Jane Smith", FileSize = 5},
            new Book {Title = "To Kill a Mockingbird", Author = "Harper Lee"},
            new Book {Title = "1984", Author = "George Orwell"},
            new Ebook {Title = "Learning Python", Author = "Mark Lutz", FileSize = 10},
            new Magazine {Title = "Science Monthly", Author = "Alice Johnson", IssueNumber = 12},
            new Magazine {Title = "History Today", Author = "Bob Brown", IssueNumber = 8},
        };

        public class Book()
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            public int FileSize { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Ebook) by {Author} - {FileSize} MB";
            }
        }

        public void DisplayBooksDetails(List<Book> bookList)
        {
            listBoxBooksDetailDisplay.Items.Clear();

            foreach (Book Book in bookList)
            {
                listBoxBooksDetailDisplay.Items.Add(Book.GetInfo());
            }
        }

        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            DisplayBooksDetails(bookList1);
        }
    }
}
