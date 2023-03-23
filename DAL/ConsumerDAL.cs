using BLL;
using BOL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConsumerDAL: IConsumer
    {
        ApplicationContext _context = new ApplicationContext();
        public List<Consumer> getAllConsumer()
        {
            var user = from u in _context.consumer select u;
            return user.ToList();
        }

          public Consumer validateConsumer(String RationId, String password)
          {

              List<Consumer> clist = getAllConsumer();
               if (clist != null)
                {
                 foreach (Consumer c in clist)
                 {
                  
                      if (c.Ration_Id.Equals(RationId) && c.Password.Equals(password))
                         return c;

                 }
              }
              return null;

          }

        /*public Consumer validateConsumer(String RationId, String password)
        {
            var user = from u in _context.consumer where u.Ration_Id == RationId && u.Password == password select u;
            return (Consumer)user;
        }*/

        public Consumer showDetailsByID(String user)
        {
            List<Consumer> clist = getAllConsumer();
            if (clist != null)
            {
                foreach (Consumer c in clist)
                {

                    if (c.Ration_Id.Equals(user))
                        return c;

                }
            }
            return null;

        }
    }
}
