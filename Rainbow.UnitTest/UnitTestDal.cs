using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainbow.Dal;
using Rainbow.IDal;
using Rainbow.Models;

namespace Rainbow.UnitTest
{
    [TestClass]
    public class UnitTestDal
    {
        /// <summary>
        /// 测试插入
        /// </summary>
        [TestMethod]
        public void TestInsert()
        {
            Isys_roleDal roledal = new sys_roleDal();
            sys_role one = new sys_role()
            {
                id = Guid.NewGuid().ToString(),
                rowname = "admin",
                createtime = DateTime.Now
            };
            bool res = roledal.Insert(one);
        }
        /// <summary>
        /// 获得所有的数据
        /// </summary>
        [TestMethod]
        public void TestGetAll()
        {
            Isys_roleDal roledal = new sys_roleDal();
            IEnumerable<sys_role> t = roledal.GetAll();
        }
        [TestMethod]
        public void getId()
        {

        }
    }
}
