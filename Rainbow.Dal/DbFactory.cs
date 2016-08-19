using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Dal
{
    public class DbFactory
    {
        /// <summary>
        /// 获取主数据库连接
        /// </summary>
        /// <returns></returns>
        public static DbBase GetSDDB()
        {
            DbBase db = CallContext.GetData("SDDB") as DbBase;
            if (db == null)
            {
                db = new DbBase("SdConnection");
                CallContext.SetData("SDDB", db);
            }
            return db;
        }
    }
}
