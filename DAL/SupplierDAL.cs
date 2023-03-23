using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierDAL: ISupplier
    {
        ApplicationContext _context = new ApplicationContext();
        public List<Supplier> getALLSupplier()
        {
            var user = from s in _context.supplier select s;
            return user.ToList();
        }

        public Supplier showDetailsByID(String user)
        {
            List<Supplier> slist = getALLSupplier();
            if (slist != null)
            {
                foreach (Supplier s in slist)
                {

                    if (s.Supplier_Name == user )
                        return s;

                }
            }
            return null;

        }
    }
}
