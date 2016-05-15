namespace XSLTTester.Forms
{
	partial class XSLTResults
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XSLTResults));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.gbTextResult = new System.Windows.Forms.GroupBox();
			this.gbHTML = new System.Windows.Forms.GroupBox();
			this.tbTextResult = new System.Windows.Forms.RichTextBox();
			this.wbHTML = new System.Windows.Forms.WebBrowser();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gbTextResult.SuspendLayout();
			this.gbHTML.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gbTextResult);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gbHTML);
			this.splitContainer1.Size = new System.Drawing.Size(718, 658);
			this.splitContainer1.SplitterDistance = 171;
			this.splitContainer1.TabIndex = 2;
			// 
			// gbTextResult
			// 
			this.gbTextResult.Controls.Add(this.tbTextResult);
			this.gbTextResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbTextResult.Location = new System.Drawing.Point(0, 0);
			this.gbTextResult.Name = "gbTextResult";
			this.gbTextResult.Size = new System.Drawing.Size(718, 171);
			this.gbTextResult.TabIndex = 1;
			this.gbTextResult.TabStop = false;
			this.gbTextResult.Text = "Text Result";
			// 
			// gbHTML
			// 
			this.gbHTML.Controls.Add(this.wbHTML);
			this.gbHTML.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbHTML.Location = new System.Drawing.Point(0, 0);
			this.gbHTML.Name = "gbHTML";
			this.gbHTML.Size = new System.Drawing.Size(718, 483);
			this.gbHTML.TabIndex = 3;
			this.gbHTML.TabStop = false;
			this.gbHTML.Text = "HTML";
			// 
			// tbTextResult
			// 
			this.tbTextResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbTextResult.Location = new System.Drawing.Point(3, 16);
			this.tbTextResult.Name = "tbTextResult";
			this.tbTextResult.Size = new System.Drawing.Size(712, 152);
			this.tbTextResult.TabIndex = 0;
			this.tbTextResult.Text = "";
			// 
			// wbHTML
			// 
			this.wbHTML.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wbHTML.Location = new System.Drawing.Point(3, 16);
			this.wbHTML.MinimumSize = new System.Drawing.Size(20, 20);
			this.wbHTML.Name = "wbHTML";
			this.wbHTML.Size = new System.Drawing.Size(712, 464);
			this.wbHTML.TabIndex = 0;
			// 
			// XSLTResults
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 658);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "XSLTResults";
			this.Text = "XSLT Results";
			this.Load += new System.EventHandler(this.XSLTResults_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.gbTextResult.ResumeLayout(false);
			this.gbHTML.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox gbTextResult;
		private System.Windows.Forms.GroupBox gbHTML;
		private System.Windows.Forms.RichTextBox tbTextResult;
		private System.Windows.Forms.WebBrowser wbHTML;

	}
}