using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id=1,Name="Mustafa",Surname="Tunca",Age=24,StateOfOrigin="Turkey"
              
            };
            Console.WriteLine("Sıra:"+" "+customer.Id);
            Console.WriteLine("Ad:" + " "+customer.Name);
            Console.WriteLine("Soyad:" + " "+customer.Surname);
            Console.WriteLine("Yaş:" + " " + customer.Age);
            Console.WriteLine("Memleket:" + " " + customer.StateOfOrigin);
            
            Customer customer1 = new Customer(2, "Tuğrul", "Tunca", 18, "Turkey");

            Console.WriteLine("Sıra:" + " " + customer1.Id);
            Console.WriteLine("Ad:" + " " + customer1.Name);
            Console.WriteLine("Soyad:" + " " + customer1.Surname);
            Console.WriteLine("Yaş:" + " " + customer1.Age);
            Console.WriteLine("Memleket:" + " " + customer1.StateOfOrigin);

            Console.ReadLine();
        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string name,string surname,int age,string stateoforigin)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            StateOfOrigin = stateoforigin;
        }
       public int Id { get; set; }
       public string Name { get; set; }
       public string Surname { get; set; }
       public int Age { get; set; }
       public string StateOfOrigin { get; set; }
    }
}
