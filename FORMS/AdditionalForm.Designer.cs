﻿namespace FORMS {
  sealed partial class AdditionalForm {
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
      this.textBox = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.multipleValue = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // textBox
      // 
      this.textBox.Dock = System.Windows.Forms.DockStyle.Top;
      this.textBox.Location = new System.Drawing.Point(0, 0);
      this.textBox.Name = "textBox";
      this.textBox.Size = new System.Drawing.Size(284, 20);
      this.textBox.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(168, 26);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(116, 26);
      this.button1.TabIndex = 1;
      this.button1.Text = "Открыть";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // multipleValue
      // 
      this.multipleValue.AutoSize = true;
      this.multipleValue.Location = new System.Drawing.Point(12, 32);
      this.multipleValue.Name = "multipleValue";
      this.multipleValue.Size = new System.Drawing.Size(127, 17);
      this.multipleValue.TabIndex = 2;
      this.multipleValue.Text = "Добавить еще один";
      this.multipleValue.UseVisualStyleBackColor = true;
      // 
      // AdditionalForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(284, 51);
      this.Controls.Add(this.multipleValue);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AdditionalForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Добавление канала";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox multipleValue;
  }
}