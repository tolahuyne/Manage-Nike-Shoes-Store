using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.Arrange
{
    internal class SortByName
    {
        public static void ArrangeByName(Mange.Item[] shoes)
        {
            for(int i = 0; i < shoes.Length - 1; i++)
            {
                for(int j = shoes.Length - 1; j > i; j--)
                {
                    if (shoes[j] != null && shoes[j].Name.ToLower().CompareTo(shoes[j - 1].Name.ToLower()) < 0)
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
