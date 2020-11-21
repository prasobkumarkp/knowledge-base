using System;

namespace CoreCosole
{
    class Program
    {
        static void Main(string[] args)
        {
            new Test().Main();
        }
    }

    public class Test
    {
        public void Main()
        {
            Wrap(First);
            Wrap(Second);
        }

        public void First()
        {
            Console.WriteLine("executing first function");
        }

        public void Second()
        {
            Console.WriteLine("Executing second function");
        }

        public delegate void ToWrap();
        public void Wrap(ToWrap function)
        {
            function();
        }
    }
}

