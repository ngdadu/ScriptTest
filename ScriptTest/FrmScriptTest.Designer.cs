namespace ScriptTest
{
    partial class FrmScriptTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScriptTest));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDebug = new System.Windows.Forms.ToolStripButton();
            this.btnExec = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCodeVBS = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtResult = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabEngines = new System.Windows.Forms.TabControl();
            this.pageVBS = new System.Windows.Forms.TabPage();
            this.pageJS = new System.Windows.Forms.TabPage();
            this.txtCodeJS = new FastColoredTextBoxNS.FastColoredTextBox();
            this.toolLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeVBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabEngines.SuspendLayout();
            this.pageVBS.SuspendLayout();
            this.pageJS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeJS)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDebug,
            this.btnExec,
            this.toolLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 34);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDebug
            // 
            this.btnDebug.Image = global::ScriptTest.Properties.Resources.debug;
            this.btnDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(94, 29);
            this.btnDebug.Text = "Debug";
            this.btnDebug.Click += new System.EventHandler(this.BtnDebug_Click);
            // 
            // btnExec
            // 
            this.btnExec.Image = global::ScriptTest.Properties.Resources.imStart;
            this.btnExec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(71, 29);
            this.btnExec.Text = "Run";
            this.btnExec.Click += new System.EventHandler(this.BtnExec_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 646);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1437, 32);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(19, 25);
            this.lblStatus.Text = "-";
            // 
            // txtCodeVBS
            // 
            this.txtCodeVBS.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtCodeVBS.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.\\(\\)]+\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.txtCodeVBS.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.txtCodeVBS.BackBrush = null;
            this.txtCodeVBS.CharHeight = 22;
            this.txtCodeVBS.CharWidth = 12;
            this.txtCodeVBS.CommentPrefix = "\'";
            this.txtCodeVBS.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCodeVBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeVBS.IsReplaceMode = false;
            this.txtCodeVBS.Language = FastColoredTextBoxNS.Language.VB;
            this.txtCodeVBS.LeftBracket = '(';
            this.txtCodeVBS.Location = new System.Drawing.Point(3, 3);
            this.txtCodeVBS.Name = "txtCodeVBS";
            this.txtCodeVBS.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCodeVBS.RightBracket = ')';
            this.txtCodeVBS.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCodeVBS.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCodeVBS.ServiceColors")));
            this.txtCodeVBS.Size = new System.Drawing.Size(761, 568);
            this.txtCodeVBS.TabIndex = 2;
            this.txtCodeVBS.Zoom = 100;
            // 
            // txtResult
            // 
            this.txtResult.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtResult.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.txtResult.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.txtResult.BackBrush = null;
            this.txtResult.CharHeight = 22;
            this.txtResult.CharWidth = 12;
            this.txtResult.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.IsReplaceMode = false;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.Paddings = new System.Windows.Forms.Padding(0);
            this.txtResult.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtResult.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtResult.ServiceColors")));
            this.txtResult.Size = new System.Drawing.Size(658, 646);
            this.txtResult.TabIndex = 3;
            this.txtResult.Zoom = 100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabEngines);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Size = new System.Drawing.Size(1437, 646);
            this.splitContainer1.SplitterDistance = 775;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabEngines
            // 
            this.tabEngines.Controls.Add(this.pageVBS);
            this.tabEngines.Controls.Add(this.pageJS);
            this.tabEngines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEngines.Location = new System.Drawing.Point(0, 34);
            this.tabEngines.Name = "tabEngines";
            this.tabEngines.SelectedIndex = 0;
            this.tabEngines.Size = new System.Drawing.Size(775, 612);
            this.tabEngines.TabIndex = 3;
            // 
            // pageVBS
            // 
            this.pageVBS.Controls.Add(this.txtCodeVBS);
            this.pageVBS.Location = new System.Drawing.Point(4, 34);
            this.pageVBS.Name = "pageVBS";
            this.pageVBS.Padding = new System.Windows.Forms.Padding(3);
            this.pageVBS.Size = new System.Drawing.Size(767, 574);
            this.pageVBS.TabIndex = 0;
            this.pageVBS.Text = "VBS";
            this.pageVBS.UseVisualStyleBackColor = true;
            // 
            // pageJS
            // 
            this.pageJS.Controls.Add(this.txtCodeJS);
            this.pageJS.Location = new System.Drawing.Point(4, 34);
            this.pageJS.Name = "pageJS";
            this.pageJS.Padding = new System.Windows.Forms.Padding(3);
            this.pageJS.Size = new System.Drawing.Size(767, 574);
            this.pageJS.TabIndex = 1;
            this.pageJS.Text = "JavaScript";
            this.pageJS.UseVisualStyleBackColor = true;
            // 
            // txtCodeJS
            // 
            this.txtCodeJS.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtCodeJS.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.txtCodeJS.AutoScrollMinSize = new System.Drawing.Size(2, 22);
            this.txtCodeJS.BackBrush = null;
            this.txtCodeJS.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtCodeJS.CharHeight = 22;
            this.txtCodeJS.CharWidth = 12;
            this.txtCodeJS.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCodeJS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeJS.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodeJS.IsReplaceMode = false;
            this.txtCodeJS.Language = FastColoredTextBoxNS.Language.JS;
            this.txtCodeJS.LeftBracket = '(';
            this.txtCodeJS.LeftBracket2 = '{';
            this.txtCodeJS.Location = new System.Drawing.Point(3, 3);
            this.txtCodeJS.Name = "txtCodeJS";
            this.txtCodeJS.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCodeJS.RightBracket = ')';
            this.txtCodeJS.RightBracket2 = '}';
            this.txtCodeJS.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCodeJS.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCodeJS.ServiceColors")));
            this.txtCodeJS.Size = new System.Drawing.Size(761, 568);
            this.txtCodeJS.TabIndex = 3;
            this.txtCodeJS.Zoom = 100;
            // 
            // toolLabel
            // 
            this.toolLabel.Name = "toolLabel";
            this.toolLabel.Size = new System.Drawing.Size(19, 29);
            this.toolLabel.Text = "-";
            // 
            // FrmScriptTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 678);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmScriptTest";
            this.Text = "ScriptTest";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeVBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabEngines.ResumeLayout(false);
            this.pageVBS.ResumeLayout(false);
            this.pageJS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodeJS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnExec;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private FastColoredTextBoxNS.FastColoredTextBox txtCodeVBS;
        private SplitContainer splitContainer1;
        internal FastColoredTextBoxNS.FastColoredTextBox txtResult;
        private ToolStripButton btnDebug;
        private TabControl tabEngines;
        private TabPage pageVBS;
        private TabPage pageJS;
        private FastColoredTextBoxNS.FastColoredTextBox txtCodeJS;
        private ToolStripLabel toolLabel;
    }
}