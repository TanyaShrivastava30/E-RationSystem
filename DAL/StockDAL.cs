using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BOL;

namespace DAL
{
    public class StockDAL: IStock
    {
        ApplicationContext _context = new ApplicationContext();
        public List<Stock> getAllStock()
        {
            var items  = from i in _context.stock where (i.Stock_Id == "20001") select i;
            return items.ToList();
        }

        public List<Stock> getSupplierStock()
        {
            var items = from i in _context.stock where (i.Stock_Id == "20002") select i;
            return items.ToList();
        }

        public List<Stock> getDistributorStock()
        {
            var items = from i in _context.stock where (i.Stock_Id == "20003") select i;
            return items.ToList();
        }
    }
}
