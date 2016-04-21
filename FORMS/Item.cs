namespace FORMS {
  /// <summary>
  /// Содержит описание элементов новостей канала
  /// </summary>
  internal class Item: BaseItem {
    /// <summary>
    /// Создает объект элемента новости
    /// </summary>
    /// <param name="title">Заголовок</param>
    /// <param name="link">Адресс публикации</param>
    /// <param name="description">Описание</param>
    /// <param name="guid">Уникальный идентификатор</param>
    /// <param name="date">Дата публикации</param>
    /// <param name="imageUrl">Адресс изображения</param>
    public Item(string title, string link, string description, string guid, string date, string imageUrl): base(title, link, description) {
      Guid = guid;
      Date = date;
      Image = imageUrl;
    }
    /// <summary>
    /// Адресс изображения
    /// </summary>
    public string Image { get; }
    /// <summary>
    /// Уникальный идентификатор
    /// </summary>
    public string Guid { get; }
    /// <summary>
    /// Дата публикации
    /// </summary>
    public string Date { get; }
  }
}
