using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Dal
{
    public class ServiceBase
    {
        protected DbBase DB;
        public ServiceBase()
        {
            //取数据库对象
            DB = DbFactory.GetSDDB();
        }
    }
}
