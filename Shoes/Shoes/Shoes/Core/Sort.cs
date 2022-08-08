using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Core
{
    internal partial class Core
    {

        public static void SortByNameAndID(Mange.Item[] shoes)
        {
            int choiceSort;
            do
            {
                Console.WriteLine("1. Sort By Name");
                Console.WriteLine("2. Sort By Quantity");
                Console.WriteLine("0. Exit");
                choiceSort = int.Parse(Console.ReadLine());

                switch (choiceSort)
                {
                    case 1:
                        {
                            Arrange.SortByName.ArrangeByName(shoes);
                            break;
                        }
                    case 2:
                        {
                            Arrange.SortByQuantity.ArrangeByQuantity(shoes);
                            break;
                        }
                    default:
                        {
                            if (choiceSort != 0)
                            {
                                Console.WriteLine("Pls choose number from number 1 to 2");
                            }
                            break;
                        }

                }
            } while (choiceSort != 0);
        }
    }
}
