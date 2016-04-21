using System.ComponentModel;

namespace FORMS {
  internal class Channel: BaseItem {
    private readonly BindingList<Item> _items;

    public Channel(RssImage containeImg, string link, string description, string title, BindingList<Item> items, string path): base(title, link, description) {
      ContaineImg = containeImg;
      _items = items;
      Path = path;
    }
    
    public string Path { get; }
    
    public RssImage ContaineImg { get; }
    
    public BindingList<Item> GetItems() => _items;
  }
}
