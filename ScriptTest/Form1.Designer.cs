namespace ScriptTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExec = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.txtResult = new FastColoredTextBoxNS.FastColoredTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExec});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExec
            // 
            this.btnExec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExec.Image = global::ScriptTest.Properties.Resources.imStart;
            this.btnExec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(34, 28);
            this.btnExec.Text = "toolStripButton1";
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
            // txtCode
            // 
            this.txtCode.AutoCompleteBracketsList = new char[] {
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
            this.txtCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.\\(\\)]+\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.txtCode.AutoScrollMinSize = new System.Drawing.Size(35, 22);
            this.txtCode.BackBrush = null;
            this.txtCode.CharHeight = 22;
            this.txtCode.CharWidth = 12;
            this.txtCode.CommentPrefix = "\'";
            this.txtCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.IsReplaceMode = false;
            this.txtCode.Language = FastColoredTextBoxNS.Language.VB;
            this.txtCode.LeftBracket = '(';
            this.txtCode.Location = new System.Drawing.Point(0, 33);
            this.txtCode.Name = "txtCode";
            this.txtCode.Paddings = new System.Windows.Forms.Padding(0);
            this.txtCode.RightBracket = ')';
            this.txtCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtCode.ServiceColors")));
            this.txtCode.Size = new System.Drawing.Size(775, 613);
            this.txtCode.TabIndex = 2;
            this.txtCode.Zoom = 100;
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
            this.splitContainer1.Panel1.Controls.Add(this.txtCode);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtResult);
            this.splitContainer1.Size = new System.Drawing.Size(1437, 646);
            this.splitContainer1.SplitterDistance = 775;
            this.splitContainer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 678);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "ScriptTest";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnExec;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private FastColoredTextBoxNS.FastColoredTextBox txtCode;
        private SplitContainer splitContainer1;
        internal FastColoredTextBoxNS.FastColoredTextBox txtResult;
    }
}