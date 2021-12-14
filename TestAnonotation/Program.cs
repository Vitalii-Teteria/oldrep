using System;
using WEBCarSell.DataAccess.Entities;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace TestAnonotation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input client`s name:");
            string name = Console.ReadLine();

            Console.Write("Input client`s city:");
            string city = Console.ReadLine();

            Console.Write("Input phone number:");
            string phone = Console.ReadLine();

            Console.Write("Input Email:");
            string email = Console.ReadLine();

            Client client = new Client()
            {
                Name = name,
                City = city,
                Phone = phone,
                Email = email
            };

            var result = new List<ValidationResult>();
            var context = new ValidationContext(client);

            if (!Validator.TryValidateObject(client, context, result, true)) 
            {
                foreach (var error in result) 
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
        }
    }
}
