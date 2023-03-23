﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;

namespace BLL
{
    public interface ILogin
    {
        Login ValidateUser(string userName, string passWord);
        List<Login> GetUser();
    }
}
