using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMS {
  public sealed partial class OpenUrlForm : Form {
    public OpenUrlForm(string title) {
      this.Text = title;
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      string responce = null;
      if (url.Text != string.Empty)
        responce = Controller.ParseChannel(url.Text);
      if (responce == null)
        Close();
      else url.Text = responce;
    }
  }
}
