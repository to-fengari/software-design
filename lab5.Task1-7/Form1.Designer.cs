namespace lab5.Task1_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAuthorName = new TextBox();
            txtBookTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            btnShowBooks = new Button();
            label3 = new Label();
            txtBookID = new TextBox();
            btnUpdateBook = new Button();
            btnTest = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(79, 23);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(280, 27);
            txtAuthorName.TabIndex = 0;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(79, 71);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(280, 27);
            txtBookTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 3;
            label2.Text = "Book:";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(153, 121);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(394, 26);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(394, 344);
            listBoxBooks.TabIndex = 5;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(541, 388);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(94, 29);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 7;
            label3.Text = "BookID:";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(79, 166);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(280, 27);
            txtBookID.TabIndex = 8;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(106, 213);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 29);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click_1;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(675, 388);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(94, 29);
            btnTest.TabIndex = 10;
            btnTest.Text = "Test Connection";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(234, 213);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDeleteBook_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(94, 313);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(265, 27);
            txtSearch.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 316);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 12;
            label4.Text = "AuthorID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 278);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 14;
            label5.Text = "Search By Author";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(153, 367);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearchBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(label5);
            Controls.Add(txtSearch);
            Controls.Add(label4);
            Controls.Add(btnDelete);
            Controls.Add(btnTest);
            Controls.Add(btnUpdateBook);
            Controls.Add(txtBookID);
            Controls.Add(label3);
            Controls.Add(btnShowBooks);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox txtAuthorName;
        private TextBox txtBookTitle;
        private Label label1;
        private Label label2;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Button btnShowBooks;
        private Label label3;
        private TextBox txtBookID;
        private Button btnUpdateBook;
        private Button btnTest;
        private Button btnDelete;
        private TextBox txtSearch;
        private Label label4;
        private Label label5;
        private Button btnSearch;
    }
}
