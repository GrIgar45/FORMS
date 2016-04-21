namespace FORMS {
  internal class Item {
    public Item(string title, string link, string description, string guid, string date, string imageUrl) {
      Title = title;
      Link = link;
      Description = description;
      Guid = guid;
      Date = date;
      Image = imageUrl;
    }

    public string Image { get; }

    public string Title { get; }

    public string Link { get; }

    public string Description { get; }

    public string Guid { get; }

    public string Date { get; }
  }
}
