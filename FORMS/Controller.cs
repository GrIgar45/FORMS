using System;
using System.ComponentModel;
using System.Xml;
using System.IO;
using System.Linq;
using System.Text;

namespace FORMS {
  /// <summary>
  /// Упраление и хранение коллекции каналов
  /// </summary>
  internal static class Controller {
    private static BindingList<Channel> _channels = new BindingList<Channel>();

    /// <summary>
    /// Коллекция каналов
    /// </summary>
    internal static BindingList<Channel> Channels => _channels;

    /// <summary>
    /// Выполяет загрузку канала по адрессу
    /// </summary>
    /// <param name="url">Адресс канала</param>
    /// <returns>Результат</returns>
    public static string ParseChannel(string url) {
      if (ContaineSamePath(url)) 
        return "Уже есть лента с таким адрессом";
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

      var title = node["title"]?.InnerText;
      var link = node["link"]?.InnerText;
      var description = node["description"]?.InnerText;

      var imgNode = node["image"];
      RssImage image = null;
      if (imgNode != null)
        image = new RssImage(
          imgNode["url"]?.InnerText,
          imgNode["link"]?.InnerText,
          imgNode["title"]?.InnerText);

      var rssNodes = rssDocument.SelectNodes("rss/channel/item");

      var items = new BindingList<Item>();
      if (rssNodes != null)
        foreach (XmlNode nd in rssNodes) {
          var imgUrl = nd["enclosure"]?.GetAttribute("url");
          items.Add(new Item(
            nd["title"]?.InnerText,
            nd["link"]?.InnerText,
            nd["description"]?.InnerText,
            nd["guid"]?.InnerText,
            nd["pubDate"]?.InnerText,
            imgUrl));
        }

      _channels.Add(new Channel(image, link, title, description, items, url));
      return null;
    }

    private static bool ContaineSamePath(string url) {
      foreach (var channel in _channels) {
        if (channel.Path == url)
          return true;
      }
      return false;
    }

    /// <summary>
    /// Выполняет обновление каналов лент
    /// </summary>
    public static void Refresh() {
      var channels = _channels;
      _channels = new BindingList<Channel>();
      foreach (var channel in channels) {
        ParseChannel(channel.Path);
      }
    }

    public static void RemoveChannel(int id) {
      _channels.Remove(_channels[id]);
    }

    public static bool Search(string keyWord) {
      keyWord = keyWord.ToLower();
      var sResItem = new BindingList<Item>();
      foreach (var channel in _channels) {
        foreach (var item in channel.GetItems()) {
          if (item.Title.ToLower().Contains(keyWord) || item.Description.ToLower().Contains(keyWord))
            sResItem.Add(item);
        }
      }
      if (sResItem.Count == 0)
        return false;
      _channels.Add(new Channel(null, string.Empty, $"Результаты посика {keyWord}", string.Empty, sResItem, string.Empty));
      return true;
    }

    public static void SaveSession() {
      var stringBuilder = new StringBuilder(100);
      foreach (var channel in _channels) {
        stringBuilder.AppendLine(channel.Path);
      }
      File.WriteAllText("Session.dat", stringBuilder.ToString());
    }

    public static void LoadSession() {
      var ways = File.ReadAllLines("Session.dat");
      foreach (var way in ways) {
        ParseChannel(way);
      }
    }
  }
}