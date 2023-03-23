using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DistributorDAL: IDistributor
    {
        ApplicationContext _context = new ApplicationContext();
        public List<Distributor> getAllDistributor()
        {
            var duser = from d in _context.distributor select d;
            //List<Distributor> dlist=duser.ToList
            return duser.ToList<Distributor>();
        }
}
}
