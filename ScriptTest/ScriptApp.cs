using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptTest
{
    public class ScriptApp
    {
        public ScriptApp(FrmScriptTest form1)
        {
            MainForm = form1;
        }
        public FrmScriptTest MainForm { get; init; }
        public void AddLog(object message)
        {
            MainForm.txtResult.Text += $"{DateTime.Now:dd.MM.yyyy HH:mm:ss}: {message}\r\n";
        }
    }
}
