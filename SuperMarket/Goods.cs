using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Goods 
    {
        private string iDGoods;
        private string nameGoods;
        private double purchasePrice;
        private double price;
        private DateTime eXP;
        private DateTime mFG;
        private int quantity;
        public string IDGoods { get => iDGoods; set => iDGoods = value; }
        public string NameGoods { get => nameGoods; set => nameGoods = value; }
        public double PurchasePrice { get => purchasePrice; set => purchasePrice = value; }
        public double Price { get => price; set => price = value; }
        public DateTime EXP { get => eXP; set => eXP = value; }
        public DateTime MFG { get => mFG; set => mFG = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Goods()
        { }
        ~Goods()
        { }
    }
}
