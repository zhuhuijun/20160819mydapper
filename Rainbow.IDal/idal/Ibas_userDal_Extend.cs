using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rainbow.Models;

namespace Rainbow.IDal
{
    public partial interface Ibas_userDal
    {
        /// <summary>
        /// 根据id获得数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bas_user getById(string id);
    }
}
