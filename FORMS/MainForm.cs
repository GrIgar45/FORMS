using System.Drawing;
using System.Windows.Forms;

namespace FORMS {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }

    private void OpenUrl(object sender, System.EventArgs e) {
      var f = new OpenUrlForm();
      f.ShowDialog();
      ListURL.DataSource = Controller.Channels;
    }

    private void ListURL_DoubleClick(object sender, System.EventArgs e) {
      if (ListURL.Items.Count != 0)
        listItems.DataSource = Controller.GetItems(ListURL.SelectedIndex);
    }

    private void listItems_Click(object sender, System.EventArgs e) {
      Item item;
      if(listItems.Items.Count != 0)
        item = Controller.GeItem(listItems.SelectedIndex);
      else {
        return;
      }
      var bm = RssImage.GetBitmap(item.Image);
      if (bm != null) {
        itemBox.BackgroundImage = bm;
        float ratio = (float) itemBox.Height/bm.Height;
        itemBox.Width = (int) (bm.Width*ratio);
      }
    }
  }
}
