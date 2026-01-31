namespace lab2.Task3RecursiveFibonacciSequence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public long FibonacciRecursive(long n)
        {
            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        private void btnCalcFibunacci_Click(object sender, EventArgs e)
        {
            try
            {
                long number = long.Parse(textBoxInput.Text);
                long result = FibonacciRecursive(number);
                lblResult.Text = $"Fibonacci value of {number} is {result}";
                lblResult.Left = (this.ClientSize.Width - lblResult.Size.Width) / 2;
            }
            catch (FormatException)
            {
                MessageBox.Show("{Please enter a valid Integer");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number is too large to compute its Fibonacci value.");
            }
        }

        private void textBoxInput_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
        }
    }
}
