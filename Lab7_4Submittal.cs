using System;

namespace Lab7_4Submittal
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
using System.Collections.Generic;
using System.Text;

namespace _7_4DatingGame
{
    class DatingProfile
    {
        public string firstName;
        private string lastName;
        public int age;
        public string gender;
        public string bio;
        private List<Messages> myMessages;

        public DatingProfile(string firstName, string lastName, int age, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            myMessages = new List<Messages>();
        }

        public void WriteBio(string text)
        {
            bio = text;
        }

        public void AddToInbox(Messages message)
        {
            myMessages.Add(message);

        }

        public void SendMessage(string messageTitle, string messageData, DatingProfile sentTo)
        {
            Messages message = new Messages(this, messageTitle, messageData);
            sentTo.AddToInbox(message);
        }

        public void ReadMessage()
        {
            foreach (Messages message in myMessages)
            {
                if (message.isRead == false)
                {
                    Console.WriteLine(message.messageTitle);
                    Console.WriteLine(message.messageData);
                    message.isRead = true;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace _7_4DatingGame
{
    class Messages
    {
        public DatingProfile sender;
        public string messageTitle;
        public string messageData;
        public bool isRead;

        public Messages(DatingProfile sender, string messageTitle, string messageData)
        {
            this.sender = sender;
            this.messageTitle = messageTitle;
            this.messageData = messageData;
            isRead = false;
        }

    }
}

using System;

namespace _7_4DatingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DatingProfile tim = new DatingProfile("Tim", "Gansen", 53, "Male");
            tim.WriteBio("Devoted father");

            DatingProfile suze = new DatingProfile("Suze", "VRixel", 57, "Female");
            suze.WriteBio("Starting a new chapter in life");

            tim.SendMessage("Hello Suze", "How are you today?", suze);
            suze.ReadMessage();
        }
    }
}

