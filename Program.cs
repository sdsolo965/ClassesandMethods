using System;

namespace ClassesandMethods
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            /* Here we're utilizing the static void version of the AddTwoNumbers method.  
             * This doesn't require us to instantiate a class this single instance is always available to use.
            */
            AddTwoNumbersVoid(1,2);
            AddTwoNumbersVoid(3, 4);


            /* Here we're using the non static version were we return a int value from the 
             * method and assing it to a new int variable called resultOne, etc..
             */
           // Program instance1 = new Program();

            int resultOne = instance1.AddTwoNumbers(1, 2);
            int resultTwo = instance1.AddTwoNumbers(3, 4);

            /* Here is a second instance, which occupies a different location in memory of the first instance.
             * However, it leverages the same constructor and same Program class code to make the new instance.
             */
            Program instance2 = new Program();
            instance2.AddTwoNumbers(3,4);
            




            /* This is where we're making what we did above more obvious by using a better naming convention.
             * We're making two dog objects in memory, one who has the Name property of "Stanley" and one with
             * the Name property of "George."
             */
            /*To make the use here more dramatic, you can see it's available prior to creating the instances 
             * of Stanley and George
             */
             
            Dog.Bark();

            Dog Stanley = new Dog("Stanley", 1);

            Dog George = new Dog("Geroge", 10);


            Stanley.GetName();

            George.GetName();

            Console.WriteLine();
        }

        public static void AddTwoNumbersVoid(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }

        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }


    }

    class Dog
    {
        //Properties
        public string Name;
        public int Age;

        /*Constructor, this takes two parameters so that when we create new instances of the Dog object we 
         * can immediately pass it two variable that get assigned to the Name and Age properties.
         */
        public Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /*Since this method is static it's always available to us and doesn't 
         * require us to create an instance of the Dog object.
         */
        public static void Bark()
        {
            Console.WriteLine("Woof");
        }

        /*Gets the name of the specific dog object that it's called on.  eg. Stanley.GetNme() returns "Stanley"
         * and George.GetName() will return "George"
         */
        public void GetName()
        {
            Console.WriteLine(Name);
        }
    }
}

//Method Definition
// Access modifier || Static or nah? || Return type || Name || (Argument type then argument name, repeat for other variables.)
//  {
//      code...
//  }



//Jimmy

//Jacob Duenke
//Tim Tieng
//Damberaine Senior