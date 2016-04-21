using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace FORMS {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }

    /// <summary>
    /// Выполняет отображение формы открытия файла
    /// </summary>
    private void OpenUrl(object sender, System.EventArgs e) {
      var f = new OpenUrlForm();
      f.ShowDialog();
      ListURL.DataSource = Controller.Channels;
    }
    /// <summary>
    /// Выполняет отображение списка новостей
    /// </summary>
    private void ListURL_DoubleClick(object sender, System.EventArgs e) {
      Channel channel;
      if (ListURL.Items.Count == 0) {
        return;
      }
      listItems.DataSource = Controller.Channels[ListURL.SelectedIndex].GetItems();
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
    /// <summary>
    /// Выполняет переход и источнику новости
    /// </summary>
    private void link_Click(object sender, System.EventArgs e) {
      Item item = Controller.Channels[ListURL.SelectedIndex].GetItems()[listItems.SelectedIndex];
      Process.Start(item.Link);
    }
    /// <summary>
    /// Выполняет отображение подробностей новости
    /// </summary>
    private void listItems_SelectedIndexChanged(object sender, EventArgs e) {
      Item item;
      if (ListURL.SelectedIndex == -1){
        itemBox.Width = 0;
        link.Text = string.Empty;
        description.Text = string.Empty;
        return;
      }
      item = Controller.Channels[ListURL.SelectedIndex].GetItems()[listItems.SelectedIndex];
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
    /// <summary>
    /// Скрывает боковую панель
    /// </summary>
    private void ViewChannel(object sender, EventArgs e) {
      splitContainerMain.Panel1Collapsed = !splitContainerMain.Panel1Collapsed;
    }
    /// <summary>
    /// Переход на домашнюю страницу сайта
    /// </summary>
    private void channelBox_Click(object sender, EventArgs e) {
      Process.Start(Controller.Channels[ListURL.SelectedIndex].ContaineImg.Link);
    }
    /// <summary>
    /// Показывет форму о программе
    /// </summary>
    private void ShowAbout(object sender, EventArgs e) {
      var f = new About();
      f.ShowDialog();
    }
    /// <summary>
    /// Вызывает метод обновление каналов
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RefreshChannel(object sender, EventArgs e) {
      Controller.Refresh();
      ListURL.ClearSelected();
      listItems.DataSource = null;
      listItems.DisplayMember = "Title";
    }
  }
}
