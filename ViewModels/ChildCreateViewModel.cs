using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CCApp.Data;

namespace CCApp.ViewModels
{
    public class ChildCreateViewModel : Conductor<object>
    {
        public string ChildFirstName { get; set; }
        public string ChildMiddleName { get; set; }
        public string ChildLastName { get; set; }
        public string ChildBirthDate { get; set; }
        public string ChildIsActive { get; set; }
        public string ChildGender { get; set; }
        public string ChildAddress { get; set; }
        public string ChildCity { get; set; }
        public string ChildState { get; set; }
        public Nullable<long> ChildZip { get; set; }
        public Nullable<long> ChildPhone { get; set; }

        public ChildCreateViewModel()
        {
            ClearChildInfo();
        }

        public void SaveChildInfo()
        {

            using (var context = new CCAppEntities())
            {
                // verify data
                if (VerifyChildInfo())
                {
                    // open DB
                    context.Database.Connection.Open();

                    // CRUD
                    context.Child.Add(new Child
                    {
                        ChildFirstName = this.ChildFirstName,
                        ChildMiddleName = this.ChildMiddleName,
                        ChildLastName = this.ChildLastName,
                        ChildBirthDate = this.ChildBirthDate,
                        ChildIsActive = this.ChildIsActive,
                        ChildAddress = this.ChildAddress,
                        ChildCity = this.ChildCity,
                        ChildState = this.ChildState,
                        ChildGender = this.ChildGender,
                        ChildZip = this.ChildZip,
                        ChildPhone = this.ChildPhone
                    });
                    // save child to db
                    context.SaveChanges();
                    ClearChildInfo();
                }


            }

        }

        public bool VerifyChildInfo()
        {
            if (!String.IsNullOrWhiteSpace(ChildFirstName) && !String.IsNullOrWhiteSpace(ChildLastName) && !String.IsNullOrWhiteSpace(ChildBirthDate))
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearChildInfo()
        {
            ChildFirstName = "";
            ChildMiddleName = "";
            ChildLastName = "";
            ChildBirthDate = "";
        }

    }
}
