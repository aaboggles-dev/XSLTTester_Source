using System;
using System.Xml;
using System.Xml.Xsl;

namespace XSLTTester.Util
{
	/// <summary>
	/// Summary description for XSLTTransform.
	/// </summary>
	public class XSLTTransform
	{
		/// <summary>
		/// Creates a new <see cref="XSLTTransform"/> instance.
		/// </summary>
		private XSLTTransform()
		{
			
		}
		
		public static string Transform(string xml, string xslt)
		{			
			System.IO.MemoryStream stream = new System.IO.MemoryStream();

			try {
				XmlDocument xmlDoc = new XmlDocument();
				XmlDocument xsltDoc = new XmlDocument();

				xmlDoc.LoadXml(xml);
				xsltDoc.LoadXml(xslt);

                XslCompiledTransform xslTran = new XslCompiledTransform();
                				
				xslTran.Load(xsltDoc, null, null);                
				xslTran.Transform(xmlDoc, null, stream);
				
				// Get the text from the stream
				stream.Flush();
				
				string result =  System.Text.ASCIIEncoding.ASCII.GetString(stream.GetBuffer());
				result = result.Replace("\0", String.Empty);
				result = result.Replace("o;?", String.Empty);
				result = result.Replace("\n\r", String.Empty);

				if (result.Substring(0, 3) == "???")
				{
					result = result.Substring(3);
				}

				return result;
			}
			catch {
				throw;
			}
			finally {
				stream.Close();
			}
		}		
	}
}
