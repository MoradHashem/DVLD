using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestTypes
    {
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3 };

        public clsTestTypes.enTestType TestTypeID { get; set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public double TestTypeFees { get; set; }


        public clsTestTypes(clsTestTypes.enTestType TestTypeID, string TestTypeTitle, string TestTypeDescription, double TestTypeFees)
        {
            this.TestTypeID = TestTypeID;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }


        private bool _UpdateTestType()
        {
            return clsTestTypesDataAccess.UpdateTestTypes((int)this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }


        public bool Save()
        {
            return _UpdateTestType();
        }


        public static DataTable GetAllTestTypes()
        {
            return (clsTestTypesDataAccess.GetAllTestTypes());
        }


        public static clsTestTypes Find(clsTestTypes.enTestType TestTypeID)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            double TestTypeFees = 0;

            if (clsTestTypesDataAccess.GetTestTypesInfoByID((int)TestTypeID, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees))

                return new clsTestTypes(TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees);
            else
                return null;
        }
    }
}
