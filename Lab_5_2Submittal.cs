using System;
using System.Collections.Generic;

namespace Lab5_2Submittal
{
    class Program
    {

        public enum WeekDays
        {

            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY,
            SUNDAY
        }

        static void Main(string[] args)
        {
            //Create a list tasks
            List<string> taskList = new List<string>();

            //Day Enum...create a task.
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for " + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);

            }


            //print all tasks.
            foreach (string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}