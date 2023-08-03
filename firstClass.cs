using System;
using System.Collections.Generic;

namespace FirstProject
{
	public class Person
    {
    	public string Name;
        public int Age;
        public bool HasPets;
        
        public void Greeting()
        {
        	Console.WriteLine("Hi, My name is " + Name + " and my age is " + Age);
        }
    }
	class Program
    {
    	static void Main(string[] args)
        {
        	Person p1 = new Person();
            
            p1.Name = "Ana Maria";
            p1.Age = 28;
            p1.HasPets = true;
            
            p1.Greeting();
        }
    }
}
