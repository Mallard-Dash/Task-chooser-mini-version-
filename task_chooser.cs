using System;
using System.Collections.Generic;

namespace task_chooser
{
    class Program
    {
        static void Main (string[] args)
        {
            Random random = new Random();
            List<string> task = new List<string> { "Python", "COBOL", "C#", "C", "Docker", "Bash", "Machine-learning", "Unity", "JAVA", "API" };
            //This program let's the user choose a random item from a list. In this case a list of tasks.
            //Example: "Today I will learn 1 hour of 'Docker'. Then i sit down for 1 hour doing only that.
            //Then I have a 10 minute break and repeats this process again.
            //You initiate the random-generator with 'G' or 'g'.
            while (true)
            {


                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("This is a random generator for the next task. ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.ResetColor();
                Console.WriteLine("Press button 'G' to select a random task: ");
                Console.WriteLine("Press button A to add a new task: ");
                Console.WriteLine("Press R to remove a task: ");
                string user_command = Console.ReadLine();

                if (user_command == "G" || user_command == "g")
                {
                    int index = random.Next(task.Count);
                    Console.WriteLine(task[index]);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CONGRATULATIONS! Time for one hour of studying " + task[index]);
                    Console.ResetColor();
                }
                else if (user_command == "A" || user_command == "a")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Write which item to add to list: ");
                    Console.ResetColor();
                    string new_item = Console.ReadLine();
                    task.Add(new_item);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(new_item + "Added to task list!");
                    Console.ResetColor();
                }
                else if (user_command == "R" || user_command == "r")
                {
                    for (int i = 0; i < task.Count; i++)
                    {
                        Console.WriteLine(" " + task[i]);
                    }
                    Console.WriteLine("Choose item to remove from list: ");
                    string remove_item = Console.ReadLine();
                    task.Remove(remove_item);
                    Console.WriteLine("Item removed! ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid input (G, R or A): ");
                    Console.ResetColor();
                }
            }
        }
    }
}
