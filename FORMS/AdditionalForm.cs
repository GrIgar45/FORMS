using System;
using System.Windows.Forms;

namespace FORMS {
  public sealed partial class AdditionalForm : Form {
    public AdditionalForm(string title, string btnTitle , bool enblChkBx) {
      InitializeComponent();
      Text = title;
      button1.Text = btnTitle;
      multipleValue.Visible = enblChkBx;
      if (enblChkBx) {
        button1.Click += button1_Click;
      }
      else {
        button1.Click += button1_Click2;
      }
    }

    /// <summary>
    /// Открытие rss канала по адресу
    /// </summary>
    private void button1_Click(object sender, EventArgs e) {
      string responce = null;
      if (textBox.Text != string.Empty)
        responce = Controller.ParseChannel(textBox.Text);
      if (responce == null && !multipleValue.Checked)
        Close();
      else if(!multipleValue.Checked)
        MessageBox.Show(responce, @"Ошибка");
    }
    /// <summary>
    /// Поиск по ключевому слову
    /// </summary>
    private void button1_Click2(object sender, EventArgs e) {
      var res = Controller.Search(textBox.Text);
      if (res == false) {
        MessageBox.Show(@"Ничего не найдено", @"Информация");
      }
      else {
        Close();
      }
    }
  }
}
