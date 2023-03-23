using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ICard_Stock
    {
        List<Card_Stock> getALLItems();
        List<Card_Stock> getItemsByYellowCard();
        List<Card_Stock> getItemsByWhiteCard();
        List<Card_Stock> getItemsByOrangeCard();

    }
}
