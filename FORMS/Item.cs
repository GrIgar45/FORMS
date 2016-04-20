namespace FORMS {
  internal class Item {
    public Item(string title, string link, string description, string guid, string date) {
      Title = title;
      Link = link;
      Description = description;
      Guid = guid;
      Date = date;
    }

    public string Title { get; }

    public string Link { get; }

    public string Description { get; }

    public string Guid { get; }

    public string Date { get; }
  }
}
