using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XSLTTester.Forms
{
	public partial class XSLTResults : Form
	{
		public XSLTResults(string result_)
		{
			InitializeComponent();

			FillForm(result_);
		}

		private void FillForm(string result_)
		{
			tbTextResult.Text = result_;
			System.IO.MemoryStream stream = new System.IO.MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes(result_));
			wbHTML.DocumentStream = stream;
		}

		private void XSLTResults_Load(object sender, EventArgs e)
		{

		}
	}
}