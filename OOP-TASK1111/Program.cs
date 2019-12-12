using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_TASK1111
{
    class Program
    {

        static void Main(string[] args)
        {
            //task 4 creating new object of class person
            // Person p1 = new Person();
            //p1.SetData("Baturay", "Yasar");
            //p1.FirstName = "Baturay";
            //p1.FamilyName = "Yasar";
            
            //Console.WriteLine(p1.IntroduceYourself());


            int number;/* Int32.Parse(info);*/
            while (true)
            {
                Console.WriteLine("How many users do you want to input?");
                if (int.TryParse(Console.ReadLine(), out number)) break;
                Console.WriteLine("Wrong input!!");
            }
            Person[] p1 = new Person[number];

            //string id = Console.ReadLine();

            //string info = Console.ReadLine();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("1 - Put your Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("2 - Put your Family Name: ");
                string familyName = Console.ReadLine();
                Console.WriteLine("3 - Put your Street: ");
                string street = Console.ReadLine();
                Console.WriteLine("4 - Put your House Number: ");
                string houseNumber = Console.ReadLine();
                Console.WriteLine("5 - Put your Apartment number: ");
                string apartmentNumber = Console.ReadLine();
                Console.WriteLine("6 - Put your Post Code: ");
                string postCode = Console.ReadLine();
                Console.WriteLine("7 - Put your City: ");
                string city = Console.ReadLine();
                Console.WriteLine("8 and LAST STEP - Put your Country: ");
                string country = Console.ReadLine();


                p1[i] = new Person();

                p1[i].SetData(name, familyName, street, houseNumber, apartmentNumber, postCode, city, country);

                //Console.WriteLine(ppl[i].IntroduceYourself());
                Console.Clear();

            }
            for (int i = 0; i < number; i++)
            {

                //showing results in next for loop

                Console.WriteLine((i + 1) + ". " + p1[i].FirstName + ' ' + p1[i].FamilyName);

            }

            while (true)
                {
                    Console.WriteLine("Which contact you wanna select?");
                    if (int.TryParse(Console.ReadLine(), out number)) break;
                    Console.WriteLine("Wrong input!!");
                }

                try
                {
                    Console.WriteLine((number - 1) + ". " + p1[number - 1].IntroduceYourself());
                }

                catch (Exception)
                {
                    Console.WriteLine("Wrong Selection!!");
                }

            
          

    {

            }



                Console.ReadKey();

        }
    }
}
