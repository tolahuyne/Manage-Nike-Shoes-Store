using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Core
{
    internal partial class Core
    {
        public static void StatisticCore(Mange.Item[] shoes)
        {
            int StaChoice;
            do
            {
                Console.WriteLine("=======> Nike Shoes Store <========");
                Console.WriteLine("1. Statistic By Color");
                Console.WriteLine("2. Statistic By Price");
                Console.WriteLine("0. Exit");
                StaChoice = int.Parse(Console.ReadLine());

                switch (StaChoice)
                {
                    case 1:
                        {   
                            Statistic.ByColor.StatisticByColor(shoes);
                            break;
                        }
                    case 2:
                        {
                            Statistic.ByPrice.StatisticByPrice(shoes);
                            break;
                        }
                    default:
                        {
                            if(StaChoice != 0)
                            {
                                Console.WriteLine("Pls choose number from 1 to 3");
                            }
                            break;
                        }
                        
                }
            } while (StaChoice != 0);
        }
    }
}
