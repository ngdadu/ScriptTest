using Microsoft.ClearScript;
using Microsoft.ClearScript.Windows;
using Microsoft.ClearScript.Windows.Core;

namespace ScriptTest
{
    public partial class Form1 : Form
    {
        private readonly ScriptApp scriptApp;
        public Form1()
        {
            InitializeComponent();
            scriptApp = new ScriptApp(this);

            txtCode.Text = @"option explicit

Dim x
Dim y
dim word, doc, objSelection

call app.AddLog(app.MainForm.Text)
app.MainForm.Text = ""Hello world "" & env.UserName & ""!""

x = 1
y = 2
call app.AddLog(x+y)
app.MainForm.WindowState = clr.System.Windows.Forms.FormWindowState.Maximized

set word = host.newComObj(""Word.Application"")
word.Visible = true
set doc = word.Documents.Add

Set objSelection = word.Selection
objSelection.Font.Name = ""Arial""
objSelection.Font.Size = ""18""
objSelection.TypeText app.MainForm.Text
objSelection.TypeParagraph()

objSelection.Font.Size = ""14""
objSelection.TypeText """" & Date()
objSelection.TypeParagraph()

doc.Saved = true
set word = Nothing
";
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            using var engine = new Microsoft.ClearScript.Windows.Core.VBScriptEngine(NullSyncInvoker.Instance);
            {
                //engine.AddHostType(typeof(System.Windows.Forms.Form));
                WindowState = FormWindowState.Normal;
                var typeCollection = new HostTypeCollection("mscorlib", "System", "System.Core", "System.Windows", "System.Windows.Forms", "System.Drawing");
                engine.AddHostObject("clr", typeCollection);
                engine.AddHostObject("host", new ExtendedHostFunctions());
                engine.AddHostType("env", typeof(Environment));
                engine.AddHostObject("app", scriptApp);
                engine.AllowReflection = true;

                try
                {
                    lblStatus.Text = "running..";
                    engine.Execute(txtCode.Text);
                    lblStatus.Text = "ok";
                }
                catch (Exception ex)
                {
                    lblStatus.Text = $"ERROR: {ex.Message}";
                }
            }
        }
    }
}