using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XSLTTester.Util;
using XSLTTester.Forms;

namespace XSLTTester
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbLoadXSLTFromFile_CheckedChanged(object sender, EventArgs e)
		{
			btnOpenXSLTFile.Enabled = cbLoadXSLTFromFile.Checked;
			tbXSLTInput.Enabled = !cbLoadXSLTFromFile.Checked;
		}

		private void btnOpenXMLFile_Click(object sender, EventArgs e)
		{
			if (xmlOpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				tbXMLFile.Text = xmlOpenFileDialog.FileName;
			}			
		}

		private void btnOpenXSLTFile_Click(object sender, EventArgs e)
		{			
			if (xsltOpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				tbXSLTFile.Text = xsltOpenFileDialog.FileName;
			}
		}

		private void cbLoadXMLFromFile_CheckedChanged(object sender, EventArgs e)
		{
			btnOpenXMLFile.Enabled = cbLoadXMLFromFile.Checked;
			tbXMLInput.Enabled = !cbLoadXMLFromFile.Checked;
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if (ValidateInput())
				{
					string xml, xslt;

					GetXmlAndXSLT(out xml, out xslt);

					string result = XSLTTransform.Transform(xml, xslt);

					XSLTResults form = new XSLTResults(result);
					form.Show();

					this.Cursor = Cursors.Default;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Exception caught : " + ex.ToString(), "XSLT Tester", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void GetXmlAndXSLT(out string xml, out string xslt)
		{
			if (cbLoadXMLFromFile.Checked)
			{
				xml = FileIO.ReadFromTextFile(tbXMLFile.Text);
				tbXMLInput.Text = xml;
			}
			else
			{
				xml = tbXMLInput.Text;
			}

			if (cbLoadXSLTFromFile.Checked)
			{
				xslt = FileIO.ReadFromTextFile(tbXSLTFile.Text);
				tbXSLTInput.Text = xslt;
			}
			else
			{
				xslt = tbXSLTInput.Text;				
			}
		}

		private bool ValidateInput()
		{
			if (cbLoadXMLFromFile.Checked)
			{
				if (tbXMLFile.Text == String.Empty)
				{
					errorProvider.SetError(btnOpenXMLFile, "Please select an input XML file first.");
					return false;
				}
			}
			else
			{
				if (tbXMLInput.Text == String.Empty)
				{
					errorProvider.SetError(tbXMLInput, "Please provide input XML first.");
					return false;
				}

			}

			if (cbLoadXSLTFromFile.Checked)
			{
				if (tbXSLTFile.Text == String.Empty)
				{
					errorProvider.SetError(btnOpenXSLTFile, "Please select an input XSLT file first.");
					return false;
				}
			}
			else
			{
				if (tbXSLTInput.Text == String.Empty)
				{
					errorProvider.SetError(tbXSLTInput, "Please provide XSLT input first.");
					return false;
				}
			}

			return true;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About form = new About();
			form.ShowDialog();
		}
	}
}