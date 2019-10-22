using Caliburn.Micro;
using CCApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCApp.ViewModels
{
    public class ChildMainViewModel : Conductor<object>
    {
        private IEventAggregator _eventAggregator;
        public string ChildSelectedItem { get; set; }
        public ObservableCollection<Child> Children { get; set; }
        public ObservableCollection<string> ChildList { get; set; }
        public Child SelectedChild { get; set; }
        public string ChildFN { get; set; }

        public ChildMainViewModel()
        {
            // Load Children
            LoadChildList();
        }

        public ChildMainViewModel(IEventAggregator eventAggregator)
        {
            // Load Children
            LoadChildList();
            _eventAggregator = eventAggregator;
        }

        public void ShowGeneralChildInfo(string child)
        {
            child = ChildSelectedItem;
        }

        public void ShowCreateChild()
        {
            ActivateItem(new ChildCreateViewModel());
        }

        public void LoadChildList()
        {
            // check for any children in database
            List<Child> children = LoadChildrenFromDB();
            Children = new ObservableCollection<Child>(children);
        }

        private List<Child> LoadChildrenFromDB()
        {
            // open database
            List<Child> childrenList = new List<Child>();


            using (var context = new CCAppEntities())
            {


                if (context.Child.Count() != 0)
                {
                    var children = context.Child.ToList<Child>();

                    foreach (var c in children)
                    {
                        childrenList.Add(c);
                    }
                }
            }

            return childrenList;
        }

        public void ShowSelectedChild()
        {


            ActivateItem(new ChildInfoViewModel(_eventAggregator, SelectedChild));
            
        }
    }
}

    
