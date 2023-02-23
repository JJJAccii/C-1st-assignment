using System;

namespace goods_with_5_different_props
{
    class GoodsItem
    {
        public int ProductNum;
        public string Name;
        public double Price;
        public string Picture;
        public int Ordernum;

        static void Main(string[] args)
        {
            GoodsItem one = new GoodsItem { ProductNum = 1, Name = "apple", Price = 1.5, Picture = "apple.jpg", Ordernum = 1 };
            GoodsItem two = new GoodsItem { ProductNum = 2, Name = "phone", Price = 850, Picture = "phone.jpg", Ordernum = 2 };
            GoodsItem three = new GoodsItem { ProductNum = 3, Name = "pen", Price = 2, Picture = "pen.jpg", Ordernum = 3 };
            GoodsItem four = new GoodsItem { ProductNum = 4, Name = "light", Price = 4, Picture = "light.jpg", Ordernum = 4 };
            GoodsItem five = new GoodsItem { ProductNum = 5, Name = "bmw", Price = 45000, Picture = "bmw.jpg", Ordernum = 5 };
            GoodsItem six = new GoodsItem { ProductNum = 6, Name = "monster", Price = 2.5, Picture = "monster.jpg", Ordernum = 6 };
            GoodsItem seven = new GoodsItem { ProductNum = 7, Name = "macbook", Price = 1999, Picture = "macbook.jpg", Ordernum = 7 };
            GoodsItem eight = new GoodsItem { ProductNum = 8, Name = "boots", Price = 249, Picture = "boots.jpg", Ordernum = 8 };
            GoodsItem nine = new GoodsItem { ProductNum = 9, Name = "cable", Price = 1.5, Picture = "cable.jpg", Ordernum = 9 };
            GoodsItem ten = new GoodsItem { ProductNum = 10, Name = "mouse", Price = 85, Picture = "mouser.jpg", Ordernum = 10 };
         
        }
    }

    public GoodsItem itemGet(string name)
    {
        foreach (GoodsItem item in items)
        {
            if (item.Name == name)
            {
                return item;
            }
        }
        throw new ArgumentException("Item not found.");
    }
}
