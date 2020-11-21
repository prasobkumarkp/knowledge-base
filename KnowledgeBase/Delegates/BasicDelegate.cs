using System;
namespace KnowledgeBase.Delegates
{
    public class BasicDelegate : ICode
    {
        public string GetDecription()
        {
            return "Delegate - Generic delegate";
        }

        public void Run()
        {
            //First();
            //Second();

            Wrap(First);
            Wrap(Second);
            AnotherWrap(Third, "same");
        }

        public void First()
        {
            Console.WriteLine("Executing first function1");
        }

        public void Second()
        {
            Console.WriteLine("Executing second function");
        }

        public string Third(string name)
        {
            var text = $"Hey {name}, Executing third function";
            Console.WriteLine(text);
            return text;
        }

        public delegate void ToWrap();
        public void Wrap(ToWrap function)
        {
            Console.WriteLine("Function started");
            function();
            Console.WriteLine("Function ended");
        }

        // delegate with parameter and return types
        public delegate string ToAnotherWarp(string name);
        public void AnotherWrap(ToAnotherWarp function, string name)
        {
            Console.WriteLine("Function started");
            function(name);
            Console.WriteLine("Function ended");
        }
    }
}
