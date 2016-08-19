using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rainbow.Dal;
using Rainbow.IDal;
using Rainbow.Models;

namespace Rainbow.UnitTest
{
    [TestClass]
    public class UnitTestDal
    {
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
           int t =  roledal.Insert(one);
        }
        [TestMethod]
        public void TestGetAll()
        {
            Isys_roleDal roledal = new sys_roleDal();
            IEnumerable<sys_role> t = roledal.GetAll();
        }
    }
}
