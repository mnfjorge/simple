﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NHibernate.Linq;
using Simple.Tests.Resources;

namespace Simple.Tests.DataAccess
{
    [TestFixture]
    public class NHLinqFixture : BaseDataFixture
    {
        [Test]
        public void GroupTerritoriesByEmployee()
        {
            var mapping = Session.Linq<EmployeeTerritory>();

            var q = mapping.GroupBy(x => x.Employee.Id)
                .Select(x => new { x.Key, Count = x.Count() });

            var list = q.ToDictionary(x => x.Key);

            Assert.AreEqual(9, list.Count);

            Assert.AreEqual(2, list[1].Count);
            Assert.AreEqual(7, list[2].Count);
            Assert.AreEqual(4, list[3].Count);
            Assert.AreEqual(3, list[4].Count);
            Assert.AreEqual(7, list[5].Count);
            Assert.AreEqual(5, list[6].Count);
            Assert.AreEqual(10, list[7].Count);
            Assert.AreEqual(4, list[8].Count);
            Assert.AreEqual(7, list[9].Count);
        }

        [Test, Explicit ("NH Linq Bug")]
        public void MaxWithEmptySet()
        {
            var max = Session.Query<EmployeeTerritory>().Where(x=>x.Employee.Id == 0).Max(x=>x.Territory.Region.Id);
            Assert.That(max, Is.EqualTo(0));
        }

        [Test, Explicit("NH Linq Bug")]
        public void ToLookupWithEmptySet()
        {
            int[] ids = new int[0];
            var max = Session.Query<EmployeeTerritory>().Where(x => ids.Contains(x.Employee.Id)).ToLookup(x => x.Employee);
            Assert.That(max.Count, Is.EqualTo(0));
        }
    }
}
