using System.Net;
using System.Drawing;

namespace FORMS {
  internal class RssImage {
    public Bitmap Image { get; private set; }

    public string Link { get; }

    public string Title { get; }

    public string Url { get; }

    public RssImage(string link) {
      GetBitmap(link);
    }

    public RssImage(string url, string link, string title) {
      Url = url;
      Link = link;
      Title = title;
      Image = GetBitmap(url);
    }

    public static Bitmap GetBitmap(string url) {
      Bitmap bm = null;
      try {
      var wreq = WebRequest.Create(url) as HttpWebRequest;
        if (wreq == null) return null;
        using (var wresp = wreq.GetResponse() as HttpWebResponse) {
          using (var stream = wresp.GetResponseStream())
            if (stream != null)
              bm = new Bitmap(stream);
        }
      }
      catch {
        return null;
      }
      return bm;
    }
  }
}

