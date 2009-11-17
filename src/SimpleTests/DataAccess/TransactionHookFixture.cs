﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Simple.Tests.SampleServer;

namespace Simple.Tests.DataAccess
{
    [TestFixture]
    public class TransactionHookFixture : BaseDataFixture
    {
        protected override bool OpenOwnTx
        {
            get
            {
                return false;
            }
        }

        [Test]
        public void TestDeleteWithinTransaction()
        {
            using (MySimply.EnterContext())
            using (var tx = MySimply.BeginTransaction())
            {
                int c = Customer.Count();
                Assert.Throws<Exception>(() => Customer.Service.DeleteTwoCustomers());
                int c2 = Customer.Count();
                Assert.AreEqual(2, c - c2);
                tx.Rollback();

                int c3 = Customer.Count();
                Assert.AreEqual(0, c - c3);
            }
        }

        [Test]
        public void TestDeleteWithoutTransaction()
        {
            using (MySimply.EnterContext())
            {
                int c = Customer.Count();
                Assert.Throws<Exception>(() => Customer.Service.DeleteTwoCustomers());
                int c2 = Customer.Count();

                Assert.AreEqual(0, c - c2);
            }
        }


    }
}