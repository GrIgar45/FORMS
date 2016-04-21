namespace FORMS {
  /// <summary>
  /// Родительский класс с общими полями для Item и Channel
  /// </summary>
  abstract class BaseItem {
    protected BaseItem(string title, string link, string description) {
      Title = title;
      Link = link;
      Description = description;
    }
    /// <summary>
    /// Заголовок
    /// </summary>
    public string Title { get; }
    /// <summary>
    /// Адрес
    /// </summary>
    public string Link { get; }
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; }

  }
}
