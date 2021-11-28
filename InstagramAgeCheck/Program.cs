using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //progamm kontrollib, kas kasutaja on vanem kui 13 või 13 aastat vana;
            //kui kasutaja on 13 aastat vana või vanem, siis ta võib instagrami kasutada;
            //kui kasutaja on noorem kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if(userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagrami konto luua.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagrami kontot luua.");
            }
            else
            {
                Console.WriteLine("Oledki 13! Nüüd saad endale Instagrami konto luua.");
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
