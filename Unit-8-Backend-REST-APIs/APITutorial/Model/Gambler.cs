﻿namespace APITutorial.Model
{
    public class Gambler
    {
        /***********************************************************************
      * Gambler Data Model Starter Code
      * 
      * Describes data being transferred to/from the server
      * 
      * It is a very basic class
      ***********************************************************************/

        // Data members

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public DateTime BirthDate { get; set; }

        // 0-arg constructor may be used by C# when needed
        public Gambler() { }

        // 5-arg constructor
        public Gambler(int id, string name, string address, double salary, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Address = address;
            Salary = salary;
            BirthDate = birthDate;
        }

        // Equals
        public override bool Equals(object? obj)
        {
            return obj is Gambler gambler &&
                   Id == gambler.Id &&
                   Name == gambler.Name &&
                   Address == gambler.Address &&
                   Salary == gambler.Salary &&
                   BirthDate == gambler.BirthDate;
        }


    }
}

