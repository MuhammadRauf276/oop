using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.BL;
using System.IO;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            List<MUser> users = new List<MUser>();
            string path = "textfile.txt";
            int option;
            int choice;
            bool check = readData(path, users);
            if (check)
                Console.WriteLine("Data Loaded SuccessFully");
            else
                Console.WriteLine("Data Not Loaded");
            Console.ReadKey();
            do
            {
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    MUser user = takeInputWithoutRole();
                    if (user != null)
                    {
                        user = signIn(user, users);
                        if (user == null)
                            Console.WriteLine("Invalid User");
                        else
                        {
                            Console.WriteLine("Welcome, {0}! You are logged in as a {1}.", user.name, user.role);
                            if (user.isAdmin())
                                do
                                {
                                    Console.WriteLine("Admin Menu");
                                    choice = adminop();
                                    if (choice == 1)
                                    {
                                        
                                        Console.Clear();
                                       
                                    }
                                    else if (choice == 2)
                                    {
                                       
                                        
                                    }
                                    else if (choice == 3)
                                    {
                                     
                                    }
                                    else if (choice == 4)
                                    {
                                       
                                    }

                                } while (choice != 5);
                            
                            else
                                Console.WriteLine("User Menu");
                        }

                    }
                }
                else if (option == 2)
                {
                    MUser user = takeInputWithRole();
                    if (user != null)
                    {
                        storeDataInFile(path, user);
                        storeDataInList(users, user);

                    }
                }
                Console.ReadKey();
            }
            while (option < 3);






        }


        static int menu()
        {
            int option;
            Console.WriteLine("Press 1 for SignIn");
            Console.WriteLine("Press 2 for SignUp");
            Console.WriteLine("Enter Option");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        static string parseData(string
record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length;
            x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static bool readData(string path, List<MUser> users)

        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string name = parseData(record, 1);
                    string password = parseData(record, 2);
                    string role = parseData(record, 3);
                    MUser user = new MUser(name, password, role);
                    storeDataInList(users, user);
                }
                fileVariable.Close();
                return true;
            }
            return false;
        }
        static MUser takeInputWithoutRole()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            return null;

        }
        static MUser takeInputWithRole()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Enter Role: ");
            string role = Console.ReadLine();
            if (name != null && password != null && role != null)
            {
                MUser user = new MUser(name, password, role);
                return user;
            }
            return null;
        }
        static void storeDataInList(List<MUser> users, MUser user)
        {
            users.Add(user);
        }
        static void storeDataInFile(string path, MUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.name + "," + user.password + "," + user.role);
            file.Flush();
            file.Close();
        }
        static MUser signIn(MUser user, List<MUser> users)
        {
            foreach (MUser storedUser in users)
            {
                if (user.name == storedUser.name && user.password == storedUser.password)
                {
                    return storedUser;
                }
            }
            return null;
        }
        static int adminop()
        {

            int option;
            Console.WriteLine(" Press 1 for add the products    ");
            Console.WriteLine(" Press 2 update the products     ");
            Console.WriteLine(" Press 3 view the products     ");
            Console.WriteLine(" Press 4 to search the Product     ");
            Console.WriteLine(" Press 5 to delete the product     ");
            Console.WriteLine(" Press 6 to exit    ");
            Console.WriteLine(" Your option--- ");

            option = int.Parse(Console.ReadLine());
            while ((option > 6 || option < 0))
            {
                Console.WriteLine(" Invalid option Please enter correct option ");
                Console.WriteLine(" Your option--- ");
                option = int.Parse(Console.ReadLine());
            }

            return option;
        }











    }
}
