using System.ComponentModel.DataAnnotations;

namespace lab4.Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book()
        {
            [Required]
            public string Title { get; set; } = string.Empty;
            [Required]
            public string Author { get; set; } = string.Empty;
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
                return $"{Title} (Ebook, {FileSize}MB)";
            }
        }

        [TestClass]
        public class TestClass
        {
            [TestMethod]
            public void TestBookCreation()
            {
                Book book = new Book { Title = "C# Programming", Author = "John Smith" };
                Assert.AreEqual("C# Programming", book.Title);
                Assert.AreEqual("John Smith", book.Author);
            }

            [TestMethod]
            public void TestMagazineCreation()
            {
                Magazine magazine = new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 };
                Assert.AreEqual("Tech Weekly", magazine.Title);
                Assert.AreEqual("Jane Doe", magazine.Author);
                Assert.AreEqual(12, magazine.IssueNumber);
            }

            [TestMethod]
            public void TestEbookCreation()
            {
                Ebook ebook = new Ebook { Title = "Learning C#", Author = "Alice Johnson", FileSize = 5 };
                Assert.AreEqual("Learning C#", ebook.Title);
                Assert.AreEqual("Alice Johnson", ebook.Author);
                Assert.AreEqual(5, ebook.FileSize);
            }
        }

        [TestClass]
        public class PolymorphismTest 
        {
            [TestMethod]
            public void TestPolymorphism_GetInfo_Method() 
            {
                Book[] books = new Book[]
                {
                    new Book { Title = "C# Programming", Author = "John Smith" },
                    new Magazine { Title = "Tech Weekly", Author = "Jane Doe", IssueNumber = 12 },
                    new Ebook { Title = "Learn C#", Author = "Mark Jones", FileSize = 5 }
                };

                Assert.AreEqual("C# Programming by John Smith", books[0].GetInfo());
                Assert.AreEqual("Tech Weekly - Issue 12", books[1].GetInfo());
                Assert.AreEqual("Learn C# (Ebook, 5MB)", books[2].GetInfo());
            }
        }
    }
}
