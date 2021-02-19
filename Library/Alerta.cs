using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  public class Alerta
  {
    public Alerta()
    {
      IssuesNotificadas = new List<string>();
    }

    public string Nome { get; set; }

    public string NomeFiltro { get; set; }

    public string TituloNotificacao { get; set; }

    public string Dashboard { get; set; }

    public string Sala { get; set; }

    public string Icone { get; set; }

    public List<string> IssuesNotificadas { get; set; }
  }
}