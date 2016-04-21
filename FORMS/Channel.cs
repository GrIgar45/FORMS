using System.Collections.Generic;
using System.ComponentModel;

namespace FORMS {
  internal class Channel {
    private readonly BindingList<Item> _items;

    public Channel(RssImage image, string link, string description, string title, BindingList<Item> items, string path) {
      Image = image;
      Description = description;
      Title = title;
      _items = items;
      Path = path;
      Link = link;
    }
    
    public string Path { get; }

    public string Title { get; }

    public RssImage Image { get; }

    public string Link { get; }

    public string Description { get; }

    public BindingList<Item> GetItems() => _items;
  }
}
