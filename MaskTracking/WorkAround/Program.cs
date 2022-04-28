using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace WorkAround
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            Person person1 = new Person();
            person1.FirstName = "Ahmet";
            person1.LastName = "Deneme";
            person1.DateofBirthYear = 22-02-2000;
            person1.NationalIdentity = 11112222331;

            
           
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

        }
        //Resharper
        

    }
    
}
