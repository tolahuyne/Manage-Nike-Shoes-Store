using System;


namespace Shoes.Core
{
    partial class Core
    {

        public static void ManageItem(ref int size, Shoes.Mange.Item[] shoes)
        {

            //Shoes.Mange.Item[] shoes = new Shoes.Mange.Item[100]; // tao mang 
            Shoes.Mange.Manage manage = new Shoes.Mange.Manage(); // tao doi tuong cho lop Manage
            int choice_manage;
            do
            {

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("=========> Nike Shoes Store <========");
                Console.WriteLine("1. Add a new shoe");
                Console.WriteLine("2. Delete shoe");
                Console.WriteLine("3. Update InFo shoe");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.WriteLine("Your choice: ");
                choice_manage = int.Parse(Console.ReadLine());

                switch (choice_manage)
                {
                    case 1:
                        {
                            shoes[size++] = manage.CreateItem();
                            break;
                        }
                    case 2:
                        {
                            if (size > 0)
                            {
                                Console.WriteLine("Input ID you need delete: ");
                                var id = Console.ReadLine();
                                manage.Delete(shoes, id);
                            }
                            else
                            {
                                Console.WriteLine("List is blank");
                            }
                            break;
                        }
                    case 3:
                        {
                            if (size > 0)
                            {
                                Console.WriteLine("Input ID you need update: ");
                                var id = Console.ReadLine();
                                manage.Update(shoes, id);
                            }
                            else
                            {
                                Console.WriteLine("List is blank");
                            }
                            break;
                        }
                    default:
                        break;
                }
            } while (choice_manage != 0);


        }
    }
}
