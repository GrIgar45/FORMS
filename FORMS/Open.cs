using System;
using System.Windows.Forms;

namespace FORMS {
  public sealed partial class OpenUrlForm : Form {
    public OpenUrlForm() {
      InitializeComponent();
    }

    /// <summary>
    /// Открытие rss канала по адресу
    /// </summary>
    /// <param name="sender" />
    /// <param name="e" />
    private void button1_Click(object sender, EventArgs e) {
      string responce = null;
      if (url.Text != string.Empty)
        responce = Controller.ParseChannel(url.Text);
      if (responce == null && !multipleValue.Checked)
        Close();
      else if(!multipleValue.Checked)
        MessageBox.Show(responce, @"Ошибка");
    }
  }
}
