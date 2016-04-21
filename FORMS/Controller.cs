using System.ComponentModel;
using System.Xml;

namespace FORMS {
  internal static class Controller {
    private static BindingList<Channel> _channels = new BindingList<Channel>();
    private static BindingList<Item> _currentItem;

    internal static BindingList<Channel> Channels => _channels;

    public static bool ContaineTitle(string title) {
      foreach (var channel in _channels) {
        if (channel.Title == title)
          return true;
      }
      return false;
    }

    public static BindingList<Item> GetItems(int id) => _currentItem = _channels[id].GetItems();

    public static Item GeItem(int id) => _currentItem[id];

    public static string ParseChannel(string url) {
      var rssDocument = new XmlDocument();
      try {
        rssDocument.Load(url);
      }
      catch {
        return "Не удалось загрузить документ.";
      }

      var node = rssDocument.SelectSingleNode("rss/channel") as XmlElement;

      if (node == null) 
        return "Файл имеет недопустимый формат.";

      var title = node["title"].InnerText;
      var link = node["link"].InnerText;
      var description = node["description"].InnerText;

      var imgNode = node["image"];
      RssImage image = null;
      if (imgNode != null) 
        image = new RssImage(
          imgNode["url"].InnerText,
          imgNode["link"].InnerText,
          imgNode["title"].InnerText);

      var rssNodes = rssDocument.SelectNodes("rss/channel/item");
      
      var items = new BindingList<Item>();
      foreach (XmlNode nd in rssNodes) {
        string imgUrl = nd["enclosure"]?.GetAttribute("url");
        items.Add(new Item(
          nd["title"].InnerText,
          nd["link"].InnerText,
          nd["description"].InnerText,
          nd["guid"].InnerText,
          nd["pubDate"].InnerText,
          imgUrl));
      }

      _channels.Add(new Channel(image, link, description, title, items, url));
      return null;
    }
  }
}
