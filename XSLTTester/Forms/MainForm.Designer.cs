namespace XSLTTester
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.xmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbXML = new System.Windows.Forms.GroupBox();
            this.tbXMLInput = new System.Windows.Forms.RichTextBox();
            this.tbXMLFile = new System.Windows.Forms.TextBox();
            this.btnOpenXMLFile = new System.Windows.Forms.Button();
            this.cbLoadXMLFromFile = new System.Windows.Forms.CheckBox();
            this.gbXSLT = new System.Windows.Forms.GroupBox();
            this.tbXSLTInput = new System.Windows.Forms.RichTextBox();
            this.tbXSLTFile = new System.Windows.Forms.TextBox();
            this.btnOpenXSLTFile = new System.Windows.Forms.Button();
            this.cbLoadXSLTFromFile = new System.Windows.Forms.CheckBox();
            this.xsltOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbXML.SuspendLayout();
            this.gbXSLT.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnTest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 24);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "View Input XML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(361, 0);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(280, 24);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Perform XSLT Transformation and View Output XML";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // xmlOpenFileDialog
            // 
            this.xmlOpenFileDialog.Filter = "XML Files|*.xml|All files|*.*";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbXML);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbXSLT);
            this.splitContainer1.Size = new System.Drawing.Size(641, 551);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 10;
            // 
            // gbXML
            // 
            this.gbXML.Controls.Add(this.tbXMLInput);
            this.gbXML.Controls.Add(this.tbXMLFile);
            this.gbXML.Controls.Add(this.btnOpenXMLFile);
            this.gbXML.Controls.Add(this.cbLoadXMLFromFile);
            this.gbXML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbXML.Location = new System.Drawing.Point(0, 0);
            this.gbXML.Name = "gbXML";
            this.gbXML.Size = new System.Drawing.Size(641, 275);
            this.gbXML.TabIndex = 10;
            this.gbXML.TabStop = false;
            this.gbXML.Text = "Input XML :";
            // 
            // tbXMLInput
            // 
            this.tbXMLInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXMLInput.Enabled = false;
            this.tbXMLInput.Location = new System.Drawing.Point(26, 73);
            this.tbXMLInput.Name = "tbXMLInput";
            this.tbXMLInput.Size = new System.Drawing.Size(591, 184);
            this.tbXMLInput.TabIndex = 4;
            this.tbXMLInput.Text = "";
            // 
            // tbXMLFile
            // 
            this.tbXMLFile.Location = new System.Drawing.Point(26, 45);
            this.tbXMLFile.Name = "tbXMLFile";
            this.tbXMLFile.ReadOnly = true;
            this.tbXMLFile.Size = new System.Drawing.Size(329, 20);
            this.tbXMLFile.TabIndex = 2;
            // 
            // btnOpenXMLFile
            // 
            this.btnOpenXMLFile.Image = global::XSLTTester.Properties.Resources.drive_go;
            this.btnOpenXMLFile.Location = new System.Drawing.Point(361, 42);
            this.btnOpenXMLFile.Name = "btnOpenXMLFile";
            this.btnOpenXMLFile.Size = new System.Drawing.Size(25, 25);
            this.btnOpenXMLFile.TabIndex = 3;
            this.btnOpenXMLFile.UseVisualStyleBackColor = true;
            this.btnOpenXMLFile.Click += new System.EventHandler(this.btnOpenXMLFile_Click);
            // 
            // cbLoadXMLFromFile
            // 
            this.cbLoadXMLFromFile.AutoSize = true;
            this.cbLoadXMLFromFile.Checked = true;
            this.cbLoadXMLFromFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLoadXMLFromFile.Location = new System.Drawing.Point(26, 19);
            this.cbLoadXMLFromFile.Name = "cbLoadXMLFromFile";
            this.cbLoadXMLFromFile.Size = new System.Drawing.Size(126, 17);
            this.cbLoadXMLFromFile.TabIndex = 1;
            this.cbLoadXMLFromFile.Text = "Load XML From File?";
            this.cbLoadXMLFromFile.UseVisualStyleBackColor = true;
            this.cbLoadXMLFromFile.CheckedChanged += new System.EventHandler(this.cbLoadXMLFromFile_CheckedChanged);
            // 
            // gbXSLT
            // 
            this.gbXSLT.Controls.Add(this.tbXSLTInput);
            this.gbXSLT.Controls.Add(this.tbXSLTFile);
            this.gbXSLT.Controls.Add(this.btnOpenXSLTFile);
            this.gbXSLT.Controls.Add(this.cbLoadXSLTFromFile);
            this.gbXSLT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbXSLT.Location = new System.Drawing.Point(0, 0);
            this.gbXSLT.Name = "gbXSLT";
            this.gbXSLT.Size = new System.Drawing.Size(641, 272);
            this.gbXSLT.TabIndex = 13;
            this.gbXSLT.TabStop = false;
            this.gbXSLT.Text = "XSLT :";
            // 
            // tbXSLTInput
            // 
            this.tbXSLTInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbXSLTInput.Enabled = false;
            this.tbXSLTInput.Location = new System.Drawing.Point(26, 73);
            this.tbXSLTInput.Name = "tbXSLTInput";
            this.tbXSLTInput.Size = new System.Drawing.Size(591, 181);
            this.tbXSLTInput.TabIndex = 4;
            this.tbXSLTInput.Text = "";
            // 
            // tbXSLTFile
            // 
            this.tbXSLTFile.Location = new System.Drawing.Point(26, 45);
            this.tbXSLTFile.Name = "tbXSLTFile";
            this.tbXSLTFile.ReadOnly = true;
            this.tbXSLTFile.Size = new System.Drawing.Size(329, 20);
            this.tbXSLTFile.TabIndex = 2;
            // 
            // btnOpenXSLTFile
            // 
            this.btnOpenXSLTFile.Image = global::XSLTTester.Properties.Resources.drive_go;
            this.btnOpenXSLTFile.Location = new System.Drawing.Point(361, 42);
            this.btnOpenXSLTFile.Name = "btnOpenXSLTFile";
            this.btnOpenXSLTFile.Size = new System.Drawing.Size(25, 25);
            this.btnOpenXSLTFile.TabIndex = 3;
            this.btnOpenXSLTFile.UseVisualStyleBackColor = true;
            this.btnOpenXSLTFile.Click += new System.EventHandler(this.btnOpenXSLTFile_Click);
            // 
            // cbLoadXSLTFromFile
            // 
            this.cbLoadXSLTFromFile.AutoSize = true;
            this.cbLoadXSLTFromFile.Checked = true;
            this.cbLoadXSLTFromFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLoadXSLTFromFile.Location = new System.Drawing.Point(26, 19);
            this.cbLoadXSLTFromFile.Name = "cbLoadXSLTFromFile";
            this.cbLoadXSLTFromFile.Size = new System.Drawing.Size(131, 17);
            this.cbLoadXSLTFromFile.TabIndex = 1;
            this.cbLoadXSLTFromFile.Text = "Load XSLT From File?";
            this.cbLoadXSLTFromFile.UseVisualStyleBackColor = true;
            this.cbLoadXSLTFromFile.CheckedChanged += new System.EventHandler(this.cbLoadXSLTFromFile_CheckedChanged);
            // 
            // xsltOpenFileDialog
            // 
            this.xsltOpenFileDialog.Filter = "XSLT Files|*.xslt|XSL Files|*.xsl|All files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 599);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "XSLT Tester";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.gbXML.ResumeLayout(false);
            this.gbXML.PerformLayout();
            this.gbXSLT.ResumeLayout(false);
            this.gbXSLT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.OpenFileDialog xmlOpenFileDialog;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox gbXML;
		private System.Windows.Forms.RichTextBox tbXMLInput;
		private System.Windows.Forms.TextBox tbXMLFile;
		private System.Windows.Forms.Button btnOpenXMLFile;
		private System.Windows.Forms.CheckBox cbLoadXMLFromFile;
		private System.Windows.Forms.GroupBox gbXSLT;
		private System.Windows.Forms.RichTextBox tbXSLTInput;
		private System.Windows.Forms.TextBox tbXSLTFile;
		private System.Windows.Forms.Button btnOpenXSLTFile;
		private System.Windows.Forms.CheckBox cbLoadXSLTFromFile;
		private System.Windows.Forms.OpenFileDialog xsltOpenFileDialog;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

