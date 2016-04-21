namespace FORMS {
  internal class Item: BaseItem {
    public Item(string title, string link, string description, string guid, string date, string imageUrl): base(title, link, description) {
      Guid = guid;
      Date = date;
      Image = imageUrl;
    }

    public string Image { get; }

    public string Guid { get; }

    public string Date { get; }
  }
}
