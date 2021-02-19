using Library;
using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Jira_Monitor
{
  public partial class Service1 : ServiceBase
  {
    Timer timer = new Timer();
    string LocalDB = string.Empty;

    public Service1()
    {
      InitializeComponent();
    }

    protected override void OnStart(string[] args)
    {
      LocalDB = $@"{Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)}\Local.db";

      timer.Interval = Properties.Settings.Default.Tempo;
      timer.Elapsed += new ElapsedEventHandler(this.OnTimer);
      timer.Start();
    }

    private async void OnTimer(object sender, ElapsedEventArgs e)
    {
      await Monitor();
    }

    private async Task Monitor()
    {
      Monitor monitor = new Monitor
      {
        UserName = Properties.Settings.Default.Username,
        Password = Properties.Settings.Default.Password
      };

      try
      {
        
        using (var db = new LiteDatabase($@"Filename={LocalDB}; Connection=shared"))
        {
          var SyncFileCollection = db.GetCollection<Alerta>();

          var alertas = SyncFileCollection.FindAll().ToList();

          await monitor.Notify(alertas);

          db.DropCollection(nameof(Alerta));
          SyncFileCollection.InsertBulk(alertas);
        }
      }
      catch (AggregateException ex)
      {
        throw ex.Flatten();
      }
      catch (Exception)
      {
        throw;
      }
    }

    protected override void OnStop()
    {
      timer.Stop();
    }
  }
}
