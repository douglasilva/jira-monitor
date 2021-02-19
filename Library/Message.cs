using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
  public class Rootobject
  {
    public List<Card> cards { get; set; }
  }

  public class Card
  {
    public Header header { get; set; }
    public List<Section> sections { get; set; }
  }

  public class Header
  {
    public string title { get; set; }
    public string subtitle { get; set; }
    public string imageUrl { get; set; }
  }

  public class Section
  {
    public List<Widget> widgets { get; set; }
  }

  public class Widget
  {
    public Keyvalue keyValue { get; set; }
    public List<Button> buttons { get; set; }
  }

  public class Keyvalue
  {
    public string topLabel { get; set; }
    public string content { get; set; }
    public bool contentMultiline { get; set; }
    public string bottomLabel { get; set; }


  }

  public class Button
  {
    public Textbutton textButton { get; set; }
  }

  public class Textbutton
  {
    public string text { get; set; }
    public Onclick onClick { get; set; }
  }

  public class Onclick
  {
    public Openlink openLink { get; set; }
  }

  public class Openlink
  {
    public string url { get; set; }
  }

}
