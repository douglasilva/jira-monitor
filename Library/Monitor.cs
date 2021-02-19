using Atlassian.Jira;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using JiraSDK = Atlassian.Jira;

namespace Library
{
  public class Monitor
  {
    public const string JIRA_URL = "https://URLJIRA";

    public string UserName { get; set; }

    public string Password { get; set; }

    public async Task Notify(List<Alerta> alertas)
    {
      if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password))
        throw new Exception("Usuário e/ou senha não informado!");

      var jira = JiraSDK.Jira.CreateRestClient(JIRA_URL, UserName, Password);

      jira.RestClient.RestSharpClient.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36";
      jira.RestClient.RestSharpClient.DefaultParameters.Add(new RestSharp.Parameter("Content-Type", "application/json; charset=UTF-8", RestSharp.ParameterType.HttpHeader));
      jira.RestClient.RestSharpClient.DefaultParameters.Add(new RestSharp.Parameter("X-Atlassian-Token", "no-check", RestSharp.ParameterType.HttpHeader));
      jira.RestClient.RestSharpClient.DefaultParameters.Add(new RestSharp.Parameter("Origin", JIRA_URL, RestSharp.ParameterType.HttpHeader));

      foreach (var alerta in alertas)
      {
        if (!string.IsNullOrEmpty(alerta.NomeFiltro))
        {
          var issuesFiltro = await jira.Filters.GetIssuesFromFavoriteAsync(alerta.NomeFiltro, 100, 0);

          using (var clientChat = new HttpClient())
          {
            foreach (var issue in issuesFiltro.ToList())
            {
              if (!alerta.IssuesNotificadas.Contains(issue.Key.Value))
              {
                Card card = new Card();
                card.header = new Header();
                card.header.title = alerta.TituloNotificacao;
                card.header.subtitle = issue.Key.Value;
                card.header.imageUrl = alerta.Icone;

                Section section = new Section();
                section.widgets = new List<Widget>();

                Widget titulo = new Widget();
                titulo.keyValue = new Keyvalue();
                titulo.keyValue.topLabel = "Título";
                titulo.keyValue.content = issue.Summary;
                titulo.keyValue.contentMultiline = true;

                section.widgets.Add(titulo);

                CustomFieldValue ClienteCustomField = issue.CustomFields.FirstOrDefault(reg => reg.Id == "customfield_11071");

                if (ClienteCustomField != null)
                {
                  Widget nomeCliente = new Widget();
                  nomeCliente.keyValue = new Keyvalue();
                  nomeCliente.keyValue.topLabel = "Cliente";
                  nomeCliente.keyValue.content = ClienteCustomField.Values.FirstOrDefault();

                  section.widgets.Add(nomeCliente);
                }

                Widget criticidade = new Widget();
                criticidade.keyValue = new Keyvalue();
                criticidade.keyValue.topLabel = "Criticidade";
                criticidade.keyValue.content = issue.Priority.Name;

                section.widgets.Add(criticidade);

                CustomFieldValue dataSLACustomField = issue.CustomFields.FirstOrDefault(reg => reg.Id == "customfield_11080");

                if (dataSLACustomField != null)
                {
                  Widget dataSLA = new Widget();
                  dataSLA.keyValue = new Keyvalue();
                  dataSLA.keyValue.topLabel = "Data de SLA";
                  dataSLA.keyValue.content = dataSLACustomField.Values.FirstOrDefault();

                  section.widgets.Add(dataSLA);
                }
                                
                card.sections = new List<Section>();
                card.sections.Add(section);

                Widget botoes = new Widget();
                botoes.buttons = new List<Button>();

                Button abrirJiraBotao = new Button();
                abrirJiraBotao.textButton = new Textbutton();
                abrirJiraBotao.textButton.text = "Ver no Jira"; ;
                abrirJiraBotao.textButton.onClick = new Onclick();
                abrirJiraBotao.textButton.onClick.openLink = new Openlink();
                abrirJiraBotao.textButton.onClick.openLink.url = $"{JIRA_URL}/browse/{issue.Key}";
                botoes.buttons.Add(abrirJiraBotao);

                Button abrirDashJiraBotao = new Button();
                abrirDashJiraBotao.textButton = new Textbutton();
                abrirDashJiraBotao.textButton.text = "Ver Dashboard"; ;
                abrirDashJiraBotao.textButton.onClick = new Onclick();
                abrirDashJiraBotao.textButton.onClick.openLink = new Openlink();
                abrirDashJiraBotao.textButton.onClick.openLink.url = alerta.Dashboard;
                botoes.buttons.Add(abrirDashJiraBotao);

                section.widgets.Add(botoes);

                Rootobject mensagem = new Rootobject();
                mensagem.cards = new List<Card>();
                mensagem.cards.Add(card);

                var jsonContent = JsonConvert.SerializeObject(mensagem);

                var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                await clientChat.PostAsync(alerta.Sala, contentString);

                alerta.IssuesNotificadas.Add(issue.Key.Value);
              }
            }
          }
        }
      }
    }
  }
}