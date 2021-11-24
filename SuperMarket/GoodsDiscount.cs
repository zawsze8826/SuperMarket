using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class GoodsDiscount : Goods
    {
        private List<Goods> DiscountList = new List<Goods>();
        public GoodsDiscount()
        { }
        ~GoodsDiscount()
        { }
        public void AddDiscount()
        {
            Goods good = new GoodsDiscount();
            foreach (Goods g in SuperMarket.InventorieList)
            {
                TimeSpan time = g.EXP - DateTime.Now;
                if (time.TotalDays > 0 && time.TotalDays < 1)
                {
                    good.IDGoods = g.IDGoods;
                    good.NameGoods = g.NameGoods;
                    good.PurchasePrice = g.PurchasePrice;
                    good.Price = (double)g.Price - (double)g.Price*20/(double)100;
                    good.MFG = g.MFG;
                    good.EXP = g.EXP;
                    good.Quantity = g.Quantity;
                    DiscountList.Add(good);
                }
                else continue;
            }
        }

        public void DeleteDiscount()
        {
            throw new NotImplementedException();
        }

        public void SearchDiscount()
        {
            throw new NotImplementedException();
        }

        public void DisplayDiscount()
        {
            foreach (Goods go in DiscountList)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", go.IDGoods, go.NameGoods, go.PurchasePrice, go.Price, go.MFG.ToString("dd/MM/yyyy"), go.EXP.ToString("dd/MM/yyyy"), go.Quantity);
            }
        }
    }
}
