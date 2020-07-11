using System;
using System.Net.Http.Headers;

namespace Lab_5_6
{
    class Program
    {
        public struct Customer
        {
            public string FirstName;
            public string LastName;
            public int Age;
            public bool Status;
        }
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.FirstName = "Jair";
            customer1.LastName = "Trujillo";
            customer1.Age = 17;
            customer1.Status = false;

            customer2.FirstName = "Mike";
            customer2.LastName = "Johnson";
            customer2.Age = 25;
            customer2.Status = false;

            customer3.FirstName = "Jon";
            customer3.LastName = "Solis";
            customer3.Age = 22;
            customer3.Status = true;

            Customer[] allCustomers = { customer1, customer2, customer3 };
            
            for (int i = 0; i < allCustomers.Length; i++) 
            {
                if (allCustomers[i].Age < 21)
                {
                    Console.WriteLine(allCustomers[i].FirstName + " " + allCustomers[i].LastName + " is not allowed to place an order");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].FirstName + " " + allCustomers[i].LastName + " can place an order");
                }

                if (allCustomers[i].Status == true)
                {
                    Console.WriteLine(allCustomers[i].FirstName + " " + allCustomers[i].LastName + " is a premium member.");
                }
                else
                {
                    Console.WriteLine(allCustomers[i].FirstName + " " + allCustomers[i].LastName + " is a standard member.");
                }




            }



        }
    }
}
