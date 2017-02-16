using System;

namespace MyClassLibrary
{
    public class clsSupplierPage
    {
        public Int32 SupplierID;

        public clsSupplierPage()
        {
        }

        public bool Active { get; set; }
        public DateTime DeliveryDate { get; set; }

        public bool Valid(int numOfSupplier, DateTime DeliveryDate)
        {

            Boolean Ok = true;
            DateTime tempDate;
            if (numOfSupplier == 0)
            {
                Ok = false;
            }
            if (numOfSupplier > 100)
            {
                Ok = false;

            }
            if (numOfSupplier < 0)
            {
                Ok = false;
            }

            try
            {
                tempDate = Convert.ToDateTime(DeliveryDate);
                if (tempDate < DateTime.Now.Date)
                {
                    Ok = false;
                }

                if (tempDate > DateTime.Now.Date)
                {
                    Ok = false;
                }
            }

            catch
            { }
            return Ok;

        }
    }
}