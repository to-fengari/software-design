namespace lab3.Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Book> booklist1 = new List<Book>
        {
            new Book {Title = "The Great Gatsby", Author = "F. Scott Fitzgerald"},
            new Magazine {Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45},
            new TextBook {Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", Subject = "Computer Science"},
            new EBook {Title = "C# Programming", Author = "Jane Smith", FileSize = 5},
            new TextBook {Title = "Calculus", Author = "James Stewart", Subject = "Mathematics"},
            new AudioBook {Title = "The Republic", Author = "Plato", Duration = 480, Narrator = "Simon Vance"},
            new Book {Title = "To Kill a Mockingbird", Author = "Harper Lee"},
            new AudioBook {Title = "The Hobbit", Author = "J.R.R. Tolkien", Duration = 720, Narrator = "Andy Serkis"},
            new Book {Title = "1984", Author = "George Orwell"},
            new EBook {Title = "Learning Python", Author = "Mark Lutz", FileSize = 10},
            new Magazine {Title = "Science Monthly", Author = "Alice Johnson", IssueNumber = 12},
            new TextBook {Title = "Physics for Scientists and Engineers", Author = "Raymond A. Serway", Subject = "Physics"},
            new Magazine {Title = "History Today", Author = "Bob Brown", IssueNumber = 8},
        };

        public class Book()
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public virtual string GetInfo()
            {
                return $"{Title} (Book) by {Author}";
            }
        }

        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Magazine) - Issue {IssueNumber}";
            }
        }

        public class EBook : Book
        {
            public int FileSize { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (EBook) by {Author} - {FileSize} MB";
            }
        }

        public class TextBook : Book
        {
            public string Subject { get; set; }

            public override string GetInfo()
            {
                return $"{Title} (TextBook) by {Author} - Subject: {Subject}";
            }
        }

        public class AudioBook : Book
        {
            public int Duration { get; set; }
            public string Narrator { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (AudioBook) by {Author} - Duration: {Duration} minutes Narrated by {Narrator}";
            }
        }

        public void DisplayBooksDetails(List<Book> bookList)
        {
            listBoxBooksDisplayDetails.Items.Clear();
            foreach (Book Book in bookList)
            {
                listBoxBooksDisplayDetails.Items.Add(Book.GetInfo());
            }
        }

        private void buttonShowBooks_Click(object sender, EventArgs e)
        {
            DisplayBooksDetails(booklist1);
        }
    }
}
