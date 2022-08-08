using System;


namespace Shoes.Core
{
     partial class Core
    {
        

        static void Main()
        {
            Shoes.Mange.Item[] shoes = new Shoes.Mange.Item[100]; // tao mang
            Statistic.ByColor statistic = new Statistic.ByColor();
            int size = 0;
            int choice;                     

            do
            {
                Console.WriteLine("====> Nike Shoes Store <====");
                Console.WriteLine("1. Manage Shoes");
                Console.WriteLine("2. View List Shoes");
                Console.WriteLine("3. Search Shoes"); 
                Console.WriteLine("4. Statistic Shoes"); // thong ke
                Console.WriteLine("5. Sort Shoes");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            ManageItem(ref size, shoes);
                            break;
                        }
                
                    case 2:
                        {
                            Shoes.ViewList.ShowList(shoes);
                            break;
                        }
                    case 3:
                        {
                            SearchItem(shoes);
                            break;
                        }
                    case 4:
                        {
                            StatisticCore(shoes);
                            break;
                        }
                    case 5:
                        {
                            SortByNameAndID(shoes);
                            break;
                        }
                }
            } while (choice != 0);
        }
    }
}
