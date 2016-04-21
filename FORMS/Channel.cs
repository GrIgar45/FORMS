using System.ComponentModel;

namespace FORMS {
  /// <summary>
  /// Содержит описание канала
  /// </summary>
  internal class Channel: BaseItem {
    private readonly BindingList<Item> _items;
    /// <summary>
    /// Создает объект канала
    /// </summary>
    /// <param name="containeImg">Изображение логотипа канала</param>
    /// <param name="link">Адресс на сайт канала</param>
    /// <param name="description">Описание</param>
    /// <param name="title">Название канала</param>
    /// <param name="items">Коллекция элементов новостей</param>
    /// <param name="path">Путь к каналу</param>
    public Channel(RssImage containeImg, string link, string title, string description, BindingList<Item> items, string path): base(title, link, description) {
      ContaineImg = containeImg;
      _items = items;
      Path = path;
    }
    /// <summary>
    /// Путь к каналу
    /// </summary>
    public string Path { get; }
    /// <summary>
    /// Изображение логотипа канала
    /// </summary>
    public RssImage ContaineImg { get; }
    /// <summary>
    /// Возвращает коллекцию элементов новостей
    /// </summary>
    /// <returns>Коллекция новостей</returns>
    public BindingList<Item> GetItems() => _items;
  }
}
