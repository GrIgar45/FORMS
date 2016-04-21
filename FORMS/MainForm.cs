using System;
using System.ComponentModel;
using System.Diagnostics;
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
      Channel channel;
      if (ListURL.Items.Count == 0) {
        return;
      }
      listItems.DataSource = Controller.GetItems(ListURL.SelectedIndex);
      channel = Controller.Channels[ListURL.SelectedIndex];
      if (channel.ContaineImg != null) {
        channelBox.BackgroundImage = channel.ContaineImg.Image;
        channelBox.Size = channel.ContaineImg.Image.Size;
        toolTip1.SetToolTip(channelBox, channel.Title);
      }
      else {
        channelBox.Height = 0;
      }
    }

    private void link_Click(object sender, System.EventArgs e) {
      Item item = Controller.GeItem(listItems.SelectedIndex);
      Process.Start(item.Link);
    }

    private void listItems_SelectedIndexChanged(object sender, EventArgs e) {
      Item item;
      if (listItems.Items.Count == 0){
        itemBox.Width = 0;
        link.Text = string.Empty;
        description.Text = string.Empty;
        return;
      }
      item = Controller.GeItem(listItems.SelectedIndex);
      var bm = RssImage.GetBitmap(item.Image);
      if (bm != null) {
        itemBox.BackgroundImage = bm;
        float ratio = (float)itemBox.Height / bm.Height;
        itemBox.Width = (int)(bm.Width * ratio);
      }
      else
        itemBox.Width = 0;

      description.Text = item.Description;
      DateTime dt = DateTime.Parse(item.Date);
      dateLabel.Text = dt.ToString();
      link.Text = @"Перейти к источнику";
    }

    private void ViewChannel(object sender, EventArgs e) {
      splitContainerMain.Panel1Collapsed = !splitContainerMain.Panel1Collapsed;
    }

    private void channelBox_Click(object sender, EventArgs e) {
      Process.Start(Controller.Channels[ListURL.SelectedIndex].ContaineImg.Link);
    }
  }
}
