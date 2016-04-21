﻿using System.ComponentModel;
using System.Xml;

namespace FORMS {
  /// <summary>
  /// Упраление и хранение коллекции каналов
  /// </summary>
  internal static class Controller {
    private static BindingList<Channel> _channels = new BindingList<Channel>();
    //private static BindingList<Item> _currentItem;

    /// <summary>
    /// Коллекция каналов
    /// </summary>
    internal static BindingList<Channel> Channels => _channels;

    ///// <summary>
    ///// Возвращает коллекцию эелементов новостей по индексу в коллекции каналов
    ///// </summary>
    ///// <param name="id">Индекс коллекции элементов новостей</param>
    ///// <returns>Коллекция элементов новостей</returns>
    //public static BindingList<Item> GetItems(int id) => _currentItem = _channels[id].GetItems();

    ///// <summary>
    ///// Возвращает элемент новости
    ///// </summary>
    ///// <param name="id">Индекс элемента новости</param>
    ///// <returns>Элемент новости</returns>
    //public static Item GeItem(int id) => _currentItem[id];

    /// <summary>
    /// Выполяет загрузку канала по адрессу
    /// </summary>
    /// <param name="url">Адресс канала</param>
    /// <returns>Результат</returns>
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

      _channels.Add(new Channel(image, link, title, description, items, url));
      return null;
    }
    /// <summary>
    /// Выполняет обновление каналов лент
    /// </summary>
    public static void Refresh() {
      BindingList<Channel> channels = _channels;
      _channels = new BindingList<Channel>();
      foreach (Channel channel in channels) {
        ParseChannel(channel.Path);
      }
    }
  }
}