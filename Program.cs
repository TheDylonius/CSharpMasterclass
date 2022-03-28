using System;
using System.Collections;

namespace CSharpMasterclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashtables();
            HashtablesChallenge();
        }

        static void Hashtables()
        {
            // Create a new Hashtable object.
            var table = new Hashtable();

            // Generate students for the Hashtable.
            var student1 = new Student(1, "Maria", 98);
            var student2 = new Student(2, "Jason", 76);
            var student3 = new Student(3, "Clara", 43);
            var student4 = new Student(4, "Steve", 55);

            // Add the students to the Hashtable.
            table.Add(student1.Id, student1);
            table.Add(student2.Id, student2);
            table.Add(student3.Id, student3);
            table.Add(student4.Id, student4);

            // Loop through each entry within the Hashtable.
            foreach (Student student in table.Values)
            {
                // Display the information for the current student to the user.
                Console.WriteLine($"Student ID: {student.Id}");
                Console.WriteLine($"Student Name: {student.Name}");
                Console.WriteLine($"Student GPA: {student.GPA}");
                Console.WriteLine();
            }

            // Await further user input.
            Console.ReadKey();
        }

        static void HashtablesChallenge()
        {
            Student[] students = new Student[5];

            students[0] = new Student(1, "Liam", 98);
            students[1] = new Student(2, "Maria", 98);
            students[2] = new Student(2, "Jason", 76);
            students[3] = new Student(3, "Clara", 43);
            students[4] = new Student(4, "Steve", 55);

            /* Challenge below: Create a hashtable with all non-duplicated keys. */

            // Create a new hashtable.
            var hashtable = new Hashtable();

            // Loop through the students in the array.
            foreach (var student in students)
            {
                // Write the current student's details to the console.
                Console.WriteLine($"{student.Id} - {student.Name}");

                // Check whether the key exists within the hashtable.
                if (hashtable.ContainsKey(student.Id))
                {
                    // Inform the user that the key already exists.
                    Console.WriteLine("This student already existed.");
                }
                else
                {
                    // Add the student into the hashtable.
                    hashtable.Add(student.Id, student);

                    // Inform the user that the student was added.
                    Console.WriteLine("Student was added successfully.");
                }
            }
        }
    }
}