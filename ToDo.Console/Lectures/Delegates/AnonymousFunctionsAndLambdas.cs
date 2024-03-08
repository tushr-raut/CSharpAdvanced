namespace AdvanceCSharp.Console.Lectures.Delegates
{
    public class AnonymousFunctionsAndLambdas
    {
        //Generic delegate
        public delegate T GenDelegate<T>(T obj);
        
        public delegate void GetDelegate();

        public static void Execute()
        {
            string str1 = "Hi..";

            //delegate
            GetDelegate obj1 = new GetDelegate(Get);

            //Anonymous method
            GetDelegate obj2 = delegate ()
            {
                System.Console.WriteLine(str1);
            };

            //Lambda expression
            GetDelegate obj3 = () =>
            {
                System.Console.WriteLine(str1);
            };

            obj1.Invoke();
            obj2.Invoke();
            obj3.Invoke();

            System.Console.ReadKey();
        }

        public static void Get()
        {
            System.Console.WriteLine();
        }

        public static void GetLowerCase(string str)
        {
            System.Console.WriteLine(str.ToLower());
        }
    }
}
