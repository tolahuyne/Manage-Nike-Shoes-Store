using System;

namespace Shoes.Mange
{
    internal class Manage
    {
        // cap nhat san pham 
        public Item[] Update(Item[] shoes, string id)
        {
            int choice;
            bool result = false;
            for (int i = 0; i < shoes.Length; i++)
            {
                if (shoes[i] != null)
                {
                    if (id.ToLower().CompareTo(shoes[i].Id.ToLower()) == 0)
                    {
                        do
                        {
                            Console.WriteLine("What do you wanna update?");
                            Console.WriteLine("1. Name");
                            Console.WriteLine("2. Quantity");
                            Console.WriteLine("3. Price");
                            Console.WriteLine("4. Color");
                            Console.WriteLine("0. Exit");
                            Console.Write("Your choice: ");
                            choice = int.Parse(Console.ReadLine());


                            switch (choice)
                            {
                                case 1:
                                    {
                                        Console.Write("Input new name: ");
                                        var name = Console.ReadLine();
                                        shoes[i].Name = name;
                                        result = true;
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Input new quantity: ");
                                        var quantity = int.Parse(Console.ReadLine());
                                        shoes[i].Quantity = quantity;
                                        result = true;
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write("Input new Price: ");
                                        var price = long.Parse(Console.ReadLine());
                                        shoes[i].Price = price;
                                        result = true;
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write("Input new quantity: ");
                                        var color = Console.ReadLine();
                                        shoes[i].Color = color;
                                        result = true;
                                        break;
                                    }
                                default:
                                    {
                                        if (choice != 0)
                                        {
                                            Console.WriteLine("Pls choose number from 1 to 4");
                                        }
                                        break;
                                    }
                            }
                        } while (choice != 0);
                    }
                }
            }
            if (result)
            {
                Console.WriteLine("Update Successfully");
            }
            else
            {
                Console.WriteLine("Update False");
            }
            return shoes;
        }
        // xoa san pham
        public Item[] Delete(Item[] shoes, string id)
        {
            bool result = false;
            for (int i = 0; i < shoes.Length; i++)
            {
                if (shoes[i] != null)
                {
                    if (id.ToLower().CompareTo(shoes[i].Id.ToLower()) == 0)
                    {
                        result = true;
                        shoes[i] = null;
                        for (int j = i; j < shoes.Length - 1; j++)
                        {
                            shoes[j] = shoes[j + 1];
                        }
                    }
                }
            }
            if (result)
            {
                Console.WriteLine("Delete successfully");
            }
            else
            {
                Console.WriteLine("Can't Find the item");
            }
            return shoes;
        }
        // them moi 1 san pham
        public Item CreateItem()
        {
            Console.WriteLine("Input Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Input Quantity: ");
            var quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Price: ");
            var price = long.Parse(Console.ReadLine());
            Console.WriteLine("Input Color: ");
            var color = Console.ReadLine();

            return new Item(null, name, quantity, price, color);
        }
    }
}
