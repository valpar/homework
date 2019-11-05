using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firsttest
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey Ckey = ConsoleKey.F;
            List<Group> groupList = new List<Group>();
            while (true)
            {
                Console.Write("\n\n");
                Console.Write("  Student Management \n");
                Console.Write("                                   \n");
                Console.Write(" 1) Add a new student to the group \n");
                Console.Write(" 2) Create a new group             \n");
                Console.Write(" 3) List all students in a group   \n");
                Console.Write(" 4) Remove Student from a group    \n");
                Ckey = Console.ReadKey().Key;

                if (Ckey == ConsoleKey.Escape | Ckey == ConsoleKey.D5) { System.Diagnostics.Process.GetCurrentProcess().Kill(); }
                
                if (Ckey == ConsoleKey.D2)
                {
                    Console.Write(" Please enter a name of the group you're about to create: ");
                    string GroupName = Console.ReadLine();
                    groupList.Add(new Group(GroupName));
                    Console.WriteLine("Group created successfully!");
                    Console.ReadKey();
                }

                if (Ckey == ConsoleKey.D1)
                {
                    string FirstName = "";
                    string LastName = "";
                    int PersonalCode = 0;
                    
                    Console.Write("Please enter the student's first name: ");
                    FirstName = Console.ReadLine();
                    Console.Write("\n Please enter the student's last name: ");
                    LastName = Console.ReadLine();
                    Console.Write("\n Please enter the student's code: ");
                    bool IsValid = int.TryParse(Console.ReadLine(), out PersonalCode);
                    Console.Write("\n Please type a name of the group you'd like to add the student into: ");
                    string group = Console.ReadLine();
                    Group ChosenGroup = groupList.FirstOrDefault(x => x.Name == group);
                    if (ChosenGroup != null & FirstName != "" & LastName != "")
                    {
                        foreach (Group g in groupList)
                        {
                          if (g.Name == ChosenGroup.Name)
                            {
                                g.AddNewStudent(FirstName, LastName, PersonalCode);
                                Console.Write($"\nThe Student has been successfully added to {g.Name}\n");
                                Console.ReadKey();
                            }
                        }
                    }
                    
                }
                if (Ckey == ConsoleKey.D3)
                {
                    Console.Write("\nPlease enter the group where you'd like to list the students from: ");
                    string Group = Console.ReadLine();
                    Group ChosenGroup = groupList.FirstOrDefault(x => x.Name == Group);
                    if (ChosenGroup != null)
                    {
                        ChosenGroup.ListStudents();
                    }
                    else if (ChosenGroup == null )
                    {
                        Console.WriteLine("The group you specified does not exist! ");
                    }
                    Console.ReadKey();
                }

                if (Ckey == ConsoleKey.D4)
                {
                    int PersonalCode = 0;
                    Console.Write("\nPlease enter the student's personal code: ");
                    bool IsValid = int.TryParse(Console.ReadLine(), out PersonalCode);
                    Console.Write("\nEnter a name of the group: ");
                    string Group = Console.ReadLine();
                  
                    Group ChosenGroup = groupList.FirstOrDefault(x => x.Name == Group);
                    if (ChosenGroup != null)
                    {
                        foreach (Group g in groupList)
                        {
                            if (g.Name == ChosenGroup.Name)
                            {
                               foreach (Student s in g.ListOfStudents)
                                {
                                    if (s.PersonalCode == PersonalCode)
                                    {
                                        g.ListOfStudents.Remove(s);
                                    }
                                }
                            }
                        }
                    }
                }

                Console.Clear();
            }
        }
    }
}
