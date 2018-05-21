using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Xeno.Console
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private string GetArgs(string cmdline)
    {
      string args = "";
      var start = cmdline.IndexOf(" ");

      if (start > 0)
        args = cmdline.Substring(start, cmdline.Length - start);

      return args;
    }

    private string GetExecutable(string cmdline)
    {
      string cmd = cmdline;
      var start = cmdline.IndexOf(" ");

      if (start > 0)
        cmd = cmdline.Substring(0, start);

      return cmd;
    }

    private void ProcessCommand()
    {
      TxtOutput.Text = string.Empty;

      string exec = GetExecutable(TxtInput.Text);
      string args = GetArgs(TxtInput.Text);

      if (exec != string.Empty)
      {
        StreamReader sOutput = null;
        StreamReader sErrors = null;

        try
        {
          ProcessStartInfo procNfo = new ProcessStartInfo(exec, args);
          procNfo.ErrorDialog = false;
          procNfo.UseShellExecute = false;
          procNfo.RedirectStandardError = true;
          procNfo.RedirectStandardInput = true;
          procNfo.RedirectStandardOutput = true;

          // exec
          Process proc = new Process();
          proc.StartInfo = procNfo;
          bool processStarted = proc.Start();
          if (processStarted)
          {
            //Get the output stream
            sOutput = proc.StandardOutput;
            sErrors = proc.StandardError;
            proc.WaitForExit();

            string output = sOutput.ReadToEnd();
            string errors = sErrors.ReadToEnd();

            if (errors.Length > 0)
              output += $"\r\n=========================\r\nError(s):\r\n{errors}";

            TxtOutput.Text = output;
          }
        }
        catch (Exception ex)
        {
          TxtOutput.Text = $"ERROR:\r\n{ex.Message}";
        }
        finally
        {
          if (sOutput != null)
            sOutput.Close();

          if (sErrors != null)
            sErrors.Close();
        }
      }
    }

    private void TxtInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)Keys.Return)
      {
        e.Handled = true;
        ProcessCommand();
      }
    }
  }
}
