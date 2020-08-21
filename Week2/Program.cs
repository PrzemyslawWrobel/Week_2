using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie_1();
            Zadanie_2();
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

        public static void Zadanie_2()
        {
            Console.WriteLine("Przykłdowa deklaracja znaków kodzie programu: ");
            char a = 'A';
            char b = 'B';
            char c = 'C';
            Console.WriteLine("Zadeklarowane znaki to: " + c +" "+ b +" "+ a);

            //char a, b, c;
            Console.WriteLine(" ");
            Console.WriteLine("Użytkowniku podaj pierwszy znak: ");
            Console.WriteLine("Podaj znak: ");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak: ");
            b = char.Parse(Console.ReadLine());
            Console.WriteLine("Podaj znak: ");
            c = char.Parse(Console.ReadLine());
            Console.WriteLine("Zadeklarowane znaki w odwrotnej kolejności to: " + c.ToString() + " " + b.ToString() + " " + a.ToString());
        }

        public static void Zadanie_3()
        {
            Console.WriteLine("Program oblicza długość przekątnej prostokąta");
            double a, b, d;
            Console.WriteLine("Podaj długość prostokąta: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj szerokość prostokąta: ");
            b = double.Parse(Console.ReadLine());
            d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine("Przekątna prostokąta ma długość: " + d.ToString());

        }

        public static void Zadanie_4()
        {
            int a;
            double b;
            string c;
            a = 10;
            b = 12.5;
            c = "Szkoła Dotneta";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public static void Zadanie_5()
        {

        }

    }
}
