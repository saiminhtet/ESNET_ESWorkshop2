using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esnet_efworkshop02
{
    class TestForm
    {
        public static void TestMethod()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormIssueTranWorkshop());
            
            Environment.Exit(0);
        }
    }
}
