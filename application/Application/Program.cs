using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace application
{

    class Program
    {

        static void Main(string[] args)
        {
            string path = "E:\\code of week 1 vs studio\\application\\textfile.txt";
            string[] names = new string[100];
            string[] password = new string[100];
            string[] role = new string[100];
            //arrays for medicine store
            string[] medicinenames = new string[100];
            int[] medicinequantity = new int[100];
            float[] medicineprice = new float[100];

            int countmed = 0;

            string productname;


            int option;
            int adminoption;
            int countuser = 0;
            do
            {
                readData(path, names, password, role, ref countuser);
                loadmedicine( medicinenames, medicinequantity, medicineprice, ref countmed);
                Console.Clear();

                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name");
                    String aname = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    String apassword = Console.ReadLine();
                    string roleoption = signIn(aname, apassword, names, password, ref countuser, role);
                    if (roleoption == "Admin")

                    {
                        while (true)
                        {
                            Console.Clear();
                            adminoption = adminop();
                            if (adminoption == 1)
                            {
                                while (true)
                                {

                                    Console.Clear();

                                    Console.WriteLine("your are in Adding product menu");

                                    Console.WriteLine("Enter the Medicine name:");

                                    productname = Console.ReadLine();
                                    addproduct(productname, medicinenames, medicinequantity, medicineprice, ref countmed);
                                    storemedicine( medicinenames, medicinequantity, medicineprice, ref countmed);

                                    break;





                                }
                            }

                            else if (adminoption == 2)
                            {
                                while (true)
                                {
                                    Console.Clear();

                                    Console.WriteLine("your are in update the  product menu");

                                    Console.WriteLine("Enter the Medicine name:");

                                    productname = Console.ReadLine();

                                    string answer = updateproduct(productname, medicinenames, medicinequantity, medicineprice, ref countmed);
                                    Console.WriteLine(answer);
                                    storemedicine(medicinenames, medicinequantity, medicineprice, ref countmed);
                                    Console.ReadKey();

                                    break;
                                }
                            }
                            else if (adminoption == 3)
                            {
                                while (true)
                                {
                                    Console.Clear();

                                    Console.WriteLine("your are  in view  product menu");
                                    view(medicinenames, medicinequantity, medicineprice, ref countmed);


                                    Console.ReadKey();

                                    break;
                                }
                            }
                            else if (adminoption == 4)
                            {
                                while (true)
                                {
                                    Console.Clear();

                                    Console.WriteLine("your are in search the  product menu");

                                    Console.WriteLine("Enter the Medicine name:");

                                    productname = Console.ReadLine();

                                    string answer = searchproduct(productname, medicinenames, medicinequantity, medicineprice, ref countmed);
                                    Console.WriteLine(answer);
                                    Console.ReadKey();

                                    break;
                                }
                            }
                            else if (adminoption == 5)
                            {
                                while (true)
                                {
                                    Console.Clear();

                                    Console.WriteLine("your are in Delete the  product menu");

                                    Console.WriteLine("Enter the Medicine name you want to delete  :");

                                    productname = Console.ReadLine();

                                    string answer = deleteproduct(productname, medicinenames, ref countmed);
                                    Console.WriteLine(answer);
                                    storemedicine(medicinenames, medicinequantity, medicineprice, ref countmed);
                                    Console.ReadKey();

                                    break;
                                }
                            }
                            }
                    }






                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter New  Name");
                    String aname = Console.ReadLine();
                    Console.WriteLine("Enter New Password");
                    String apassword = Console.ReadLine();

                    signUp(path, aname, apassword, names, password, ref countuser);
                }

            }
            while (option < 3);
            Console.Read();

        }


        static int menu()
        {
            int option;
            Console.WriteLine("Press 1 for sign In  :");
            Console.WriteLine("Press 2 for signup");
            Console.WriteLine("Enter your option ");
            option = int.Parse(Console.ReadLine());

            return option;

        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
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

        static void readData(string path, string[] names, string[] password, string[] role,ref int  countuser)
        {
            
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[countuser] = parseData(record, 1);
                    password[countuser] = parseData(record, 2);
                    role[countuser] = parseData(record, 3);
                    countuser++;
                    
                }
                fileVariable.Close();

            }
            else
            {
                Console.WriteLine("No Exits");
            }
        }

        static string signIn(string aname, string apassword, string[] names, string[] password, ref int countuser, string[] role)
        {

            for (int x = 0; x < countuser; x++)
            {
                if (names[x] == aname && password[x] == apassword)
                {
                    Console.WriteLine("Valid user");
                    Console.ReadKey();
                    return role[x];

                }
            }

            return "invalid user";




        }
        static void signUp(string path, string aname, string apassword, string[] names, string[] password, ref int countuser)
        {
            string present =  "true";
            for (int index = 0; index <= countuser; index++)
            {
                if (aname == names[index] && apassword == password[index])
                {
                    present = "false";
                    break;
                }
            }
            if (present == "false")
            {
                Console.WriteLine("user already presents");
                Console.ReadKey();

            }
            else if (countuser < 100)
            {
                Console.WriteLine("Enter your role");
                String arole = Console.ReadLine();

                if (arole == "Admin" || arole == "User")
                {
                    countuser++;

                    StreamWriter file = new StreamWriter(path, true);
                    file.WriteLine(aname + "," + apassword + "," + arole);
                    
                    Console.WriteLine("Sucessfully stored");
                    Console.ReadKey();
                    file.Flush();
                    file.Close();
                  
                }
                else
                {
                    Console.WriteLine("Enter correct role");
                    Console.ReadKey();
                }
            }
        }


        static int adminop()
        {

            int option;
            Console.WriteLine(" Press 1 for add the products    ");
            Console.WriteLine(" Press 2 update the products     ");
            Console.WriteLine(" Press 3 view the products     ");
            Console.WriteLine(" Press 4 to search the Product     ");
            Console.WriteLine(" Press 5 to delete the product     ");
            Console.WriteLine(" Your option--- ");
            option = int.Parse(Console.ReadLine());
            return option;
        }


        static void addproduct(string productname, string[] medicinenames, int[] medicinequantity, float[] medicineprice, ref int countmed)
        {

            float productprice;
            int productquantity;




            bool ppresent = false;
            for (int index = 0; index < countmed; index++)
            {
                if (medicinenames[index] == productname)
                {
                    ppresent = true;
                    break;
                }
            }
            if (ppresent == true)
            {

                Console.WriteLine("Medicine  already presents");
                Console.ReadKey();
            }

            else if (countmed < 100)
            {
                Console.WriteLine("Enter the Medicine price:");
                productprice = float.Parse(Console.ReadLine());


                Console.WriteLine("Enter the Medicine quantity:");
                productquantity = int.Parse(Console.ReadLine());


                medicinenames[countmed] = productname;
                medicineprice[countmed] = productprice;
                medicinequantity[countmed] = productquantity;

                Console.WriteLine("Sucessfully stored");

                countmed++;
                Console.ReadKey();
            }




        }

       static string  updateproduct(string productname, string[] medicinenames, int[] medicinequantity, float[] medicineprice, ref int countmed)
        {



            float productprice;
            int productquantity;




            string  ppresent = "false";
            string qvalue;
            int change = 0;
            for (int index = 0; index < countmed; index++)
            {
                if (medicinenames[index] == productname)
                {
                    change = index;
                    ppresent = "true";
                    break;
                }
            }
            if (ppresent == "true")
            {

                Console.WriteLine("Yes Medicine presents");
                Console.WriteLine("Enter the Medicine price:");
                productprice = float.Parse(Console.ReadLine());


                Console.WriteLine("Enter the Medicine quantity:");
                productquantity = int.Parse(Console.ReadLine());


                medicinenames[change] = productname;
                medicineprice[change] = productprice;
                medicinequantity[change] = productquantity;

              qvalue= "Sucessfully update";
                Console.ReadKey();


            }
            else
            {
                qvalue = "Medicine not present ";
                Console.ReadKey();

            }

            return qvalue;

               }

        static void view(string[] medicinenames, int[] medicinequantity, float[] medicineprice, ref int countmed)
        {
            for (int index = 0; index < countmed; index++)

            { 
                if (medicinenames[index] !="soory")
                {
                    Console.WriteLine("\t Medicine name is :"+ medicinenames[index]);
                    Console.WriteLine("\t Medicine Price  is :"+ medicinequantity[index]);
                    Console.WriteLine("\t Medicine name is :"+ medicineprice[index]) ;
                } 
            }
         }
        static string deleteproduct(string productname, string[] medicinenames,  ref int countmed)
        {
            string ppresent = "false";
            string qvalue;
           
            for (int index = 0; index < countmed; index++)
            {
                if (medicinenames[index] == productname)
                {
                    medicinenames[index] = "sorry";
                   
                    ppresent = "true";
                    break;
                }
            }
            if (ppresent == "true")
            {

                qvalue="Yes Medicine Deleted Successfully";
               
            }
            else
            {
                qvalue = "Medicine not present ";

            }

            return qvalue;
        }
        static string searchproduct(string productname, string[] medicinenames, int[] medicinequantity, float[] medicineprice, ref int countmed)
        {



            string ppresent = "false";
            string qvalue;

            for (int index = 0; index < countmed; index++)
            {
                if (medicinenames[index] == productname)
                {
                    Console.WriteLine("\t Medicine name is :" + medicinenames[index]);
                    Console.WriteLine("\t Medicine Price  is :" + medicinequantity[index]);
                    Console.WriteLine("\t Medicine name is :" + medicineprice[index]);

                    ppresent = "true";
                    break;
                }
            }
            if (ppresent == "true")
            {

                qvalue = "Yes Medicine Deleted Successfully";

            }
            else
            {
                qvalue = "Medicine not present ";

            }

            return qvalue;
        }
static void storemedicine(string[] medicinenames, int[] medicinequantity, float[] medicineprice, ref int countmed)
        {
            StreamWriter file= new StreamWriter("E:\\code of week 1 vs studio\\application\\medicinestore.txt");
            for (int index = 0; index < countmed; index++)
            {
                file.Write(medicinenames[index] + "," + medicinequantity[index]);
                file.WriteLine(medicineprice[index]);
            }
            file.Close();


        }

        static void loadmedicine(string[] medicinenames, int[] medicinequantity, float[] medicineprice, ref int countmed)
        {
            string path = "E:\\code of week 1 vs studio\\application\\medicinestore.txt";
            StreamReader file = new StreamReader(path);
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    medicinenames[countmed] = parsedata(record, 1);
                    medicinequantity[countmed] =int.Parse( parsedata(record, 2));
                    medicineprice[countmed] = float.Parse(parsedata(record, 3));
                    countmed++;



                }
                file.Close();
            }
            else {

                Console.WriteLine("Enter correct role");
                Console.ReadKey();

            }


        }
        static string parsedata(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
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









    }
}
