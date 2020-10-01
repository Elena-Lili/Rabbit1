using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person
    {
        //variabilele care sunt definite la nivelul clasei se numesc FIELDS, si definesc starea
        private string firstName;
        private string lastName;
        //public DateTime birthDate; - nu putem data de nastere sa se poata modifica



        private readonly DateTime birthDate;
        //public readonly string gender;
        public readonly Gender gender;
        public const decimal temperature = 25.23M;
        public string FirstName
        {

            get { return firstName; } //only the get -> read-only
            set { firstName = value; } //only the set -> write only
                                       //both -> read-write
        }
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }

        }
        public Person(string first, string last)
        {
            firstName = first;
            lastName = last;
            birthDate = DateTime.Now;
            //gender = "male";
            // temperature = 24.24M;
            //if (weatherToday > temperature)
            //{
            // .....
            // }
        }


        //public Person(string first, string last, string gender)
        //{
        //    firstName = first;
        //    lastName = last;
        //    birthDate = DateTime.Now;
        //    this.gender = gender; //this in acest context de pe clasa asta ce gasesti definit la gender o sa ia valoarea gender

        //}       
        public Person(string first, string last, Gender gender)
        {
            firstName = first;
            lastName = last;
            birthDate = new DateTime(1985, 04, 11);
            this.gender = gender; //this in acest context de pe clasa asta ce gasesti definit la gender o sa ia valoarea gender

        }

        public int Age
        {
            get
            {
                return (int)(DateTime.Now - birthDate).TotalDays / 365;
                //return DateTime.Now.Year - birthDate.Year;


            }
        }
            //varsta
            //gen
            //inaltime
            //nationalitate
            //data de nastere

            //actions
            //alerge
            //manance
            //sa vorbeasca
            //doarma

        //    public enum Gender  //in class Person
        //{
        //    Male,
        //    Female

        //}

    }
    public enum Gender //in afara class Person
    {
        Male,
        Female

    }
    //}
}
