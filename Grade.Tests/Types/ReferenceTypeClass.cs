using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade.Tests.Types
{
    [TestClass]
    public class ReferenceTypeClass
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x2, x1);           
        }
        [TestMethod]
        public void GradeBookVariableHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Austin's Gradebook";
            Assert.AreEqual(g1.Name, g2.Name);
        }
    }
}
