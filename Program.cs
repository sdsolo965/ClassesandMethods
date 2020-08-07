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
            

            //Creating a new instance of Hayden and assigning each variable a value
            Hayden hayden = new Hayden("Hayden Barnes", 27, "Golf and Woodworking");

            Hayden.GetInfo();// Gathers info from the new instance above to print to the console
            Hayden.MyGoals();// is witin a static method to maintain integrity across the program
            Hayden.AppIdea();// is witin a static method to maintain integrity across the program


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
    /*
     * Author of this class is Hayden Barnes (MSSA FBG9)
     */
    class Hayden
    {
        static string Name;
        static int Age;
        static string Hobbies;
        //public string Goals;
        //public string ProjectIdea;

        public Hayden(string name, int age, string hobbies)
        {
            Name = name;
            Age = age;
            Hobbies = hobbies;
        }
        public static void MyGoals()//declared static to keep the goal the same whenever called
        {
            Console.WriteLine("1) To always provide the best for my daughter and wife.\n2)Gain employment" +
                " with a company that has meanigful work.\n3) Be debt free in 2 years (minus a mortgage).");
        }
        public static void AppIdea()//declared static to keep the goal the same whenever called
        {
            Console.WriteLine("An uber like app but for renting tools fyou may need for a certain" +
                " project but do not want to buy to complete a project.");
            // If any of you have some insight on how to create this sort of application or to choose a new one
            // to insure I am not in over my head. Thank you.
        }
        public static void GetInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Hobbies);
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