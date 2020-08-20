using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie_1();
        }
        /// <summary>
        /// cw deklaracja zmiennych oraz ich prezentacja na ekranie
        /// </summary>
        public static void Zadanie_1()
        {

            string name = "Kuba";
            string surname = "Fado";
            int age = 41;
            char sex = 'm';
            long pesel =16018909399;
            long employeeID = 2509324094;

            Console.WriteLine("Dane pracownika: ");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Sex: " + sex);
            Console.WriteLine("PESEL: " + pesel);
            Console.WriteLine("Employee number: " + employeeID);
            Console.WriteLine(" ");
            Console.WriteLine("By zakończyć wciśnij ENTER");
            //Console.ReadKey();
        }


    }
}
