﻿namespace FORMS {
  sealed partial class OpenUrlForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.url = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // url
      // 
      this.url.Dock = System.Windows.Forms.DockStyle.Top;
      this.url.Location = new System.Drawing.Point(0, 0);
      this.url.Name = "url";
      this.url.Size = new System.Drawing.Size(284, 20);
      this.url.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(168, 26);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(116, 26);
      this.button1.TabIndex = 1;
      this.button1.Text = "Открыть";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // OpenURLForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(284, 51);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.url);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Name = "OpenUrlForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox url;
    private System.Windows.Forms.Button button1;
  }
}