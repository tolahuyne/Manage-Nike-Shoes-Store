using System;


namespace Shoes
{
    internal class ViewList
    {
        public static void ShowList(Shoes.Mange.Item[] shoes)
        {
            var title_Id = "ID";
            var title_Name = "Name";
            var title_Price = "Price";
            var title_Color = "Color";
            var title_Quantity = "Quantity";

            Console.WriteLine($"{title_Id,-15:d}{title_Name, -15:d}{title_Quantity,-10:d}" +
                $"{title_Price,-15:d}{title_Color,-10:d}");

            foreach (var item in shoes)
            {
                if(item != null)
                {
                    Console.WriteLine($"{item.Id,-15:d}{item.Name,-15:d}{item.Quantity,-10:d}" +
                        $"{item.Price,-15:d}{item.Color,-10:d}");
                }
            }
        }
    }
}
