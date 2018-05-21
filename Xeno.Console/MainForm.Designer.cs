namespace Xeno.Console
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.TxtInput = new System.Windows.Forms.TextBox();
      this.TxtOutput = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // TxtInput
      // 
      this.TxtInput.Location = new System.Drawing.Point(75, 12);
      this.TxtInput.Name = "TxtInput";
      this.TxtInput.Size = new System.Drawing.Size(554, 20);
      this.TxtInput.TabIndex = 0;
      this.TxtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInput_KeyPress);
      // 
      // TxtOutput
      // 
      this.TxtOutput.Location = new System.Drawing.Point(12, 38);
      this.TxtOutput.Multiline = true;
      this.TxtOutput.Name = "TxtOutput";
      this.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.TxtOutput.Size = new System.Drawing.Size(617, 284);
      this.TxtOutput.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(57, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Command:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(641, 334);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.TxtOutput);
      this.Controls.Add(this.TxtInput);
      this.Name = "MainForm";
      this.Text = "Console Wrapper Example";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox TxtInput;
    private System.Windows.Forms.TextBox TxtOutput;
    private System.Windows.Forms.Label label1;
  }
}