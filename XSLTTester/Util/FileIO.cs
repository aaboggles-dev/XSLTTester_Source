using System;
using System.IO;
using System.Net;

/// <summary>
/// Folder\File IO class
/// </summary>
namespace XSLTTester.Util
{	
	public class FileIO
	{		
		/// <summary>
		/// Creates a new <see cref="FileIO"/> instance.
		/// </summary>
		private FileIO() {}

		/// <summary>
		/// Writes to text file.
		/// </summary>
		/// <param name="filename">Filename.</param>
		/// <param name="content">Content.</param>
		/// <returns></returns>
		public static bool WriteToTextFile(string filename, string content) 
		{
			try 
			{
				if (File.Exists(filename)) 
				{
					File.Delete(filename);
				}
                
				System.IO.StreamWriter writer = System.IO.File.CreateText(filename);
				writer.Write(content);
				writer.Close();

				return true;
			}
			catch 
			{
				return false;
			}			
		}


		/// <summary>
		/// Reads from text file.
		/// </summary>
		/// <param name="filename">Filename.</param>
		/// <returns></returns>
		public static string ReadFromTextFile(string filename) 
		{
			System.IO.StreamReader reader = System.IO.File.OpenText(filename);
			string content = reader.ReadToEnd();
			reader.Close();
			return content;
			
		}
		
		/// <summary>
		/// Reads from binary file.
		/// </summary>
		/// <param name="fileName">Name of the file.</param>
		public static byte[] ReadFromBinaryFile(string fileName) 
		{			
			FileInfo fileInfo = new FileInfo(fileName);
			int fileSize = (int) fileInfo.Length;

			System.IO.Stream stream = System.IO.File.OpenRead(fileName);
			System.IO.BinaryReader binaryReader = new System.IO.BinaryReader(stream);

			byte[] bytes = new byte[fileSize];

			binaryReader.Read(bytes, 0, fileSize);

			binaryReader.Close();
			stream.Close();

			return bytes;
		}

		/// <summary>
		/// Writes to binary file.
		/// </summary>
		/// <param name="filename">Filename.</param>
		/// <param name="content">Content.</param>
		/// <returns></returns>
		public static bool WriteToBinaryFile(string filename, byte[] content) 
		{
			try 
			{
				if (File.Exists(filename)) 
				{
					File.Delete(filename);
				}
                
				using (System.IO.FileStream fs = System.IO.File.Create(filename)) 
				{
					System.IO.BinaryWriter writer = new System.IO.BinaryWriter(fs);					
					writer.Write(content);
					writer.Close();
					fs.Close();					
				}				

				return true;
			}
			catch 
			{
				return false;
			}			
		}

		/// <summary>
		/// Moves the directory.
		/// </summary>
		/// <param name="fromDirectory">From directory.</param>
		/// <param name="toDirectory">To directory.</param>
		public static void MoveDirectory(string fromDirectory, string toDirectory) 
		{
			if (!System.IO.Directory.Exists(toDirectory)) 
			{
				System.IO.Directory.CreateDirectory(toDirectory);
			}

			string[] fileNames  = Directory.GetFiles(fromDirectory);
                        
			for (int i = 0; i< fileNames.Length; i++) 
			{
				System.IO.FileInfo fileInfo = new System.IO.FileInfo(fileNames[i]);

				string toFileName = toDirectory + "\\" + fileInfo.Name;

				if (System.IO.File.Exists(toFileName)) 
				{
					System.IO.File.Delete(toFileName);
				}

				File.Move(fileNames[i], toFileName);
			}

			string[] directories = Directory.GetDirectories(fromDirectory);
            
			for (int i = 0; i< directories.Length; i++) 
			{
				string newDir = toDirectory + "\\" + directories[i];
				MoveDirectory(directories[i], newDir);
			}
		}

		public static string DownloadTextDocument(string url)
		{
			string text;

            WebRequest request = WebRequest.Create(url);			
            request.Credentials = CredentialCache.DefaultNetworkCredentials;
			request.ImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
			
            WebResponse response = request.GetResponse();
            
			using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
				text = reader.ReadToEnd();
			}
             
			response.Close();
            
            return text;
        }

		/// <summary>
		/// Deletes the directory.
		/// </summary>
		/// <param name="fromDirectory">directory.</param>
		public static bool DeleteDirectory(string directory) 
		{
			try 
			{
				if (!System.IO.Directory.Exists(directory)) 
				{
					return false;
				}

				string[] fileNames  = Directory.GetFiles(directory);
                        
				for (int i = 0; i< fileNames.Length; i++) 
				{
					System.IO.File.Delete(fileNames[i]);
				}

				System.IO.Directory.Delete(directory);

				return true;
			}
			catch  
			{
				return false;
			}		
		}
	}
}

