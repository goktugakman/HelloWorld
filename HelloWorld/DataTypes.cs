using System;

namespace HelloWorld
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world, my name is Göktuğ");

            Console.WriteLine("I'm learning c# right now");

            Console.WriteLine("I hope I will succeed");

            Console.WriteLine(26+4);
            // This is a comment what I wrote here should not appear
            Console.WriteLine("Hello World!");
            string name = "Göktuğ";
            Console.WriteLine(name);

            int myNum = 13;
            myNum = 31; //myNum is now 31
            Console.WriteLine(myNum);

            int Num;
            Num = 25;
            Console.WriteLine(Num);

            double myDoubleNum = 5.99D;
            Console.WriteLine(myDoubleNum);

            char myLetter = 'A';
            Console.WriteLine(myLetter);

            bool myBool = false;
            Console.WriteLine(myBool);

            string myText = "YOOOOOO WHAT'S UPP";
            Console.WriteLine(myText);

            Console.WriteLine("Hello " + myText);

            string firstName = "Göktuğ ";
            string lastName = "Akman";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 897;
            int y = 3;
            Console.WriteLine(x + y); //print the value x + y

            int z = 100;
            Console.WriteLine(x + y + z);

            int a, b, c;
            a=b=c=3;
            Console.WriteLine(a+b+c);

            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }

            if (sistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Ayarlar Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

        }
    }
}  