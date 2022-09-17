using Cout = System.Console;

namespace ClassMethodsNewProject
{
    class Math
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    class User
    {
        //public const string StrConst = "Constant string";

        //public readonly string StrReadOnly;
        public string Name { get; set; }

        public User(string str = "Anonim")
        {
            Name = str;
        }

        public void PrintConsole()
        {
            Cout.WriteLine(Name);
        }

        public void Method(object? obj)
        {
            if(obj != null)
                Console.WriteLine(obj.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Math math = new Math();

            //Console.WriteLine(Math.Sum(10, 20));
            //Console.WriteLine(math.Sum(10, 20, 30));

            //User user = new User();

            User user = new User();

            if(user != null)
                user.PrintConsole();

            user?.PrintConsole();

            int? x = 10;
            user?.Method(x);

            int y = 20 + x.Value;
            int z = x ?? 0;
        }
    }
}