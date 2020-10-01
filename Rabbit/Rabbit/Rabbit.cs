using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbit
{
    class Rabbit
    {
        private DateTime birthDate;
        private Gender gender;
        private Fur fur;
        private Eyes eyes;
        private Owner owner;
        

        public Rabbit (Eyes eyes, Fur fur, Gender gender, DateTime birthDate, Owner owner)
        {
            this.eyes = eyes;
            this.fur = fur;
            this.gender=gender;
            this.birthDate = birthDate;
            this.owner = owner;

        }
        
   

        public Fur Fur
        {
            get { return fur; }
        }

        public Gender Gender
        {
            get { return gender; }

        }
       
        public Eyes Eyes
        {

            get { return eyes; }
        }

        public int Age
        {
            get
            {
                return (int)(DateTime.Now - birthDate).TotalDays / 365;

            }
        }
        public Owner Owner
        {
            get { return owner; }
        }
    }
    public enum Eyes
    {
        Blue,
        Red,
        Black

    }
    public enum Fur
    {
        White,
        Brown,
        Black,
        Grey
    }
    public enum Gender
    {
        Male,
        Female
    }
}
