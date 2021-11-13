using System;

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
            //Zad3
            Console.WriteLine("//Zad 3");
            int result = 5 + 9;
            Console.WriteLine(result);
            //zad 4
            Console.WriteLine("//Zad 4");
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

            Console.WriteLine("//Zad 5");
            string a, b, c;
            a = "Ala";
            b = "Ma";
            c = "Kota";
            string result_zad5 = a+b+c;
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
            //Console.WriteLine("\r\n\r\n*****Kolekcje******\r\n//ZAD 5:dodatkowe");
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
