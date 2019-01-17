using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pomoc_aplikacije
{
    public class Pomoc
    {
        public static void PrikaziPomoc(Form forma)
        {
            Help.ShowHelp(forma, AppDomain.CurrentDomain.BaseDirectory + "Pomoc.chm", HelpNavigator.Topic, forma.Name + ".htm");
        }
    }
}
