using System.Collections.Generic;
using MyClassLibrary;

namespace Class_Library
{
    public class clsSupplierCollection
    {
         
        //priavte data member for the list 
        List<clsSupplierPage> mSupplierList = new List<clsSupplierPage>();
        //private data member thisStaff
        clsSupplierPage mThisSupplier = new clsSupplierPage();

        //public property for ThisStaff
        public List<clsSupplierPage> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
         set
            {
                //set the private data
                mSupplierList = value;
            }
        }
        //
        public int Count
        {
            get
            {
                //return the count foer the list 
                return mSupplierList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }


        public clsSupplierPage ThisSupplier
        {
            get
            {
                //return the private data
                return mThisSupplier;
            }
            set
            {
                //set th eprivate data
                mThisSupplier = value;
            }
        }
    }
}