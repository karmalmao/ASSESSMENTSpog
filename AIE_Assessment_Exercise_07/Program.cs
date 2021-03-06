﻿/*
 * Appendix 4 - Exercise 1: Greetings
 */

using System;

namespace AIE_Assessment_Exercise_07
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:
            // Create instances of
            // - A Person and Doctor classes.

            Person p1 = new Person("Bob" , "email here p1" , "num here p1" , 1000);
            Doctor p2 = new Doctor("Fred" , "email here p2" , "num here p2" , 2000);
            Person p3 = new Doctor("Ted" , "email here p3" , "num here p3" , 3000);

            // Invoke the "SayGreeting" method on the above instances
            p1.SayGreeting(); // hello I'm Bob
            p2.SayGreeting(); // hello I'm Dr. Fred
            p3.SayGreeting(); // hello I'm Dr. Ted
        }
    }
    public class Person
    {
        public float salary = 10;
        public string name = "";
        public string email = "";
        public string phone = "";
        public Person(string name , string email , string phone , float salary)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.salary = salary;
        }

        public virtual void SayGreeting()
        {
            Console.WriteLine($"Hello, I'm {name}");
            //Console.WriteLine(email);
            //Console.WriteLine(phone);
            //Console.WriteLine(salary);
        }
    }
    class Doctor : Person
    {
        public Doctor(string name , string email , string phone , float salary) : base(name , email , phone , salary)
        {
            base.name = name;
            base.email = email;
            base.phone = phone;
            base.salary = salary;
        }
        public override void SayGreeting()
        {
            Console.WriteLine($"Hello, I'm Dr. {name}");
            //Console.WriteLine(email);
            //Console.WriteLine(phone);
            //Console.WriteLine(salary);

        }
    }
}
