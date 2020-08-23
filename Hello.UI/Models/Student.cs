using System;

namespace Hello.UI.Models
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string city;
        public DateTime birthDate;
        public Gender gender;
        public byte level;

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }

    public enum Gender
    {
        Male,
        Female
    }
}


/*
 KISS: Keep It Simple & Stupid
 YAGNI: You Aren't Gonna Need It
 DRY: Don't repeat yourself

 SOLID: xxx
 */