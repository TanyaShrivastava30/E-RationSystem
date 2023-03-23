using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IStock
    {
        List<Stock> getAllStock();

        List<Stock> getSupplierStock();

        List<Stock> getDistributorStock();
    }
}
