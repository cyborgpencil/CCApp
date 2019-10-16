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
                    context.Child.Add(new Child { ChildFirstName = ChildFirstName, ChildMiddleName = ChildMiddleName, ChildLastName = ChildLastName,
                    ChildBirthDate = ChildBirthDate});
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
