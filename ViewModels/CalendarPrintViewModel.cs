using Caliburn.Micro;
using PrintingLib;
using System.Collections.ObjectModel;

namespace CCApp.ViewModels
{
    public class CalendarPrintViewModel : Screen
    {
        PrintingLib.PrintingLib printlib;
        string defaultPrinter;

        int selectedPrinter;
        public int SelectedPrinter
        {
            get { return selectedPrinter; }
            set
            {
                selectedPrinter = value;
                NotifyOfPropertyChange(() => SelectedPrinter);
            }
        }

        public ObservableCollection<string> PrinterList { get; set; }

        public CalendarPrintViewModel()
        {
            PrinterList = new ObservableCollection<string>();
            printlib = new PrintingLib.PrintingLib();
            defaultPrinter = printlib.GetDefaultPrinter();

            foreach (var printer in printlib.GetListOfPrinters())
            {
                PrinterList.Add(printer);
            }

            for (int i = 0; i < PrinterList.Count; i++)
            {
                if(PrinterList[i] == defaultPrinter)
                {
                    selectedPrinter = i;
                }
            }
            
        }
    }
}
