using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class LoginDAL:ILogin
    {
        ApplicationContext _context = new ApplicationContext();
       
        public List<Login> GetUser()
        {
            var log = from l in _context.login select l;
            return log.ToList();

        }

        public List<Role> GetRole()
        {
            var role = from r in _context.role select r;
            return role.ToList<Role>();
        }

        public Login ValidateUser(string userName, string passWord)
        {
            List<Login> llist = GetUser();
            foreach (Login log in llist)
            {
                if(llist != null)
                {
                    if (log.User_Name.Equals(userName) && log.Password.Equals(passWord))
                        return log;
                }
            }
            return null;

        }

    }
    }

