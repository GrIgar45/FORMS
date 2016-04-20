using System.Collections;
using System.Windows.Forms;

namespace FORMS {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }

    private void OpenUrl(object sender, System.EventArgs e) {
      var f = new OpenUrlForm("Открыть по ссылке");
      f.ShowDialog();
    }
  }
}
