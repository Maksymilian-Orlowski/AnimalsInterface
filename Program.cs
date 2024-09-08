class Program
{

    static void Main(string[] args)
    {
        Console.ReadKey();
    }


    interface AnimalAction
    {
        void Eat();
        void Drink();
        void Walk();
        void Jump();

    }

    class Cat : AnimalAction 
    {
        public void Eat()
        {
            Console.WriteLine("*deliciois!*");
        }

        public void Drink()
        {
            Console.WriteLine("*plum-plum*");
        }

        public void Walk()
        {
        }

        public void Jump()
        {
        }

        public void Meow()
        {
            Console.WriteLine("Meow! Meow!");
        }

    }

    class Dog
    {
        public void Eat()
        {
        }

        public void Drink()
        {

        }

        public void Walk()
        {
        }

        public void Jump()
        {
        }

        public void HauHau()
        {
            Console.WriteLine("Hau! Hau!");
        }
    }
}

