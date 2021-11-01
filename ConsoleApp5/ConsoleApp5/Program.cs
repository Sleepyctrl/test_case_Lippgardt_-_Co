using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string StatusSearch, NameSearch, SurnameSearch, ContinueSearch; int AgeSearch;

            Patient[] patients = new Patient[6];
            patients[0] = new("Alex","Mitchel",21,"critical");
            patients[1] = new("Kate","Pupsvel",21,"critical");
            //в задании после имени "Georgy" идёт пробел из-за чего были ошибки при поиске по имени
            patients[2] = new("Georgy","Robbinson",21,"normal");
            patients[3] = new("LG","Company",120,"normal");
            patients[4] = new("Mikky","Mouse",30,"critical");
            
            do
            {
                Console.WriteLine(" " +
                    "1-поиск по возрасту меньше введённого значения" +
                    " \r \n 2-поиск по статусу" +
                    " \r \n 3-поиск по имени" +
                    " \r \n 4-поиск по фамилии");
                
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    //ВЫЗОВ МЕТОДА ПОИСКА ПО ВОЗРАСТУ
                    case 1:
                        Console.WriteLine("Введите возраст");
                        AgeSearch = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            AgeSearching(patients[i].name, patients[i].surname, patients[i].age, AgeSearch);
                        }
                        break;

                    //ВЫЗОВ МЕТОДА ПОИСКА ПО СТАТУСУ
                    case 2:
                        Console.WriteLine("Введите статус");
                        StatusSearch = Convert.ToString(Console.ReadLine()).ToUpper();
                        for (int i = 0; i < 5; i++)
                        {
                            StatusSearching(patients[i].name, patients[i].surname, patients[i].status, StatusSearch);
                        }
                        break;

                    //ВЫЗОВ МЕТОДА ПОИСКА ПО ИМЕНИ
                    case 3:
                        Console.WriteLine("Введите имя");
                        NameSearch = Convert.ToString(Console.ReadLine()).ToUpper();
                        for (int i = 0; i < 5; i++)
                        {
                            NameSearching(patients[i].name, patients[i].surname, NameSearch);
                        }
                        break;

                        //ВЫЗОВ МЕТОДА ПОИСКА ПО ФАМИЛИИ
                    case 4:
                            Console.WriteLine("Введите фамилию");
                             SurnameSearch = Convert.ToString(Console.ReadLine()).ToUpper();
                            for (int i = 0; i < 5; i++)
                            {
                                surnamesearching(patients[i].name,patients[i].surname,SurnameSearch);
                            }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Продолжить поиск? Yes/No");
                ContinueSearch = Convert.ToString(Console.ReadLine()).ToUpper();
            } while (ContinueSearch == "YES");
            Console.ReadKey();
        }
        // МЕТОД ПОИСКА ПО ВОЗРАСТУ
        public static void AgeSearching(string name, string surname,int age, int AgeSearch)
        {
            if (age < AgeSearch)
            {
                Console.WriteLine("{0} {1} ", name, surname);
            }
        }
        //МЕТОД ПОИСКА ПО ФАМИЛИИ
        public static void surnamesearching(string name, string surname,string SurnameSearch)
        {
                if (surname.ToUpper() == SurnameSearch)
                {
                    Console.WriteLine("{0} {1} ", name, surname);
                }
        }
        //МЕТОД ПОИСКА ПО ИМЕНИ
        public static void NameSearching(string name, string surname, string Namesearch)
        {
            if (name.ToUpper() == Namesearch)
            {
                Console.WriteLine("{0} {1} ", name, surname);
            }
        }
        //МЕТОД ПОИСКА ПО СТАТУСУ
        public static void StatusSearching(string name, string surname,string status, string StatusSearch)
        {
            if (status.ToUpper() == StatusSearch)
            {
                Console.WriteLine("{0} {1} ", name, surname);
            }
        }
    }
    class Patient
    {
        public string name;
        public string surname;
        public int age;
        public string status;
        public Patient(string name, string surname, int age, string status)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.status = status;
                
        }
    }
}
