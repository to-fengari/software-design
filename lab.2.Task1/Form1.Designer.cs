namespace lab2.Task1
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
            textBoxInput = new TextBox();
            lblResult = new Label();
            btnSolveFactorial = new Button();
            lblDescription = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(336, 181);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 27);
            textBoxInput.TabIndex = 0;
            textBoxInput.Text = "Enter 'n'";
            textBoxInput.MouseClick += textBoxInput_MouseClick;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(297, 269);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 1;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSolveFactorial
            // 
            btnSolveFactorial.Location = new Point(350, 214);
            btnSolveFactorial.Name = "btnSolveFactorial";
            btnSolveFactorial.Size = new Size(94, 29);
            btnSolveFactorial.TabIndex = 2;
            btnSolveFactorial.Text = "Solve";
            btnSolveFactorial.UseVisualStyleBackColor = true;
            btnSolveFactorial.Click += btnSolveFactorial_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(297, 84);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(188, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "n! = n × (n - 1) × (n - 2) ... 1";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(248, 49);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(304, 35);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Factorials Using Recursion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(btnSolveFactorial);
            Controls.Add(lblResult);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }


        #endregion

        private TextBox textBoxInput;
        private Label lblResult;
        private Button btnSolveFactorial;
        private Label lblDescription;
        private Label lblTitle;
    }
}
