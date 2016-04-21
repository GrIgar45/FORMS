namespace FORMS {
  partial class MainForm {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent() {
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.открытьURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.splitContainerChild = new System.Windows.Forms.SplitContainer();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.listItems = new System.Windows.Forms.ListBox();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.link = new System.Windows.Forms.LinkLabel();
      this.descriptionText = new System.Windows.Forms.TextBox();
      this.itemBox = new System.Windows.Forms.PictureBox();
      this.ListURL = new System.Windows.Forms.ListBox();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerChild)).BeginInit();
      this.splitContainerChild.Panel1.SuspendLayout();
      this.splitContainerChild.Panel2.SuspendLayout();
      this.splitContainerChild.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemBox)).BeginInit();
      this.SuspendLayout();
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 351);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(754, 22);
      this.statusStrip1.TabIndex = 0;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.справкаToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(754, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьURLToolStripMenuItem,
            this.toolStripSeparator1,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // открытьURLToolStripMenuItem
      // 
      this.открытьURLToolStripMenuItem.Name = "открытьURLToolStripMenuItem";
      this.открытьURLToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.открытьURLToolStripMenuItem.Text = "Добавить канал";
      this.открытьURLToolStripMenuItem.Click += new System.EventHandler(this.OpenUrl);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
      // 
      // сохранитьToolStripMenuItem
      // 
      this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
      this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.сохранитьToolStripMenuItem.Text = "Сохранить";
      // 
      // сохранитьКакToolStripMenuItem
      // 
      this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
      this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
      this.выходToolStripMenuItem.Text = "Выход";
      // 
      // видToolStripMenuItem
      // 
      this.видToolStripMenuItem.Name = "видToolStripMenuItem";
      this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.видToolStripMenuItem.Text = "Вид";
      // 
      // поискToolStripMenuItem
      // 
      this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
      this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.поискToolStripMenuItem.Text = "Поиск";
      // 
      // справкаToolStripMenuItem
      // 
      this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
      this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
      this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
      this.справкаToolStripMenuItem.Text = "Справка";
      // 
      // оПрограммеToolStripMenuItem
      // 
      this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
      this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
      this.оПрограммеToolStripMenuItem.Text = "О программе";
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
      this.splitContainerMain.Name = "splitContainerMain";
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.BackColor = System.Drawing.SystemColors.Window;
      this.splitContainerMain.Panel1.Controls.Add(this.ListURL);
      this.splitContainerMain.Panel1MinSize = 100;
      // 
      // splitContainerMain.Panel2
      // 
      this.splitContainerMain.Panel2.Controls.Add(this.splitContainerChild);
      this.splitContainerMain.Size = new System.Drawing.Size(754, 327);
      this.splitContainerMain.SplitterDistance = 130;
      this.splitContainerMain.SplitterWidth = 2;
      this.splitContainerMain.TabIndex = 2;
      this.splitContainerMain.TabStop = false;
      // 
      // splitContainerChild
      // 
      this.splitContainerChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainerChild.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerChild.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.splitContainerChild.Location = new System.Drawing.Point(0, 0);
      this.splitContainerChild.Name = "splitContainerChild";
      this.splitContainerChild.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerChild.Panel1
      // 
      this.splitContainerChild.Panel1.BackColor = System.Drawing.SystemColors.Window;
      this.splitContainerChild.Panel1.Controls.Add(this.pictureBox2);
      this.splitContainerChild.Panel1.Controls.Add(this.listItems);
      // 
      // splitContainerChild.Panel2
      // 
      this.splitContainerChild.Panel2.Controls.Add(this.splitter1);
      this.splitContainerChild.Panel2.Controls.Add(this.link);
      this.splitContainerChild.Panel2.Controls.Add(this.descriptionText);
      this.splitContainerChild.Panel2.Controls.Add(this.itemBox);
      this.splitContainerChild.Panel2MinSize = 124;
      this.splitContainerChild.Size = new System.Drawing.Size(622, 327);
      this.splitContainerChild.SplitterDistance = 198;
      this.splitContainerChild.TabIndex = 0;
      this.splitContainerChild.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
      this.pictureBox2.Location = new System.Drawing.Point(0, 0);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(620, 0);
      this.pictureBox2.TabIndex = 1;
      this.pictureBox2.TabStop = false;
      // 
      // listItems
      // 
      this.listItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listItems.DisplayMember = "Title";
      this.listItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listItems.FormattingEnabled = true;
      this.listItems.Location = new System.Drawing.Point(0, 0);
      this.listItems.Name = "listItems";
      this.listItems.Size = new System.Drawing.Size(620, 196);
      this.listItems.TabIndex = 0;
      this.listItems.Click += new System.EventHandler(this.listItems_Click);
      // 
      // splitter1
      // 
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(0, 107);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(620, 3);
      this.splitter1.TabIndex = 3;
      this.splitter1.TabStop = false;
      // 
      // link
      // 
      this.link.AutoSize = true;
      this.link.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.link.Location = new System.Drawing.Point(0, 110);
      this.link.Name = "link";
      this.link.Size = new System.Drawing.Size(0, 13);
      this.link.TabIndex = 2;
      // 
      // descriptionText
      // 
      this.descriptionText.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.descriptionText.Dock = System.Windows.Forms.DockStyle.Top;
      this.descriptionText.Location = new System.Drawing.Point(0, 0);
      this.descriptionText.Multiline = true;
      this.descriptionText.Name = "descriptionText";
      this.descriptionText.ReadOnly = true;
      this.descriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.descriptionText.Size = new System.Drawing.Size(620, 107);
      this.descriptionText.TabIndex = 1;
      // 
      // itemBox
      // 
      this.itemBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.itemBox.Dock = System.Windows.Forms.DockStyle.Left;
      this.itemBox.Location = new System.Drawing.Point(0, 0);
      this.itemBox.Name = "itemBox";
      this.itemBox.Size = new System.Drawing.Size(0, 123);
      this.itemBox.TabIndex = 0;
      this.itemBox.TabStop = false;
      // 
      // ListURL
      // 
      this.ListURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ListURL.DisplayMember = "Title";
      this.ListURL.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListURL.FormattingEnabled = true;
      this.ListURL.Location = new System.Drawing.Point(0, 0);
      this.ListURL.Name = "ListURL";
      this.ListURL.Size = new System.Drawing.Size(128, 325);
      this.ListURL.TabIndex = 0;
      this.ListURL.DoubleClick += new System.EventHandler(this.ListURL_DoubleClick);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(754, 373);
      this.Controls.Add(this.splitContainerMain);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      this.splitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.splitContainerChild.Panel1.ResumeLayout(false);
      this.splitContainerChild.Panel2.ResumeLayout(false);
      this.splitContainerChild.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerChild)).EndInit();
      this.splitContainerChild.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem открытьURLToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.SplitContainer splitContainerChild;
    private System.Windows.Forms.ListBox listItems;
    private System.Windows.Forms.PictureBox itemBox;
    private System.Windows.Forms.LinkLabel link;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.TextBox descriptionText;
    private System.Windows.Forms.ListBox ListURL;
  }
}

