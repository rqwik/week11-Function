using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld(); //вызывается функция, в теле которой находится 14 строчка
            GreetUser();
            CheckUsers();

        }
        //void - после того, как код выполнится - все данные удаляются из оперативной памяти
        public static void HelloWorld()//privat - функция доступна только в файле програм
        {
            Console.WriteLine("It's a wonderful world!");
        }

        public static void GreetUser()
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Hello, {firstName}!");
        }

        public static void CheckUsers()
        {
            Console.WriteLine("Enter your year of birth:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2022 - yearOfBirth;
            if (userAge < 18)
            {
                Console.WriteLine("You are too young to use the app.");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
        }
    }
}
