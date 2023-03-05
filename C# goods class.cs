using System;
using System.Collections.Generic;

namespace Goods
{
    class GoodsItem
    {
        public int Num;
        public double price;
        public int Ordernum;

        public virtual void GetItem(int ProductNum, double Productprice, int Productordernum)
        {
            Num = ProductNum;
            price = Productprice;
            Ordernum = Productordernum;
        }


     class apple:GoodsItem
        {
            public override void GetItem(int ProductNum, double Productprice, int Productordernum)
            {
                base.GetItem(ProductNum, Productprice, Productordernum);
                Console.WriteLine("This item is Apple with product number:" + Num + " ,product price: $" + price + " , and product order number:" + Ordernum);
            }
        }

        class phone : GoodsItem
        {
            public override void GetItem(int ProductNum, double Productprice, int Productordernum)
            {
                base.GetItem(ProductNum, Productprice, Productordernum);
                Console.WriteLine("This item is Apple with product number:" + Num + " ,product price: $" + price + " , and product order number:" + Ordernum);
            }
        }
 
        
        class PC : GoodsItem
        {
            public override void GetItem(int ProductNum, double Productprice, int Productordernum)
            {
                base.GetItem(ProductNum, Productprice, Productordernum);
                Console.WriteLine("This item is Apple with product number:" + Num + " ,product price: $" + price + " , and product order number:" + Ordernum);
            }
        }


        class Car : GoodsItem
        {
            public override void GetItem(int ProductNum, double Productprice, int Productordernum)
            {
                base.GetItem(ProductNum, Productprice, Productordernum);
                Console.WriteLine("This item is Apple with product number:" + Num + " ,product price: $" + price + " , and product order number:" + Ordernum);
            }
        }




        static void Main(string[] args)
        {
            GoodsItem myapple = new apple();
            GoodsItem myphone = new phone();
            GoodsItem mypc = new PC();
            GoodsItem mycar = new Car();
            myapple.GetItem(25, 1.25, 4576);
            myphone.GetItem(13, 999, 45411);
            mypc.GetItem(102, 1299, 456478);
            mycar.GetItem(878, 49999, 471211);


            List<int> mySet = new List<int>();
            try
              {
                itemSet(mySet, myapple.Ordernum);
                itemSet(mySet, myapple.Ordernum);
                itemSet(mySet, myapple.Ordernum);
                itemSet(mySet, myapple.Ordernum);
            }
             catch (ArgumentException ex)
              {
                    Console.WriteLine(ex.Message);
              }


             static void itemSet(List<int> mySet, int newItem)
            {
                if (mySet.Contains(newItem))
                {
                    throw new ArgumentException("Item already exists in the set.");
                }
                else
                {
                    mySet.Add(newItem);
                }
            }

        }
    }
}
