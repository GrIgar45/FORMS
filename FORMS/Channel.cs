using System.Collections.Generic;
using static System.Windows.Forms.LinkLabel;

namespace FORMS {
  internal class Channel {
    private readonly List<Item> _items;

    public Channel(RssImage image, string link, string description, string title, List<Item> items) {
      Image = image;
      Description = description;
      Title = title;
      _items = items;
      Link.Description = link;
    }

    public string Title { get; }

    public RssImage Image { get; }

    public Link Link { get; }

    public string Description { get; }

    public List<Item> GetItems() => _items;
  }
}
