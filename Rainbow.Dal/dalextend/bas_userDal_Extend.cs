﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rainbow.IDal;
using Rainbow.Models;

namespace Rainbow.Dal
{
    public partial class bas_userDal : Ibas_userDal
    {
        public bas_user getById(string id)
        {
            using (var sqlConnection = ContextFactory.GetContext())
            {
                sqlConnection.Open();
                var db = MyDatabase.Init(sqlConnection, commandTimeout: 2);
                db.bas_users.Get(id);
            }
        }
    }
}
