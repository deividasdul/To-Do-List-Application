using System.Reflection.Metadata.Ecma335;

namespace To_Do_List_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Header
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("----------------------");

            List<String> lists = new List<string>();

            while (true)
            {
                MainMenu();
                int input = Input();

                if (input == 1)
                {
                    do
                    {
                        AddList(lists);
                        Console.Write("Would you like to add more (y/n): ");
                        string yn = Console.ReadLine();
                        if (yn != "y")
                        {
                            break;
                        }
                    } 
                    while (true);
                }
                else if (input == 2)
                {
                    do
                    {
                        Console.WriteLine("Which To-Do would you like to delete: ");
                        int delete = Convert.ToInt32(Console.ReadLine());
                        RemoveList(lists, delete);
                        Console.WriteLine("Would you like to remove more (y/n): ");
                        string yn = Console.ReadLine();
                        if (yn != "y")
                        {
                            break;
                        }
                    } 
                    while (true);
                }
                else if (input == 3)
                {
                    do
                    {
                        ListList(lists);
                        Console.Write("Would you like to see again (y/n): ");
                        string yn = Console.ReadLine();
                        if (yn != "y")
                        {
                            break;
                        }
                    } 
                    while (true);
                }
                else if (input == 4)
                {
                    Exit();
                    break;
                }
            }
        }

        static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Choice (1-4)");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. List");
            Console.WriteLine("4. Exit");
            Console.WriteLine("----------------------");
            Console.WriteLine();
        }

        static int Input()
        {
            Console.Write("Enter Choice: ");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        static void AddList(List<string>lists)
        {
            Console.Write("Enter To-Do: ");
            string todo = Console.ReadLine();
            lists.Add(todo);
        }

        static void RemoveList(List<string> lists, int delete)
        {
            if (delete >= 0 && delete < lists.Count)
            {
                lists.RemoveAt(delete);
            }
            else
            {
                Console.WriteLine("Invalid index. Nothing was removed.");
            }
        }

        static void ListList(List<string> lists)
        {
            for (int i = 0; i < lists.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, lists[i]);
            }
        }

        static void Exit()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}