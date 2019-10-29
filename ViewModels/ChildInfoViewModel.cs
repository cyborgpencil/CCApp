using Caliburn.Micro;
using CCApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CCApp.ViewModels
{
    public class ChildInfoViewModel : Conductor<IScreen>.Collection.OneActive, IHandle<string>
    {
        private IEventAggregator _eventAggregator;
        public string SelectedChild { get; set; }

        public int SelectedIndex { get; set; }
        public Child SelectedChildInfo { get; set; }
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

        public bool IsActiveGUI { get; set; }
        public DateTime BirthDateGUI { get; set; }
        public int GenderSelectIndex { get; set; }
        public ObservableCollection<string> GenderList { get; set; }




        public ChildInfoViewModel(IEventAggregator eventAggregator, Child selectedChild)
        {
            SelectedChildInfo = selectedChild;
            _eventAggregator = eventAggregator;
            _eventAggregator.Subscribe(this);

            SetChildGUI();
            SetGenderList();
        }

        public void ShowChildDemographics()
        {

        }

        //public void Selected()
        //{
        //    ActivateItem(new ChildDemograhicsViewModel(_eventAggregator, ChildFN));
        //}

        public void Handle(string message)
        {
            //ChildFN = message;
        }

        public void UpdateChildInfo()
        {

        }

        public void SetChildGUI()
        {
            IsActiveGUI = IsActiveCheckedfromDB(SelectedChildInfo.ChildIsActive);
            

            ChildFirstName = SelectedChildInfo.ChildFirstName;
            ChildMiddleName = SelectedChildInfo.ChildMiddleName;
            ChildLastName = SelectedChildInfo.ChildLastName;
            ChildBirthDate = SelectedChildInfo.ChildBirthDate;
            ChildIsActive = SelectedChildInfo.ChildIsActive;
            SetGender();
            ChildAddress = SelectedChildInfo.ChildAddress;
            ChildCity = SelectedChildInfo.ChildCity;
            ChildState = SelectedChildInfo.ChildState;
            ChildZip = SelectedChildInfo.ChildZip;
            ChildPhone = SelectedChildInfo.ChildPhone;
        }

        public void SetCurentChild()
        {
            SelectedChildInfo.ChildFirstName = ChildFirstName;
            SelectedChildInfo.ChildMiddleName = ChildMiddleName;
            SelectedChildInfo.ChildLastName = ChildLastName;
            SelectedChildInfo.ChildBirthDate = ChildBirthDate;
            IsActiveChecked();
            SelectedGender();
            SelectedChildInfo.ChildAddress = ChildAddress;
            SelectedChildInfo.ChildCity = ChildCity;
            SelectedChildInfo.ChildState = ChildState;
            SelectedChildInfo.ChildZip = ChildZip;
            SelectedChildInfo.ChildPhone = ChildPhone;
        }

        public void SaveChildInfo()
        {
            SetCurentChild();

            using (var context = new CCAppEntities())
            {
                context.Database.Connection.Open();
                if (SelectedChildInfo != null)
                {
                    var childToSave = context.Child.Find(SelectedChildInfo.Id);

                    SetChildProperties(childToSave);

                    int saveCode = context.SaveChanges();
                }
            }
        }

        public void SetChildProperties(Child childFromDB)
        {
            SelectedGender();

            childFromDB.ChildFirstName = SelectedChildInfo.ChildFirstName;
            childFromDB.ChildMiddleName = SelectedChildInfo.ChildMiddleName;
            childFromDB.ChildLastName = SelectedChildInfo.ChildLastName;
            childFromDB.ChildBirthDate = SelectedChildInfo.ChildBirthDate;
            childFromDB.ChildIsActive = SelectedChildInfo.ChildIsActive;
            childFromDB.ChildGender = SelectedChildInfo.ChildGender;
            childFromDB.ChildAddress = SelectedChildInfo.ChildAddress;
            childFromDB.ChildCity = SelectedChildInfo.ChildCity;
            childFromDB.ChildState = SelectedChildInfo.ChildState;
            childFromDB.ChildZip = SelectedChildInfo.ChildZip;
            childFromDB.ChildPhone = SelectedChildInfo.ChildPhone;
        }

        public void IsActiveChecked()
        {
            if (IsActiveGUI)
            {
                SelectedChildInfo.ChildIsActive = "True";
            }
            else
                SelectedChildInfo.ChildIsActive = "False";
        }
        public bool IsActiveCheckedfromDB(string isActive)
        {
            if (isActive == "True")
            {
                return true;
            }
            else
                return false;
        }

        public void BirthDateSelected()
        {
            SelectedChildInfo.ChildBirthDate = BirthDateGUI.ToString();
            ChildBirthDate = BirthDateGUI.ToString();
        }

        public void SelectedGender()
        {
            if (GenderSelectIndex == 0)
            {
                SelectedChildInfo.ChildGender = "Male";
            }
            else
                SelectedChildInfo.ChildGender = "Female";
        }
        public void SetGender()
        {

            if (SelectedChildInfo.ChildGender == "Male")
            {
                GenderSelectIndex = 0;
            }
            else if(SelectedChildInfo.ChildGender == "Female")
            {
                GenderSelectIndex = 1;
            }
            else
                GenderSelectIndex = -1;
        }

        public void SetGenderList()
        {
            List<string> genderList = new List<string> { "Male", "Female" };
            GenderList = new ObservableCollection<string>(genderList);
        }

    }
}
