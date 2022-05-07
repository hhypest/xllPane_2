using ExcelDna.Integration;
using ExcelDna.IntelliSense;

namespace xllPane_2
{
    public class IntelliServ : IExcelAddIn
    {
        public void AutoClose()
        {
            IntelliSenseServer.Uninstall();
        }

        public void AutoOpen()
        {
            IntelliSenseServer.Install();
        }
    }
}