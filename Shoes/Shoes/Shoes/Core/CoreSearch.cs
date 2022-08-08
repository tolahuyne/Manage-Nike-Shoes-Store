using System;


namespace Shoes.Core
{
    internal partial class Core
    {

        public static void SearchItem(Mange.Item[] shoes)
        {
            int choiceSearch;
            do
            {
                Console.WriteLine("=======> Nike Shoes Store <==========");
                Console.WriteLine("1. Search By ID");
                Console.WriteLine("2. Search By Name");
                Console.WriteLine("3. Search By Color");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.Write("Your choice: ");
                choiceSearch = int.Parse(Console.ReadLine());
                switch (choiceSearch)
                {
                    case 1:
                        {
                            Console.Write("Input ID you need search: ");
                            string id = Console.ReadLine();
                            var result = Search.SearchItems.FindByID(shoes, id);
                            Shoes.ViewList.ShowList(result);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Input Name you need search: ");
                            string name = Console.ReadLine();
                            var result = Search.SearchItems.FindByName(shoes, name);
                            Shoes.ViewList.ShowList(result);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Input Color you need search: ");
                            string color = Console.ReadLine();
                            var result = Search.SearchItems.FindByColor(shoes, color);
                            Shoes.ViewList.ShowList(result);
                            break;
                        }
                    default:
                        {
                            if (choiceSearch != 0)
                            {
                                Console.WriteLine("Pls choose number from 1 - 3 !");
                            }
                            break;
                        }


                }

            } while (choiceSearch != 0);
        }
    }
}

