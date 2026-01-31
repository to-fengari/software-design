namespace lab2.Task3RecursivePowerCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long RecursivePowerCalculation(long x, long n)
        {
            if (n == 0)
                return 1;
            return x * RecursivePowerCalculation(x, n - 1);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                long x = long.Parse(textBoxBaseXInput.Text);
                long n = long.Parse(textBoxExponentNInput.Text);
                long result = RecursivePowerCalculation(x, n);
                lblResult.Text = $"{x} raised to the power of {n} is {result}";
                lblResult.Left = (this.ClientSize.Width - lblResult.Size.Width) / 2;
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid Integers for base and exponent.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The result is too large to compute.");
            }
        }

        private void textBoxBaseXInput_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxBaseXInput.Clear();
        }

        private void textBoxExponentNInput_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxExponentNInput.Clear();
        }
    }
}
