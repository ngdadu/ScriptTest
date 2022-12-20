using Microsoft.ClearScript;
using Microsoft.ClearScript.V8;
using Microsoft.ClearScript.Windows;
using Microsoft.ClearScript.Windows.Core;
using System.Reflection;

namespace ScriptTest
{
    public partial class FrmScriptTest : Form
    {
        private readonly ScriptApp scriptApp;
        public FrmScriptTest()
        {
            InitializeComponent();
            scriptApp = new ScriptApp(this);

            txtCodeVBS.Text = ObjectHelper.GetAssemblyManifestResourceText(Assembly.GetExecutingAssembly(), "Scripts.Script1.vbs");
            txtCodeJS.Text = ObjectHelper.GetAssemblyManifestResourceText(Assembly.GetExecutingAssembly(), "Scripts.Script1.js");

            toolLabel.Text = "";
            pageVBS.Tag = new ScriptFactory(txtCodeVBS, (debugging) => new Microsoft.ClearScript.Windows.VBScriptEngine(debugging 
                ? WindowsScriptEngineFlags.EnableDebugging 
                : WindowsScriptEngineFlags.None))
            { Name = "VBScript" };
            pageJS.Tag = new ScriptFactory(txtCodeJS, (debugging) => new V8ScriptEngine(debugging 
                ? V8ScriptEngineFlags.EnableDebugging | V8ScriptEngineFlags.EnableRemoteDebugging | V8ScriptEngineFlags.AwaitDebuggerAndPauseOnStart 
                : V8ScriptEngineFlags.None))
            { Name = "JavaScriptV8" };
        }

        private void BtnExec_Click(object sender, EventArgs e)
        {
            Execute(false);
        }

        private void BtnDebug_Click(object sender, EventArgs e)
        {
            Execute(true);
        }

        private void Execute(bool debugging)
        {
            var factory = tabEngines.SelectedTab.Tag as ScriptFactory;
            toolLabel.Text = $"{factory!.Name} SCRIPT RUNNING debugging={debugging}..";
            using var engine = factory!.EngineCreator.Invoke(debugging);
            RunScript(engine, factory!.ScriptEditor.Text);
            toolLabel.Text = "";
        }

        private void RunScript(ScriptEngine engine, string code)
        {
            engine.AddHostType(typeof(System.Windows.Forms.Form));
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
                engine.Execute(code);
                lblStatus.Text = "ok";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"ERROR: {ex.Message}";
            }
        }
    }
}