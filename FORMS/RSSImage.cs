using System.Net;
using System.Drawing;

namespace FORMS {
  internal class RssImage {
    public Bitmap Image { get; private set; }

    public string Link { get; }

    public string Title { get; }

    public string Url { get; }

    public RssImage(string url, string title, string link) {
      Url = url;
      Title = title;
      Link = link;
      GetBitmap(url);
    }

    private void GetBitmap(string url) {
      var wreq = WebRequest.Create(url) as HttpWebRequest;
      try {
        if (wreq == null) return;
        using (var wresp = wreq.GetResponse() as HttpWebResponse) {
          using (var stream = wresp.GetResponseStream())
            if (stream != null)
              Image = new Bitmap(stream);
        }
      }
      catch {
        // ignored
      }
    }
  }
}

