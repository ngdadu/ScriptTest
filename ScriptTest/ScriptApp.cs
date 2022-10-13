using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptTest
{
    public class ScriptApp
    {
        public ScriptApp(Form1 form1)
        {
            MainForm = form1;
        }
        public Form1 MainForm { get; init; }
        public void AddLog(object message)
        {
            MainForm.txtResult.Text += $"{DateTime.Now:dd.MM.yyyy HH:mm:ss}: {message}\r\n";
        }
    }
}
