using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FORMS {
  class BaseItem {
    public BaseItem(string title, string link, string description) {
      Title = title;
      Link = link;
      Description = description;
    }

    public string Title { get; }

    public string Link { get; }

    public string Description { get; }

  }
}
