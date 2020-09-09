using System;

namespace Lab8_5Submittal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

using System;

namespace _8_5RealityTV
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseHunter hhContestant = new HouseHunter("Full Stack Web Developer", 100000, 6, 3, 2, "Omar", "Smith", "2/4/1975",
                "111 Bravo Way", "Los Angeles", "California", 90001, "888-233-1234", "omar.smith@hotmail.com");

            ParadiseIsland piContestant = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles",
                "California", 90001, "988-444-1234", "patti.johnson@gmail.com");

            AboveDeck adContestant = new AboveDeck(20, "American", "Captian", "Lee", "7/12/1964", "311 Bravo Rd", "Los Angeles",
            "California", 90001, "711-333-1234", "captian@gmail.com");

            hhContestant.Submit();
            hhContestant.Accept();

            piContestant.Submit();
            piContestant.Accept();

            adContestant.Submit();
            adContestant.Accept();


        }
    }
}

using System.Collections.Generic;
using System.Text;

namespace _8_5RealityTV
{
    class ParadiseIsland : Application
    {
        public string gender;
        public string nameOfBoyOrGirlFriend;
        public int yearsDating;

        public ParadiseIsland(string gender, string nameOfBoyOrGirlFriend, int yearsDating,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.gender = gender;
            this.nameOfBoyOrGirlFriend = nameOfBoyOrGirlFriend;
            this.yearsDating = yearsDating;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Paradise Island");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5RealityTV
{
    class HouseHunter : Application
    {
        public string jobTitle;
        public int currentAnnualIncome;
        public int whenBuyingMonths;
        public int bedrooms;
        public int bathrooms;

        public HouseHunter(string jobTitle, int currentIncome, int whenBuying, int bedrooms, int bathrooms,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.jobTitle = jobTitle;
            this.currentAnnualIncome = currentIncome;
            this.whenBuyingMonths = whenBuying;
            this.bedrooms = bedrooms;
            this.bathrooms = bathrooms;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Dream House Hunters");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5RealityTV
{
    class Application
    {
        public string firstName;
        public string lastName;
        public string dateOfBirth;
        public string address;
        public string city;
        public string state;
        public int zip;
        public string phoneNumber;
        public string email;
        public bool isSubmitted;
        public bool isAccepted;

        public Application(string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            isSubmitted = false;
            isAccepted = false;

        }


        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been submitted");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application Accepted");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _8_5RealityTV
{
    class AboveDeck : Application
    {
        public int yearsExperience;
        public string nationality;

        public AboveDeck(int yearsExperience, string nationality,
            string firstName, string lastName, string dateOfBirth, string address, string city, string state, int zip,
            string phoneNumber, string email) : base(firstName, lastName, dateOfBirth, address, city, state, zip, phoneNumber, email)
        {

            this.yearsExperience = yearsExperience;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to Above Deck");
        }
    }
}
