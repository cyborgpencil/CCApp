using Caliburn.Micro;
using CCApp.Views;
using PrintingLib;
using System.Collections.ObjectModel;
using System.Windows.Documents;

namespace CCApp.ViewModels
{
    public class CalendarPrintViewModel : Screen
    {
        private PrintingLib.PrintingLib printlib;
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

            // Set Installed Printers
            foreach (var printer in printlib.GetListOfPrinters())
            {
                PrinterList.Add(printer);
            }

            // Set Default Printer to selected
            SelectedPrinter = printlib.GetDefaultPrinterIndex();
        }

        public void Print()
        {
            CalendarPrintOnlyView testVidual = new CalendarPrintOnlyView();

            printlib.Print(testVidual, "Calendar for Child App");
        }
    }
}
