using System;

//namespace Abstract_Sealed
//{
//    public abstract class Language
//    {
//        public Language()
//        {
//            Console.WriteLine("Language Constructor");
//        }
//        public abstract void display();
//        public void display1()
//        {
//            Console.WriteLine("Non Abstract Method");
//        }
//        protected string name;
//        public abstract string Name
//        {
//            get;
//            set;
//        }
//    }

//    public class Language2 : Language
//    {
//        public override void display()
//        {
//            Console.WriteLine("Abstract Method");
//        }
//        public override string Name
//        {
//            get
//            {
//                return name;
//            }
//            set
//            {
//                name = value;
//            }
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Language2 language2 = new Language2();
//            language2.display();
//            language2.display1();
//            Console.ReadLine();
//        }
//    }
//}
//namespace AbstractClass
//{
//    abstract class MotorBike
//    {
//        public abstract void brake();
//    }

//    class SportsBike : MotorBike
//    {

//        // provide implementation of abstract method
//        public override void brake()
//        {
//            Console.WriteLine("Sports Bike Brake");
//        }

//    }

//    class MountainBike : MotorBike
//    {

//        // provide implementation of abstract method
//        public override void brake()
//        {
//            Console.WriteLine("Mountain Bike Brake");
//        }

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // create an object of SportsBike class
//            SportsBike s1 = new SportsBike();
//            s1.brake();

//            // create an object of MountainBike class
//            MountainBike m1 = new MountainBike();
//            m1.brake();

//            Console.ReadLine();
//        }
//    }
//}
namespace SealedClass
{

    class Animal
    {
        public virtual void makeSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    class Dog : Animal
    {

        // sealed method
        sealed public override void makeSound()
        {

            Console.WriteLine("Dog Sound");
        }
    }

    //class Puppy : Dog
    //{

    //    // trying to override sealed method
    //    public override void makeSound()
    //    {
    //        Console.WriteLine("Puppy Sound");
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {

            // create an object of Puppy class
            Dog d1 = new Dog();
            Console.ReadLine();
        }
    }
}