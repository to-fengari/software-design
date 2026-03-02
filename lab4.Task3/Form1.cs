using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4.Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Book()
        {
            private string _title = string.Empty;
            public string Title
            {
                get => _title;
                set => _title = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException() : value;
            }
            private string _author = string.Empty;
            public string Author
            {
                get => _author;
                set => _author = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException() : value;
            }

            public virtual string GetInfo()
            {
                return $"{Title} by {Author}";
            }
        }

        public class Magazine : Book
        {
            private int _issueNumber;
            public int IssueNumber
            {
                get => _issueNumber;
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Issue number cannot be negative.");
                    }
                    _issueNumber = value;
                }
            }

            public override string GetInfo()
            {
                return $"{Title} - Issue {IssueNumber}";
            }
        }

        public class Ebook : Book
        {
            private int _fileSize;
            public int FileSize
            {
                get => _fileSize;
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("File size cannot be negative.");
                    }
                    _fileSize = value;
                }
            }

            public override string GetInfo() => $"{Title} (Ebook, {FileSize}MB)";
        }

        public class Textbook : Book
        {
            private string _subject = string.Empty; 
            public string Subject
            {
                get => _subject;
                set => _subject = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException() : value;
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

        [TestClass]
        public class ValidationTest
        {
            [TestMethod]
            public void TestInvalidBookCreation()
            {
                Assert.ThrowsExactly<ArgumentException>(() =>
                {
                    new Book { Title = "" };
                });
            }

            [TestMethod]
            public void TestInvalidMagazineCreation()
            {
                Assert.ThrowsExactly<ArgumentException>(() =>
                {
                    new Magazine { IssueNumber = -1 };
                });
            }

            [TestMethod]
            public void TestInvalidEbookCreation()
            {
                Assert.ThrowsExactly<ArgumentException>(() =>
                {
                    new Ebook { FileSize = -5 };
                });
            }

            [TestMethod]
            public void TestInvalidTextbookCreation()
            {
                Assert.ThrowsExactly<ArgumentException>(() =>
                {
                    new Textbook { Subject = "" };
                });
            }
        }
    }
}
