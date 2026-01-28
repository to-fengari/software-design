namespace Task5_BubbleSortusingProceduralProgramming
{
    public partial class Form1 : Form
    {
        private int[] numbersOriginal = { 2, 6, 13, 10, 15, 3, 7, 1, 12, 5, 4, 9, 8, 11, 14 };
        public Form1()
        {
            InitializeComponent();
            listBoxOriginal.DataSource = numbersOriginal;   
        }

        static int[] bubbleSort(int[] numbersOriginal)
        {
            int[] numbers = (int[])numbersOriginal.Clone();
            int i, j, temp;
            bool swap;
            for (i = 0; i < numbers.Length - 1; i++)
            {
                swap = false;
                for (j = 0; j < numbers.Length - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swap = true;
                    }
                }

                if (swap == false)
                    break;
            }

            return numbers;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            int[] sortedNumbers = bubbleSort(numbersOriginal);
            listBoxResults.DataSource = sortedNumbers;

        }

    }
}
