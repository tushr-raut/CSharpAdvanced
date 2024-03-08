namespace AdvanceCSharp.Console.Lectures.ValueVsReferenceTypes
{
    public class ValueVsReferenceTypeExamples
    {
		private static void _SwapByValue(MyClass myClass)
		{
			myClass = new MyClass(5);
		}

		private static void _SwapByRef(ref MyClass myClass)
		{
			myClass = new MyClass(5);
		}

        public static void Execute()
        {
            MyClass myclass = new MyClass(4);
            _SwapByValue(myclass);
            System.Console.WriteLine(myclass.Value);

            MyClass myclass1 = new MyClass(4);
            _SwapByRef(ref myclass1);
            System.Console.WriteLine(myclass1.Value);

            System.Console.ReadLine();
        }
    }

	public class MyClass
	{
		public int Value { get; set; }

		public MyClass(int value)
		{
			Value = value;
		}
	}
}
