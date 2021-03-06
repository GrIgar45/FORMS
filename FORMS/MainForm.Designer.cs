﻿namespace FORMS {
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.OpenRSS = new System.Windows.Forms.ToolStripMenuItem();
      this.SearchButton = new System.Windows.Forms.ToolStripMenuItem();
      this.SaveSession = new System.Windows.Forms.ToolStripMenuItem();
      this.LoadSession = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ViewChannals = new System.Windows.Forms.ToolStripMenuItem();
      this.RefreshButton = new System.Windows.Forms.ToolStripMenuItem();
      this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.AboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.ListURL = new System.Windows.Forms.ListBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.AddChannel = new System.Windows.Forms.ToolStripMenuItem();
      this.removeChannel = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainerChild = new System.Windows.Forms.SplitContainer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.listItems = new System.Windows.Forms.ListBox();
      this.splitter2 = new System.Windows.Forms.Splitter();
      this.channelBox = new System.Windows.Forms.PictureBox();
      this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
      this.dateLabel = new System.Windows.Forms.Label();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.link = new System.Windows.Forms.LinkLabel();
      this.itemBox = new System.Windows.Forms.PictureBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerChild)).BeginInit();
      this.splitContainerChild.Panel1.SuspendLayout();
      this.splitContainerChild.Panel2.SuspendLayout();
      this.splitContainerChild.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.channelBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemBox)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(877, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenRSS,
            this.SearchButton,
            this.SaveSession,
            this.LoadSession,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // OpenRSS
      // 
      this.OpenRSS.Name = "OpenRSS";
      this.OpenRSS.Size = new System.Drawing.Size(176, 22);
      this.OpenRSS.Text = "Добавить канал";
      this.OpenRSS.Click += new System.EventHandler(this.OpenUrl);
      // 
      // SearchButton
      // 
      this.SearchButton.Name = "SearchButton";
      this.SearchButton.Size = new System.Drawing.Size(176, 22);
      this.SearchButton.Text = "Поиск";
      this.SearchButton.Click += new System.EventHandler(this.SearchMenu_Click);
      // 
      // SaveSession
      // 
      this.SaveSession.Name = "SaveSession";
      this.SaveSession.Size = new System.Drawing.Size(176, 22);
      this.SaveSession.Text = "Сохранить сессию";
      this.SaveSession.Click += new System.EventHandler(this.SaveSession_Click);
      // 
      // LoadSession
      // 
      this.LoadSession.Name = "LoadSession";
      this.LoadSession.Size = new System.Drawing.Size(176, 22);
      this.LoadSession.Text = "Загрузить сессию";
      this.LoadSession.Click += new System.EventHandler(this.LoadSession_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
      // 
      // выходToolStripMenuItem
      // 
      this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
      this.выходToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
      this.выходToolStripMenuItem.Text = "Выход";
      this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
      // 
      // видToolStripMenuItem
      // 
      this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewChannals,
            this.RefreshButton});
      this.видToolStripMenuItem.Name = "видToolStripMenuItem";
      this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.видToolStripMenuItem.Text = "Вид";
      // 
      // ViewChannals
      // 
      this.ViewChannals.Checked = true;
      this.ViewChannals.CheckOnClick = true;
      this.ViewChannals.CheckState = System.Windows.Forms.CheckState.Checked;
      this.ViewChannals.Name = "ViewChannals";
      this.ViewChannals.Size = new System.Drawing.Size(163, 22);
      this.ViewChannals.Text = "Список каналов";
      this.ViewChannals.CheckedChanged += new System.EventHandler(this.ViewChannel);
      // 
      // RefreshButton
      // 
      this.RefreshButton.Name = "RefreshButton";
      this.RefreshButton.Size = new System.Drawing.Size(163, 22);
      this.RefreshButton.Text = "Обновить";
      this.RefreshButton.Click += new System.EventHandler(this.RefreshChannel);
      // 
      // справкаToolStripMenuItem
      // 
      this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutAuthor});
      this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
      this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
      this.справкаToolStripMenuItem.Text = "Справка";
      // 
      // AboutAuthor
      // 
      this.AboutAuthor.Name = "AboutAuthor";
      this.AboutAuthor.Size = new System.Drawing.Size(149, 22);
      this.AboutAuthor.Text = "О программе";
      this.AboutAuthor.Click += new System.EventHandler(this.ShowAbout);
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
      this.splitContainerMain.Size = new System.Drawing.Size(877, 385);
      this.splitContainerMain.SplitterDistance = 130;
      this.splitContainerMain.SplitterWidth = 2;
      this.splitContainerMain.TabIndex = 2;
      this.splitContainerMain.TabStop = false;
      // 
      // ListURL
      // 
      this.ListURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.ListURL.ContextMenuStrip = this.contextMenuStrip1;
      this.ListURL.DisplayMember = "Title";
      this.ListURL.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ListURL.FormattingEnabled = true;
      this.ListURL.Location = new System.Drawing.Point(0, 0);
      this.ListURL.Name = "ListURL";
      this.ListURL.Size = new System.Drawing.Size(128, 383);
      this.ListURL.TabIndex = 0;
      this.ListURL.DoubleClick += new System.EventHandler(this.ListURL_DoubleClick);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddChannel,
            this.removeChannel});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
      // 
      // AddChannel
      // 
      this.AddChannel.Name = "AddChannel";
      this.AddChannel.Size = new System.Drawing.Size(160, 22);
      this.AddChannel.Text = "Добавить ленту";
      this.AddChannel.Click += new System.EventHandler(this.OpenUrl);
      // 
      // removeChannel
      // 
      this.removeChannel.Enabled = false;
      this.removeChannel.Name = "removeChannel";
      this.removeChannel.Size = new System.Drawing.Size(160, 22);
      this.removeChannel.Text = "Удалить ленту";
      this.removeChannel.Click += new System.EventHandler(this.removeChannel_Click);
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
      this.splitContainerChild.Panel1.Controls.Add(this.panel1);
      this.splitContainerChild.Panel1.Controls.Add(this.splitter2);
      this.splitContainerChild.Panel1.Controls.Add(this.channelBox);
      // 
      // splitContainerChild.Panel2
      // 
      this.splitContainerChild.Panel2.Controls.Add(this.webControl1);
      this.splitContainerChild.Panel2.Controls.Add(this.dateLabel);
      this.splitContainerChild.Panel2.Controls.Add(this.splitter1);
      this.splitContainerChild.Panel2.Controls.Add(this.link);
      this.splitContainerChild.Panel2.Controls.Add(this.itemBox);
      this.splitContainerChild.Panel2MinSize = 124;
      this.splitContainerChild.Size = new System.Drawing.Size(745, 385);
      this.splitContainerChild.SplitterDistance = 256;
      this.splitContainerChild.TabIndex = 0;
      this.splitContainerChild.TabStop = false;
      this.splitContainerChild.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainerChild_SplitterMoved);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.listItems);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(743, 251);
      this.panel1.TabIndex = 3;
      // 
      // listItems
      // 
      this.listItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listItems.DisplayMember = "Title";
      this.listItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.listItems.FormattingEnabled = true;
      this.listItems.Location = new System.Drawing.Point(0, 0);
      this.listItems.Name = "listItems";
      this.listItems.Size = new System.Drawing.Size(743, 251);
      this.listItems.TabIndex = 1;
      this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
      // 
      // splitter2
      // 
      this.splitter2.BackColor = System.Drawing.SystemColors.Menu;
      this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.splitter2.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitter2.Location = new System.Drawing.Point(0, 0);
      this.splitter2.Name = "splitter2";
      this.splitter2.Size = new System.Drawing.Size(743, 3);
      this.splitter2.TabIndex = 2;
      this.splitter2.TabStop = false;
      // 
      // channelBox
      // 
      this.channelBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.channelBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.channelBox.Location = new System.Drawing.Point(0, 0);
      this.channelBox.Name = "channelBox";
      this.channelBox.Size = new System.Drawing.Size(743, 0);
      this.channelBox.TabIndex = 1;
      this.channelBox.TabStop = false;
      this.channelBox.Click += new System.EventHandler(this.channelBox_Click);
      // 
      // webControl1
      // 
      this.webControl1.ContextMenuStrip = this.contextMenuStrip1;
      this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.webControl1.Location = new System.Drawing.Point(0, 0);
      this.webControl1.Size = new System.Drawing.Size(743, 107);
      this.webControl1.TabIndex = 6;
      // 
      // dateLabel
      // 
      this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.dateLabel.AutoSize = true;
      this.dateLabel.Location = new System.Drawing.Point(605, 110);
      this.dateLabel.Name = "dateLabel";
      this.dateLabel.Size = new System.Drawing.Size(0, 13);
      this.dateLabel.TabIndex = 5;
      // 
      // splitter1
      // 
      this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
      this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitter1.Location = new System.Drawing.Point(0, 107);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(743, 3);
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
      this.link.Click += new System.EventHandler(this.link_Click);
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
      // toolTip1
      // 
      this.toolTip1.AutomaticDelay = 5000;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(877, 409);
      this.Controls.Add(this.splitContainerMain);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(650, 300);
      this.Name = "MainForm";
      this.Text = "Сборка новостей";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      this.splitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.contextMenuStrip1.ResumeLayout(false);
      this.splitContainerChild.Panel1.ResumeLayout(false);
      this.splitContainerChild.Panel2.ResumeLayout(false);
      this.splitContainerChild.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerChild)).EndInit();
      this.splitContainerChild.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.channelBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.itemBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OpenRSS;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem AboutAuthor;
    private System.Windows.Forms.SplitContainer splitContainerMain;
    private System.Windows.Forms.SplitContainer splitContainerChild;
    private System.Windows.Forms.PictureBox itemBox;
    private System.Windows.Forms.LinkLabel link;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.PictureBox channelBox;
    private System.Windows.Forms.ListBox ListURL;
    private System.Windows.Forms.Label dateLabel;
    private System.Windows.Forms.ToolStripMenuItem ViewChannals;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Splitter splitter2;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ListBox listItems;
    private System.Windows.Forms.ToolStripMenuItem RefreshButton;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem removeChannel;
    private System.Windows.Forms.ToolStripMenuItem AddChannel;
    private System.Windows.Forms.ToolStripMenuItem SearchButton;
    private Awesomium.Windows.Forms.WebControl webControl1;
    private System.Windows.Forms.ToolStripMenuItem SaveSession;
    private System.Windows.Forms.ToolStripMenuItem LoadSession;
  }
}

