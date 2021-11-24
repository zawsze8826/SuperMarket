using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class GoodsOutOfDate : Goods
    {
        private List<Goods> OutOfDateList = new List<Goods>();
        public GoodsOutOfDate()
        {
        }
        ~GoodsOutOfDate()
        { }
        public void AddOutOfDate()
        {
            Goods good = new GoodsOutOfDate();
            foreach (Goods g in SuperMarket.InventorieList)
            {
                TimeSpan time =g.EXP - DateTime.Now;
                if (time.Days < 0)
                {
                    good.IDGoods = g.IDGoods;
                    good.NameGoods = g.NameGoods;
                    good.PurchasePrice = g.PurchasePrice;
                    good.Price = g.Price;
                    good.MFG = g.MFG;
                    good.EXP = g.EXP;
                    good.Vat = g.Vat;
                    good.Quantity = g.Quantity;
                    OutOfDateList.Add(good);
                }
                else continue;
            }
        }

        public  void Delete()
        {
            throw new NotImplementedException();
        }
        public  void Upadate()
        {
            throw new NotImplementedException();
        }
        public  void Search()
        {
            throw new NotImplementedException();
        }
        public  void DisplayOutOfDay()
        {
            foreach(Goods go in OutOfDateList)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", go.IDGoods, go.NameGoods, go.PurchasePrice, go.Price, go.MFG.ToString("dd/MM/yyyy"), go.EXP.ToString("dd/MM/yyyy"), go.Quantity, go.Vat);
            }
        }
    }
}
