using Jira_Monitor_Client.Properties;
using Library;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jira_Monitor_Client
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      using (var db = new LiteDatabase(@"Local.db"))
      {
        var SyncFileCollection = db.GetCollection<Alerta>();

        alertaBindingSource.DataSource = SyncFileCollection.FindAll().ToList();
      }
    }

    private void saveToolStripButton_Click(object sender, EventArgs e)
    {
      using (var db = new LiteDatabase(@"Local.db"))
      {
        db.DropCollection(nameof(Alerta));

        var SyncFileCollection = db.GetCollection<Alerta>();

        List<Alerta> lista = alertaBindingSource.DataSource as List<Alerta>;

        SyncFileCollection.InsertBulk(lista.FindAll(x => !string.IsNullOrEmpty(x.NomeFiltro)));
      }

      MessageBox.Show("Registros salvos!");
    }

    private void btnConfig_Click(object sender, EventArgs e)
    {
      using (ConfigForm config = new ConfigForm())
      {
        config.ShowDialog();
      }
    }

    private void btnFechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private async void btnNotify_Click(object sender, EventArgs e)
    {
      Monitor monitor = new Monitor();
      monitor.UserName = Settings.Default.UserName;
      monitor.Password = Settings.Default.Password;

      string LocalDB = $@"{Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)}\Local.db";

      using (var db = new LiteDatabase($@"Filename={LocalDB}; Connection=shared"))
      {
        var SyncFileCollection = db.GetCollection<Alerta>();

        var alertas = SyncFileCollection.FindAll().ToList();

        await monitor.Notify(alertas);

        db.DropCollection(nameof(Alerta));
        SyncFileCollection.InsertBulk(alertas);
      }

      MessageBox.Show("Verificação concluída!");
    }
  }
}
