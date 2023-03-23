using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ISupplier
    {
        List<Supplier> getALLSupplier();

        Supplier showDetailsByID(String user);
      
    }
}
