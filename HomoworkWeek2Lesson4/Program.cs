using System;

namespace HomeWorkWeek2Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseOne();
            ExerciseTwo();
            ExerciseThree(0,0);
            ExerciseFour();
            ExerciseFive();
        }

        public static void ExerciseOne()
        {
            String name = "John";
            String surename = "Beck";
            int age = 21;
            char sex = 'm';
            int pesel = 991233312;
            int employeeNumber = 1123113332;
        }

        public static void ExerciseTwo()
        {
            char variable = 'a';
            char variable1 = 'b';
            char variable2 = 'c';
            Console.WriteLine(variable2.ToString() + variable1.ToString() + variable.ToString() );
        }

        public static void ExerciseThree(double width,double lenght)
        {
            Console.WriteLine(Math.Pow(width, lenght));
        }

        public static void ExerciseFour()
        {
            int a = 10;
            String b = "Szkoła Dotneta";
            double c = 12.5; 
        }

        public static void ExerciseFive()
        {
            String name;
            String surename;
            int phone;
            string email;
            int height;
            double weight;
            
            Console.WriteLine("Please write below Your personal data.");

            Console.WriteLine("Give your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Give your surename: ");
            surename = Console.ReadLine();

            Console.WriteLine("Give your phone number:");
            Int32.TryParse(Console.ReadLine(), out phone);

            Console.WriteLine("Give your e-mail adress:");
            email = Console.ReadLine();

            Console.WriteLine("Give your height:");
            Int32.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Give your weight:");
            double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine($"User Data: \r\n Name: {name} \r\n Surename: {surename} \r\n "
                              + $"Phone Number: {phone} \r\n Email: {email} \r\n Height: {height} \r\n Weight: {weight}"
            );

        }
        
    }
    
}