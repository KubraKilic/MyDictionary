using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> customers = new MyDictionary<int, string>();
            customers.Add(34,"Kübra");
            customers.Add(45,"Büşra");
            customers.Add(55,"Leyla");
            customers.Add(87,"Ozan");

            customers.ToList();
        }
    }
}
