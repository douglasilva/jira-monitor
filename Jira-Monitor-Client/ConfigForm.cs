using Jira_Monitor_Client.Properties;
using System;
using System.Windows.Forms;

namespace Jira_Monitor_Client
{
  public partial class ConfigForm : Form
  {
    public ConfigForm()
    {
      InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      Settings.Default.Save();

    }

    private void btnCancelar_Click_1(object sender, EventArgs e)
    {
      Settings.Default.Reload();
    }
  }
}
