using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;

namespace Test_Framework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of out class staff
            clsStaff Staff = new clsStaff();
            //check to see that the class is not null
            Assert.IsNotNull(Staff);

        }

    }
}
