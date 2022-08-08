using System;

namespace Shoes.Statistic
{
    internal class ByColor
    {   
        internal class Pair
        {
            public string color { get; set; }
            public int quantity { get; set; }
        }

       
        public static void StatisticByColor(Mange.Item[] shoes)
        {
            int size = 0;
            // dem so luong
            Func<string, int> Counter = (color) =>
            {
                int count = 0;
                for(int i = 0; i < shoes.Length; i++)
                {
                    if (shoes[i] != null && shoes[i].Color.ToLower().CompareTo(color.ToLower()) == 0)
                    {
                        count++;
                    }
                }
                return count;
            };
            // kiem tra xem da ton tai chua
            Func<string, int, bool> Exsit = (color, pos) =>
            {
                for (int i = 0; i < pos; i++)
                {
                    if (shoes[i] != null && shoes[i].Color.ToLower().CompareTo(color.ToLower()) == 0)
                    {
                        return true;
                    }
                }
                return false;
            };
            Pair[] result = new Pair[shoes.Length];
            for(int i = 0; i < shoes.Length; i++)
            {
                if (shoes[i] != null)
                {
                    if (!Exsit(shoes[i].Color, i))
                    {
                        result[size] = new Pair();
                        result[size].color = shoes[i].Color;
                        result[size].quantity = Counter(shoes[i].Color);
                        size++;
                    }
                }
            }

            // tao mot mang moi de sap xep

            var finalResult = new Pair[size];
            Array.Copy(result, finalResult, size);
            Array.Sort(finalResult, (p1, p2) => p2.quantity - p1.quantity);

            for (int i = 0; i < finalResult.Length; i++)
            {
                Console.WriteLine($"Color: {finalResult[i].color} - Quantity: {finalResult[i].quantity}");
            }
        }
    }
}
