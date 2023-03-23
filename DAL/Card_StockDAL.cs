using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Card_StockDAL: ICard_Stock
    {
        ApplicationContext _context = new ApplicationContext();
        public List<Card_Stock> getALLItems()
        {
            var item = from i in _context.cardType select i;
            return item.ToList();
        }

        public List<Card_Stock> getItemsByYellowCard()
        {
            var item = from i in _context.cardType where (i.CardType == "Yellow") select i;
            return item.ToList();
        }

        public List<Card_Stock> getItemsByOrangeCard()
        {
            var item = from i in _context.cardType where (i.CardType == "Orange") select i;
            return item.ToList();
        }

        public List<Card_Stock> getItemsByWhiteCard()
        {
            var item = from i in _context.cardType where (i.CardType == "White") select i;
            return item.ToList();

        }

       // public List<Card_Stock> 
    }
}
