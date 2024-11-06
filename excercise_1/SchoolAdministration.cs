using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise_1
{


    internal class SchoolAdministration
    {
        private List<Person> People = new List<Person>();


        public void RemovePerson()
        {
            Console.Clear();
            Console.WriteLine("enter email of person to be removed");
            string email = Console.ReadLine();
            foreach (Person person in People)
            {
                if (person.Email == email)
                {
                    People.Remove(person);
                    Console.WriteLine($"\n{person.ToString()} removed");
                    return;
                }
            }
            Console.WriteLine("could not find person with specified email");
        }

        public void AddPerson()
        {
            Console.Clear();
            Console.WriteLine("select type of person: 1. student, 2. teacher, 3. worker");
            int selection = NumberInput(3);
            Console.WriteLine("\nenter name");
            string name = StringInput();
            Console.WriteLine("\nenter email");
            string email = StringInput();
            foreach (Person person in People)
            {
                if (person.Email == email)
                {
                    Console.WriteLine("cannot have duplicate email");
                    return;
                }
            }
            Console.WriteLine("\nenter birthdate");
            DateOnly birthdate = DateInput();
            switch (selection)
            {
                case 1:
                    Console.WriteLine("\nenter class");
                    string _class = StringInput();
                    Student new_student = new Student(name, email, birthdate, _class);
                    People.Add(new_student);
                    Console.WriteLine($"\n{new_student.ToString()} added");
                break;
                case 2:
                    Console.WriteLine("\nenter subject");
                    string subject = StringInput();
                    Teacher new_teacher = new Teacher(name, email, birthdate, subject);
                    People.Add(new_teacher);
                    Console.WriteLine($"\n{new_teacher.ToString()} added");
                break;
                case 3:
                    Console.WriteLine("\nenter function description");
                    string functionDescritpion = StringInput();
                    Worker new_worker = new Worker(name, email, birthdate, functionDescritpion);
                    People.Add(new_worker);
                    Console.WriteLine($"\n{new_worker} added");
                break;
            }
        }

        public void DisplayPeople()
        {
            foreach (Person person in People)
            {
                Console.WriteLine(person.ToString());
            }
        }

        public void DisplayStudents()
        {
            foreach (Person person in People)
            {
                if (person.GetType() == typeof(Student))
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }

        public void DisplayTeachers()
        {
            foreach (Person person in People)
            {
                if (person.GetType() == typeof(Teacher))
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }

        public void DisplayWorkers()
        {
            foreach (Person person in People)
            {
                if (person.GetType() == typeof(Worker))
                {
                    Console.WriteLine(person.ToString());
                }
            }
        }
        static int NumberInput(int max_number)
        {
            while (true)
            {
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input > 0 && input <= max_number)
                    {
                        return input;
                    }
                    Console.WriteLine("invalid input");

                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid input");
                }

            }
        }

        static DateOnly DateInput()
        {
            while (true)
            {
                try
                {
                    DateOnly date = DateOnly.Parse(Console.ReadLine());
                    if (date == null) throw new Exception();
                    return date;
                }
                catch
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
        static string StringInput()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    if (input == null || input.Length < 1) throw new Exception();
                    return input;
                }
                catch
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
    }


}
