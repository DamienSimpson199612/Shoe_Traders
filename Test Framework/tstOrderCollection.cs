using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see if it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderList()
        {
            //create a instance 
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see if it exists
            //create some test data to assign the property
        }
    }

}
