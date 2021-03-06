﻿using NHibernate;
using NUnit.Framework;
using SharpTestsEx;
using Simple.Data.Context;

namespace Simple.Tests.Data
{
    public class BaseDataFixture
    {
        IDataContext dx = null;
        ITransaction tx = null;

        protected virtual bool OpenOwnTx { get { return true; } }

        [SetUp]
        public void Setup()
        {
            if (OpenOwnTx)
            {
                dx = MySimply.EnterContext();
                tx = MySimply.GetSession().BeginTransaction();
            }
        }

        [TearDown]
        public void Teardown()
        {
            if (OpenOwnTx)
            {
                Session.Clear();
                tx.Dispose();
                dx.Dispose();
            }
        }

        public Simply MySimply
        {
            get
            {
                return NHConfig1.Do.Simply;
            }
        }

        public ISession Session { get { return MySimply.GetSession(); } }
    }
}
