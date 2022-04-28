using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierServise
    {
        private IApplicantServise _applicantServise;

        public PttManager(IApplicantServise applicantServise) //Constructor 
        {
            _applicantServise = applicantServise;
        }
        public void GiveMask(Person person)
        {
            
            if (_applicantServise.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
