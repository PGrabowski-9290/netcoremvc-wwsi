using System;
using System.Collections.Generic;

namespace Powtorka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zad 2
            Console.WriteLine("//Zad 2");
            Console.WriteLine("Podaj swoje imię: ");
            var name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("//Zad 3");
            int result = 5 + 9;
            Console.WriteLine(result);

            Console.WriteLine("\r\n\r\n\r\n==OPERATORY==\r\n//Zad 1");
            int number = 2;
            float money = 2.1232137F;
            string text = "troche tekstu";
            bool isLogged = true;
            char myChar = 'a';
            decimal price = (decimal)7.9999999999999;

            Console.WriteLine("Zmienna number: " + number);
            Console.WriteLine("Zmienna money: " + money);
            Console.WriteLine("Zmienna text: " + text);
            Console.WriteLine("Zmienna isLogged: " + isLogged);
            Console.WriteLine("Zmienna myChar: " + myChar);
            Console.WriteLine("Zmienna price: " + price);

            Console.WriteLine("//Zad 2");
            string myAge = "Age: ";
            int wifeAge = 18;
            string result2 = myAge + wifeAge;
            Console.WriteLine(result2);

            Console.WriteLine("\r\n//Zad 3");
            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;
            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("Zmienna AND: {0}\r\nZmienna OR: {1}\r\nZmienna NEGATIVE: {2}",and,or,negative);


            //Zad4
            Console.WriteLine("//Zad 4");
            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine("Zmienne:\r\nadd: {0} | sub: {1} | div: {2} | mul: {3} | mod: {4}", add, sub, div, mul, mod);


            Console.WriteLine("//Zad 5");
            string a_STRING, b_STRING, c_STRING;
            a_STRING = "Ala";
            b_STRING = "Ma";
            c_STRING = "Kota";
            string result_zad5 = a_STRING+b_STRING+c_STRING;
            Console.WriteLine(result_zad5);
            Console.WriteLine("\r\n\r\n\r\n==INSTRUKCJE STERUJACE I PETLE==\r\n//Zad 1");
            int n1, n2;
            n1 = 10;
            n2 = 20;
            if(n1 == n2)
            {
                Console.WriteLine("n1 jest równe n2");
            }
            else if(n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else
            {
                Console.WriteLine("n1 jest mniejsze od n2");
            }
            Console.WriteLine("\r\n\r\n//ZAD 2");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }
            Console.WriteLine("\r\n\r\n//ZAD 3");
            int n = 10;
            for(int i = 0; i <= n;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i + " :Parzysta");
                }
                else
                {
                    Console.WriteLine(i + " :Nieparzysta");
                }
            }
            Console.WriteLine("\r\n\r\n//ZAD 4:dodatkowe");
            int n_dod = 5;
            for(int i = 0;i<n_dod;i++)
            {
                string res ="";
                for(int j=0;j<n_dod;j++)
                {
                    if (i >= j)
                        res += "*";
                }
                Console.WriteLine(res);

            }
            Console.WriteLine("\r\n\r\n//ZAD 5:dodatkowe");
            int exam;
            int point = 57;
            exam = point;
            Console.WriteLine(PetleiInstr_Zad5(point));

            Console.WriteLine("\r\n\r\n***** Kolekcje ******\r\n//ZAD 1");
            string[] colors = new String[4];
            colors[0] = "czerwony";
            colors[1] = "niebieski";
            colors[2] = "fioletowy";
            colors[3] = "pomaranczowy";

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[3]);


            Console.WriteLine("\r\n\r\n//ZAD 2");

            int[] liczby = new int[10];            
            for(int i = 0; i < liczby.Length; i++)
            {
                liczby[i] = new Random().Next(1, 100);
            }

            Console.WriteLine("Petal FOR:");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine("Liczba: {0}", liczby[i]);
            }

            Console.WriteLine("Petal FOREACH:");
            foreach (int i in liczby)
            {
                Console.WriteLine("Liczba: {0}", i);
            }

            Console.WriteLine("Petal WHILE:");
            int i1 = 0;
            while(i1 < liczby.Length)
            {
                Console.WriteLine("Liczba: {0}", liczby[i1]);
                i1++;
            }

            Console.WriteLine("\r\n\r\n//ZAD 3");
            List<String> fruits = new List<String>();
            fruits.Add("Pomidor");
            fruits.Add("Jabłko");
            fruits.Add("Marchewka");
            fruits.Add("Kiwi");

            Console.WriteLine("Lista owocow:");
            foreach(string fruit in fruits)
            {
                Console.WriteLine("{0}, ", fruit);
            }

            Console.WriteLine("Lista owocow po usunieciu pierwszego i ostatniego elementu: \r\n");
            fruits.Remove("Pomidor");
            fruits.RemoveAt(fruits.Count - 1);
            foreach (string fruit in fruits)
            {
                Console.Write("{0}, ", fruit);
            }
            Console.WriteLine("\r\n\r\n koniec warsztat w nowym projekcie");

        }
        public static string PetleiInstr_Zad5(int exam)
        {
            if (exam > 100 || exam < 0)
            {
                return "wartość poza zakresem";
            }
            else if (exam < 39)
            {
                return "Ocena Niedostateczna";
            }
            else if (exam < 54)
            {
                return "Ocena Dopuszczająca";
            }
            else if (exam < 69)
            {
                return "Ocena Dostateczna";
            }
            else if (exam < 84)
            {
                return "Ocena Dobra";
            }
            else if (exam < 98)
            {
                return "Ocena Bardzo Dobra";
            }
            else if (exam <= 100)
            {
                return "Ocena Celujaca";
            }
            else
                return "";
        }
    }
}
