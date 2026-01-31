namespace lab2.Task3RecursivePowerCalculation
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
            lblTitle = new Label();
            textBoxBaseXInput = new TextBox();
            textBoxExponentNInput = new TextBox();
            btnCalc = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F);
            lblTitle.Location = new Point(239, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(323, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Recursive Power Calculation";
            // 
            // textBoxBaseXInput
            // 
            textBoxBaseXInput.Location = new Point(338, 133);
            textBoxBaseXInput.Name = "textBoxBaseXInput";
            textBoxBaseXInput.Size = new Size(125, 27);
            textBoxBaseXInput.TabIndex = 1;
            textBoxBaseXInput.Text = "Enter Base x";
            textBoxBaseXInput.MouseClick += textBoxBaseXInput_MouseClick;
            // 
            // textBoxExponentNInput
            // 
            textBoxExponentNInput.Location = new Point(338, 187);
            textBoxExponentNInput.Name = "textBoxExponentNInput";
            textBoxExponentNInput.Size = new Size(125, 27);
            textBoxExponentNInput.TabIndex = 2;
            textBoxExponentNInput.Text = "Enter Exponent n";
            textBoxExponentNInput.MouseClick += textBoxExponentNInput_MouseClick;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(353, 255);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 29);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(400, 310);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalc);
            Controls.Add(textBoxExponentNInput);
            Controls.Add(textBoxBaseXInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox textBoxBaseXInput;
        private TextBox textBoxExponentNInput;
        private Button btnCalc;
        private Label lblResult;
    }
}
