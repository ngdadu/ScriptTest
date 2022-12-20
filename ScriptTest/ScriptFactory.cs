#nullable disable
using FastColoredTextBoxNS;
using Microsoft.ClearScript;

namespace ScriptTest
{
    public partial class FrmScriptTest
    {
        internal class ScriptFactory
        {
            public string Name { get; set; }
            public FastColoredTextBox ScriptEditor { get; init; }
            public Func<bool, ScriptEngine> EngineCreator { get; init; }
            public ScriptFactory(FastColoredTextBox scriptEditor, Func<bool, ScriptEngine> engine)
            {
                ScriptEditor = scriptEditor;
                EngineCreator = engine;
            }
        }
    }
}