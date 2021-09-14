using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            /*programm küsib kasutaja sünniaastat;
             *programm arvutab kasutaja vanust;
             *programm kuvab kasutaja vanust konsoolis;
             */

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            // 1 Võimalus
            //Console.WriteLine("Oled " + userAge + " aastat vana.");

            // 2 Võimalus
            //string interpolation
            Console.WriteLine($"Oled {userAge} aastat vana.");
        }
    }
}
