using System;

namespace Lab5_6Submittal
{
    class Program
    {

        public struct Customer
        {
            public string first_name;
            public string last_name;
            public int age;
            public bool hasMembership;
        }

        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.first_name = "Tim";
            customer1.last_name = "Gansen";
            customer1.age = 15;
            customer1.hasMembership = false;

            customer2.first_name = "Nick";
            customer2.last_name = "Bonk";
            customer2.age = 23;
            customer2.hasMembership = false;

            customer3.first_name = "Don";
            customer3.last_name = "Johnson";
            customer3.age = 25;
            customer3.hasMembership = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };

            for (int i = 0; i < allCustomers.Length; i++)
            {
                if (allCustomers[i].age < 21)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " underage-cannot order");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " legal age-allowed to order");
                }

                if (allCustomers[i].hasMembership == true)
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].first_name + " " + allCustomers[i].last_name + " is a standard member.");
                }




            }



        }
    }
}

