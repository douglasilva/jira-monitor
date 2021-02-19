using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jira_Monitor_Client
{
  class Program
  {
    [STAThread]
    public static void Main()
    {
      Application.EnableVisualStyles();
      Application.Run(new MainForm());
    }
  }
}
