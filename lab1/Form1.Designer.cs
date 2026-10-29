namespace lab1
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
			this.components = new System.ComponentModel.Container();
			this.btnSort = new System.Windows.Forms.Button();
			this.listBoxResults = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			//
			// btnSort
			//
			this.btnSort.Location = new System.Drawing.Point(66, 55);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(125, 31);
			this.btnSort.TabIndex = 0;
			this.btnSort.Text = "Sort";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			//
			// listBoxResults
			//
			this.listBoxResults.FormattingEnabled = true;
			this.listBoxResults.ItemHeight = 15;
			this.listBoxResults.Location = new System.Drawing.Point(254, 57);
			this.listBoxResults.Name = "listBoxResults";
			this.listBoxResults.Size = new System.Drawing.Size(336, 244);
			this.listBoxResults.TabIndex = 1;
			//
			// Form1
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listBoxResults);
			this.Controls.Add(this.btnSort);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.ListBox listBoxResults;
	}
}
