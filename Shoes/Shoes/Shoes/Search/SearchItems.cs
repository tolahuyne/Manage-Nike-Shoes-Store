using System;


namespace Shoes.Search
{
    internal class SearchItems
    {
        // theo mau sac 
        public static Mange.Item[] FindByColor(Mange.Item[] shoes, string color)
        {
            int size = 0;
            Mange.Item[] result = new Mange.Item[shoes.Length];
            foreach (var item in shoes)
            {
                if (item != null && item.Color.ToLower().CompareTo(color.ToLower()) == 0)
                {
                    result[size++] = item;
                }
            }
            return result;
        }
        // theo ten
        public static Mange.Item[] FindByName(Mange.Item[] shoes, string name)
        {
            int size = 0;
            Mange.Item[] result = new Mange.Item[shoes.Length];
            foreach (var item in shoes)
            {
                if (item != null && item.Name.ToLower().CompareTo(name.ToLower()) == 0)
                {
                    result[size++] = item;
                }
            }
            return result;
        }
        // theo id
        public static Shoes.Mange.Item[] FindByID(Mange.Item[] shoes, string id)
        {
            int size = 0;
            Mange.Item[] result = new Mange.Item[shoes.Length];
            foreach (var item in shoes)
            {
                if(item != null && item.Id.ToLower().CompareTo(id.ToLower()) == 0)
                {
                    result[size++] = item;
                }
            }
            return result;
        }
    }
}
