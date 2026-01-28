namespace Task5_BubbleSortusingProceduralProgramming
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
            listBoxResults = new ListBox();
            btnSort = new Button();
            listBoxOriginal = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(378, 25);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(368, 379);
            listBoxResults.TabIndex = 2;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(106, 25);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(126, 23);
            btnSort.TabIndex = 3;
            btnSort.Text = "Bubble Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxOriginal
            // 
            listBoxOriginal.FormattingEnabled = true;
            listBoxOriginal.ItemHeight = 15;
            listBoxOriginal.Location = new Point(106, 115);
            listBoxOriginal.Name = "listBoxOriginal";
            listBoxOriginal.Size = new Size(126, 289);
            listBoxOriginal.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 97);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Unsorted";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(listBoxOriginal);
            Controls.Add(btnSort);
            Controls.Add(listBoxResults);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxResults;
        private Button btnSort;
        private ListBox listBoxOriginal;
        private Label label1;
    }
}
