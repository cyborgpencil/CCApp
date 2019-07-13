using Caliburn.Micro;
using System.Windows;

namespace CCApp.ViewModels
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                NotifyOfPropertyChange(() => CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(Name); }
        }

        public void SayHello()
        {
            MessageBox.Show($"Hello {Name}");
        }
    }

    
}
