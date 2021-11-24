using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class GoodsInventory : Goods
    {
        public GoodsInventory()
        {
        }
        ~GoodsInventory()
        { }
        public void AddInventory()
        {
            int temp = 0;
            Goods go = new GoodsInventory();

            if (SuperMarket.InventorieList.Count == 0)
            {
                go.IDGoods = "GO1";
            }
            else
            {
                foreach (Goods g in SuperMarket.InventorieList)
                {
                    temp = Convert.ToInt32(g.IDGoods.Substring(2));
                }
                go.IDGoods = "GO" + Convert.ToString(temp + 1);
            }

            Console.Write("Nhap ten san pham:");
            go.NameGoods = Console.ReadLine();

            Console.Write("Nhap gia mua san pham:");
            go.PurchasePrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap gia ban:");
            go.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so luong mua ve:");
            go.Quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap ngay san xuat:");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            go.MFG = new DateTime(year, month, day);

            Console.Write("Nhap han su dung:");
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
            go.EXP = new DateTime(year, month, day);

            SuperMarket.InventorieList.Add(go);
        }
        public  void DeleteInventory()
        {
            throw new NotImplementedException();
        }
        public  void UpadateInventory()
        {
            throw new NotImplementedException();
        }
        public  void SearchInventory()
        {
            throw new NotImplementedException();
        }
        public void DisplayInventory()
        {
            foreach (Goods go in SuperMarket.InventorieList)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", go.IDGoods, go.NameGoods, go.PurchasePrice, go.Price, go.MFG.ToString("dd/MM/yyyy"), go.EXP.ToString("dd/MM/yyyy"), go.Quantity);
            }
        }
    }
}
