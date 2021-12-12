using System;

namespace UsersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4 : 
            //User personOne = new User("Eden", "Tasama", 1996, "rrr@gmail.com");
            //personOne.PrintingInfo();


            //List<User> users = new List<User>();


            //Console.WriteLine("Enter 4 users");
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Enter name");
            //    string Fname = Console.ReadLine();

            //    Console.WriteLine("Enter last name");
            //    string Lname = Console.ReadLine();


            //    Console.WriteLine("Enter Year Of Birth");
            //    int yearBirth = int.Parse(Console.ReadLine());


            //    Console.WriteLine("Enter Email");
            //    string email = Console.ReadLine();

            //    User userLoop = new User(Fname, Lname, yearBirth, email);

            //    users.Add(userLoop);

            //}

            //6 :
            //WrittenToFile(users);

            //7:
            //ReadingFromFile(users);

            //8:
            //GetWrittenToFileAnd(users);

            //User[] arrayOfList = new User[] { users[0] , users[1], users[2] , users[3] };
            //Array.Sort(arrayOfList);


            //for (int i = 0; i < arrayOfList.Length; i++)
            //{
            //    arrayOfList[i].PrintingInfo();

            //}

            //5 : 
            //Student studentOne = new Student(10, "Eden", "Tal", 1996, "dd@gmail.com");
            //studentOne.PrintingInfo();

            //9:
            //ChooseFileSelect("list");


            //10:
            MenuApp();

        }

        static void WrittenToFile(List<User> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                FileStream fileStream = new FileStream(@"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\שיעורי בית\משימת סופש 09.12.2021\files\list.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine($"{list[i].Fname} {list[i].LName} {list[i].YearOfBirth} {list[i].Email}");
                }
            }


        }




        static void ReadingFromFile(List<User> list)
        {

            FileStream fileStream = new FileStream(@"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\שיעורי בית\משימת סופש 09.12.2021\files\list.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }


        //8:
        static void GetWrittenToFileAnd(List<User> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\שיעורי בית\משימת סופש 09.12.2021\files\{list[i].Fname}_{list[i].LName}.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.WriteLine($"{list[i].Fname} {list[i].LName} {list[i].YearOfBirth} {list[i].Email}");
                }

                FileStream fileStreamTwo = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\שיעורי בית\משימת סופש 09.12.2021\files\list.txt", FileMode.Append);
                using (StreamWriter writer = new StreamWriter(fileStreamTwo))
                {
                    writer.WriteLine($"{list[i].Fname} {list[i].LName} {list[i].YearOfBirth} {list[i].Email}");
                }

            }

        }


        //9:

        static void ChooseFileSelect(string nameOfFile)
        {
            FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\שיעורי בית\משימת סופש 09.12.2021\files\{nameOfFile}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        static void CaseOne()
        {
            Console.WriteLine("Enter name:");
            string nameUser = Console.ReadLine();

            Console.WriteLine("Enter Last name:");
            string nameLastUser = Console.ReadLine();

            Console.WriteLine("Enter year of birth");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email");
            string emailUser = Console.ReadLine();

            User userInput = new User(nameUser, nameLastUser, year, emailUser);



        }

        static void CaseTwo(string person)
        {
            FileStream fileStreamTwo = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\שיעורי בית\משימת סופש 09.12.2021\files\{person}.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStreamTwo))
            {
                writer.WriteLine();
            }

        }

        static void MenuApp()
        {
            Console.WriteLine("1. Add User");

            Console.WriteLine("2. Edit User");

            Console.WriteLine("3.Delete User");

            Console.WriteLine("4. Show user info");
            int option = int.Parse(Console.ReadLine());



            switch (option)
            {
                case 1:
                    try
                    {
                        CaseOne();
                    }
                    catch (FormatException) { Console.WriteLine("value must be number"); }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;

                case 2:
                    try
                    {
                        Console.WriteLine("Enter name:");
                        string nameLastUser = Console.ReadLine();
                        CaseTwo(nameLastUser);
                    }
                    catch (FormatException) { Console.WriteLine("value must be number"); }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;

                case 3:
                    try {; }
                    catch (FormatException) { Console.WriteLine("value must be number"); }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;

                case 4:
                    //WrittenToFile(users);
                    try {; }
                    catch (FormatException) { Console.WriteLine("value must be number"); }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }
                    break;

                default:
                    MenuApp();
                    break;
            }

        }

    }



}