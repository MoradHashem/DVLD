using System;
using System.Data;
using System.Data.SqlClient;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplicationTypes
    {

        public int ApplicationTypeID { get; private set; }
        public string ApplicationTypeTitle { get; set; }
        public double ApplicationFees { get; set; }


        private clsApplicationTypes(int ApplicationTypeID, string ApplicationTypeTitle, double ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeTitle = ApplicationTypeTitle;
            this.ApplicationFees = ApplicationFees;
        }

        public static DataTable ListApplicationTpyes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTpyes();
        }

        private bool _UpdateApplicationTpyes()
        {
            return (clsApplicationTypesDataAccess.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees));
        }

        public bool Save()
        {
            return _UpdateApplicationTpyes();
        }

        public static clsApplicationTypes Find(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";
            double ApplicationFees = 0;

            if (clsApplicationTypesDataAccess.GetApplicationTpyesInfoByID(ApplicationTypeID, ref ApplicationTypeTitle, ref ApplicationFees))

                    return new clsApplicationTypes(ApplicationTypeID, ApplicationTypeTitle, ApplicationFees);
            else
                return null;
        }

    }
}
