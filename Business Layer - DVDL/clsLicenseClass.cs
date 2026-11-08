using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLicenseClass
    {

        public int LicenseClassID { get; set; }
        public string LicenseName { get; set; }
        public string ClassDescription { get; set; }
        public short MinimumAllowedAge { get; set; }
        public short DefaultValidityLength { get; set; }
        public double ClassFees { get; set; }



        public clsLicenseClass()
        {
            this.LicenseClassID = -1;
            this.LicenseName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = 0;
        }

        public clsLicenseClass(int LicenseClassID, string LicenseName, string ClassDescription,
                                short MinimumAllowedAge, short DefaultValidityLength, double ClassFees)
        {
            this.LicenseClassID = LicenseClassID;
            this.LicenseName = LicenseName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

        }

        public static DataTable ListLicenseClass()
        {
            return clsLicenseClassDataAccess.ListAllLicenseClass();
        }


        public static clsLicenseClass Find(int LicenseClassID)
        {
            string LicenseName = "", ClassDescription = "";
            short MinimumAllowedAge = 0, DefaultValidityLength = 0;
            double ClassFees = 0;

            if (clsLicenseClassDataAccess.GetLicenseClassInfoByID(LicenseClassID, ref LicenseName, ref ClassDescription,
                                                                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClass(LicenseClassID, LicenseName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);

            else
                return null;
        }


        public static clsLicenseClass Find(string LicenseName)
        {
            string ClassDescription = "";
            short MinimumAllowedAge = 0, DefaultValidityLength = 0;
            double ClassFees = 0;
            int LicenseClassID = -1;

            if (clsLicenseClassDataAccess.GetLicenseClassInfoByClassName(ref LicenseClassID, LicenseName, ref ClassDescription,
                                                                ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))

                return new clsLicenseClass(LicenseClassID, LicenseName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);

            else
                return null;
        }

    }
}
