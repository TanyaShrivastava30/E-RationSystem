using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace DAL
{
    public class RolesDAL: IRoles
    {
        ApplicationContext _context = new ApplicationContext();
        public int getRolesofUserbyRole_Title(string Role_Title)
        {
                var roleID = (from role in _context.role
                              where role.Role_Title == Role_Title
                              select role.Role_Id).SingleOrDefault();
                
                return roleID;
            
        }
    }
}
