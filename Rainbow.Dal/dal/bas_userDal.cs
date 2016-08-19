/*******************************************************************************************
 * 此代码由T4模板自动生成
 * 对此文件的更改可能会导致不正确的行为，并且如果
 * 重新生成代码，这些更改将会丢失。
 * 日期:2016-07-29 11:13:06
 * 作者:huijun zhu<kngcbzdsn@outlook.com> 
 * 此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　                   
 * 版权所有：榆钱（北京）科技有限公司　　　　　　          
 * 此模板生成实体层:Rainbow.Models　　　　　                 
 * *******************************************************************************************/
using System;
using System.Collections.Generic;
using Rainbow.IDal;
using Rainbow.Models;


namespace Rainbow.Dal
{    
    /// <summary>
    /// bas_userDal实现
    /// </summary>
    public partial class bas_userDal:Ibas_userDal    
    {    
	    public bas_user Create()
        {
            throw new NotImplementedException();
        }

        public bool Update(bas_user entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(bas_user entity)
        {
            throw new NotImplementedException();
        }
		/// <summary>
        /// 插入记录
        /// </summary>
        /// <param name="entity">实体bas_user</param>
        /// <returns></returns>
        public int Insert(bas_user entity)
        {
            using (var sqlConnection= ContextFactory.GetContext())
            {
                sqlConnection.Open();
                var db = MyDatabase.Init(sqlConnection, commandTimeout: 2);
                int? supplierId = db.bas_users.Insert(entity);
                return supplierId.Value;

            }
        }
		/// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
		public IEnumerable<bas_user> GetAll()
        {
			using (var sqlConnection = ContextFactory.GetContext())
            {
                sqlConnection.Open();
                var db = MyDatabase.Init(sqlConnection, commandTimeout: 5);

                var result = db.bas_users.All();
                return result;
            }
        }
    }
}
    
