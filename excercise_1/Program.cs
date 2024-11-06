namespace excercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SchoolAdministration administration = new SchoolAdministration();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("choose action: 1. add person, 2. remove person, 3. display people, 4. display students, 5. display teachers, 6. display workers");
                switch (NumberInput(6))
                {
                    case 1: administration.AddPerson(); break;
                    case 2: administration.RemovePerson(); break;
                    case 3: administration.DisplayPeople(); break;
                    case 4: administration.DisplayStudents(); break;
                    case 5: administration.DisplayTeachers(); break;
                    case 6: administration.DisplayWorkers(); break;

                }

                Console.WriteLine("\naction complete (press any key)");
                Console.ReadKey();
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
    }
}
