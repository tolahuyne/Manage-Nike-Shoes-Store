using System;


namespace Shoes.Mange
{
    internal class Item
    {
        private static int _AutoID { get; set; } = 1000; // id se tang tu 1000
        private string _id; // ma so
        public string Id // trung gian giup doc va ghi vao _id
        {
            get => _id;
            set
            {
                if(_id != value)
                {
                    _id = value;
                }
                else
                {
                    _id = "NK" + _AutoID++;
                }
            }
        }

        public string Name { get; set; } // ten san pham
        public int Quantity { get; set; } // so luong
        public long Price { get; set; } // gia tien
        public string Color { get; set; } // mau sac

        public Item()
        {

        }
        public Item(string id, string name, int quantity, long price, string color)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
            Color = color;
        }
    }
}
