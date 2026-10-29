namespace Task5CustomDescendingOrder
{
	// Base class: sorts ascending. Marked virtual so the ordering can be replaced.
	public class NumberSorter
	{
		public int[] Numbers { get; private set; }

		public NumberSorter(int[] numbers)
		{
			Numbers = numbers;
		}

		public virtual int[] Sort()
		{
			int[] sorted = (int[])Numbers.Clone();
			Array.Sort(sorted);
			return sorted;
		}
	}

	// Inheritance + polymorphism: the same Sort() call produces a descending order
	// because the derived class overrides how two numbers are compared.
	public class DescendingSorter : NumberSorter
	{
		public DescendingSorter(int[] numbers) : base(numbers)
		{
		}

		public override int[] Sort()
		{
			int[] sorted = (int[])Numbers.Clone();
			Array.Sort(sorted, new DescendingComparer());
			return sorted;
		}
	}

	// The custom ordering rule, kept in a class of its own.
	public class DescendingComparer : IComparer<int>
	{
		public int Compare(int x, int y)
		{
			return y.CompareTo(x);
		}
	}

	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			int[] numbers = { 3, 1, 5, 2, 4 };

			// Declared as the base type, but the derived object's Sort() runs.
			NumberSorter sorter = new DescendingSorter(numbers);
			int[] sortedNumbers = sorter.Sort();

			listBoxResults.DataSource = sortedNumbers;
		}
	}
}
