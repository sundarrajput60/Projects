using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Person
    {
        private Home _home;
        private School _school;
        

        public School school
        {
            set
            {
                _school = value;
            }
        }
        public Person(Home home)
        {
            _home = home;
            
            //_hospital = new Hospital();

        }
        public void TakeRefuge()
        {
            _home.ProvideShelter(this);
        }

        public void Study()
        {
            if(_school != null)
            _school.Teach(this);
        }
        public void GetTreatment(Hospital hospital)
        {
            hospital.Cure(this);
        }
    }
}