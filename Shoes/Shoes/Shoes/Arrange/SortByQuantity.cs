using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Arrange
{
    internal  class SortByQuantity
    {
        
        public static void ArrangeByQuantity(Mange.Item[] shoes)
        {   
            // delegate giup so sanh gia tri cua 2 bien item
            Func<Mange.Item, Mange.Item, int> Comparer = (s1, s2) =>
            {
                if (s1 == null || s2 == null)
                {
                    return -1;
                }
                else
                {
                    if (s1.Quantity < s2.Quantity)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            };
            for (int i = 0; i < shoes.Length - 1; i++)
            {
                for(int j = shoes.Length - 1; j > i; j--)
                {
                    if (Comparer(shoes[j - 1], shoes[j]) > 0)
                    {
                        var tmp = shoes[j];
                        shoes[j] = shoes[j - 1];
                        shoes[j - 1] = tmp;
                    } 
                }
            }
        }
    }
}
