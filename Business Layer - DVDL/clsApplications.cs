using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplications
    {

        public enum enMode { AddNew = 0, Update = 1};
        public enum enApplicationType 
        {
            NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4, ReleaseDetainedDrivingLicsense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };
        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };


        public enMode Mode;


        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public string ApplicantFullName
        {
            get
            {
                return clsPeople.Find(ApplicantPersonID).FullName;
            }
        }
        public string StatusText
        {
            get
            {
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";
                }

            }
        }

        public clsPeople PersonInfo;
        public clsApplicationTypes ApplicationTypeInfo;
        public clsUsers CreatedByUserInfo;


        public clsApplications()
        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        public clsApplications(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
                               enApplicationStatus ApplicationStatus, DateTime LastStatusDate, double PaidFees, int CreatedByUserID)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            this.PersonInfo = clsPeople.Find(ApplicantPersonID);
            this.ApplicationTypeInfo = clsApplicationTypes.Find(ApplicationTypeID);
            this.CreatedByUserInfo = clsUsers.FindByUserID(CreatedByUserID);

                Mode = enMode.Update;
        }


        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationsDataAccess.AddNewApplication(this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (short)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);


            return (this.ApplicationID != -1);
                               
        }


        private bool _UpdateApplication()
        {
            return clsApplicationsDataAccess.UpdateApplication(this.ApplicationID, this.ApplicantPersonID, this.ApplicationDate,
                this.ApplicationTypeID, (short)this.ApplicationStatus, this.LastStatusDate, this.PaidFees, this.CreatedByUserID);
        }


        public bool Save()
        {
            switch (this.Mode)
            {
                case enMode.AddNew:
                    {
                        if (_AddNewApplication())
                        {
                            Mode = enMode.Update;

                            return true;
                        }
                    }
                    break;

                case enMode.Update:


                    return _UpdateApplication();

                    break;

            }

            return false;

        }


        public bool Delete()
        {
            return clsApplicationsDataAccess.DeleteApplication(this.ApplicationID);
        }


        public static DataTable ListAllApplications()
        {
            return clsApplicationsDataAccess.GetAllApplications();
        }


        public static clsApplications FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            short ApplicationStatus = -1;
            DateTime LastStatusDate = DateTime.Now, ApplicationDate = DateTime.Now;
            double PaidFees = 0;


            if (clsApplicationsDataAccess.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID,
                               ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID))

                return new clsApplications(ApplicationID, ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                                            (enApplicationStatus)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            else

            return null;
        }


        public static bool IsApplicationExist(int ApplicationID)
        {
            return clsApplicationsDataAccess.IsApplicationExist(ApplicationID);
        }


        public bool Cancel()
        {
            return clsApplicationsDataAccess.UpdateStatus(this.ApplicationID, (int)enApplicationStatus.Cancelled);
        }


        public bool SetComppleted()
        {
            return clsApplicationsDataAccess.UpdateStatus(this.ApplicationID, (int)enApplicationStatus.Completed);
        }


        public static bool DosePersonHaveActiveApplication(int PersonID, int ApplicationTypeID)
        {
            return clsApplicationsDataAccess.DoesPersonHaveActiveApplication(PersonID, ApplicationTypeID);
        }


        public bool DosePersonHaveActiveApplication(int ApplicationTypeID)
        {
            return DosePersonHaveActiveApplication(this.ApplicantPersonID , ApplicationTypeID);
        }


        public static int GetActiveApplicationID(int PersonID, clsApplications.enApplicationType ApplicationTypeID)
        {
            return clsApplicationsDataAccess.GetActiveApplicationID(PersonID, (int)ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplications.enApplicationType ApplicationTypeID, int LicenseClassID)
        {
            return clsApplicationsDataAccess.GetActiveApplicationIdForLicenseClass(PersonID, (int)ApplicationTypeID, LicenseClassID);
        }

        public int GetActiveApplicationID(clsApplications.enApplicationType ApplicationTypeID)
        {
            return GetActiveApplicationID(this.ApplicantPersonID, ApplicationTypeID);
        }
    }
}
