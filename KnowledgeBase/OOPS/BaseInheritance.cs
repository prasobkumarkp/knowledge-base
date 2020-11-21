using System;
namespace KnowledgeBase.OOPS
{
    public class BaseInheritance : ICode
    {
        public string GetDecription()
        {
            return "Inhetitance basics";
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }

    public class Animal
    {
        // Encapsulation
        private string _name;
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                    return "Name not set";
                return _name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }

    }

    public interface IWakingAnimal
    {
        public void Walk();
    }

    public interface ISpeakingAnimal
    {
        public void Speak();
    }


    public class Cat : Animal, IWakingAnimal, ISpeakingAnimal
    {
        public virtual void Speak()
        {
            Console.WriteLine($"{this.Name} is speaking...");
        }

        public void Walk()
        {
            Console.WriteLine($"{this.Name} is walking...");
        }
    }
}
