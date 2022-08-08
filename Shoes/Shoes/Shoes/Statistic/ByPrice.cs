using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Statistic
{
    internal class ByPrice
    {   
        class Pair
        {
            public long Price { get; set; }
            public int Quantity { get; set; }
        }
        public static void StatisticByPrice(Mange.Item[] shoes)
        {   
            // delegate co tac dung xem gia tri da ton tai truoc do chua
            Func<long, int, bool> Exsit = (price, pos) =>
            {
                for (int i = 0; i < pos; i++)
                {
                    if (shoes[i] != null)
                    {
                        if (shoes[i].Price == price)
                        {
                            return true;
                        }
                    }
                }
                return false;
            };

            // delegate giup dem gia tri tung vi tri index cua mang
            Func<long, int> Counter = (price) =>
            {
                int count = 0;
                for(int i = 0; i < shoes.Length; i++)
                {
                    if(shoes[i] != null && shoes[i].Price == price)
                    {
                        count++;
                    }
                }
                return count;
            };

            var result = new Pair[shoes.Length]; 
            int size = 0;
            for(int i = 0; i < shoes.Length; i++)
            {
                if (shoes[i] != null)
                {
                    if (!Exsit(shoes[i].Price, i))
                    {
                        result[size] = new Pair();
                        result[size].Price = shoes[i].Price;
                        result[size].Quantity = Counter(shoes[i].Price);
                        size++;
                    }
                }
            }

            var finalResult = new Pair[size];
            Array.Copy(result, finalResult, size);
            Array.Sort(finalResult, (p1, p2) => p2.Quantity - p1.Quantity);

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Price {finalResult[i].Price} - Quantity: {finalResult[i].Quantity}");
            }
        }
    }
}
