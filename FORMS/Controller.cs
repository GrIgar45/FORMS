using System;
using System.Collections.Generic;
using System.Xml;

namespace FORMS {
  internal static class Controller {
    private static List<Channel> _channels;



    public static string ParseChannel(string url) {
      var rssDocument = new XmlDocument();
      try {
        rssDocument.Load(url);
      }
      catch (NotSupportedException) {
        return "Файл имеет недопустимый формат.";
      }
      catch {
        return "Не удалось загрузить документ.";
      }

      var node = rssDocument.SelectSingleNode("rss/channel") as XmlElement;
      if (node == null) 
        return "Неверный формат файла.";
      var title = node["title"].InnerText;
      var link = node["link"].InnerText;
      var description = node["description"].InnerText;

      var imgNode = node["image"];
      RssImage image = null;
      if (imgNode != null) {
        image = new RssImage(
          imgNode["url"].InnerText,
          imgNode["link"].InnerText,
          imgNode["title"].InnerText);
      }

      var rssNodes = rssDocument.SelectNodes("rss/channel/item");
      var items = new List<Item>(rssNodes.Count);
      foreach (XmlNode nd in rssNodes) {
        items.Add(new Item(nd["title"].InnerText, nd["link"].InnerText, nd["description"].InnerText,
          nd["guid"].InnerText, nd["pubDate"].InnerText));
      }

      _channels.Add(new Channel(image, link, description, title, items));
      return null;
    }
  }
}
