using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System Threading.Tasks;

namespace ThirdModule
{
	class Person : IDisposable
	{
		public int PersonID { get; set; }
		public string FirstName { get; set: }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Gender { get; set: }

		// glad to check if the object has been disposed
		private bool disposed = false;
		StreamReader sr;
		StreamWriter outputFile;

		public void ReadDetails(string filename)
		{
			sr = new StreamReader(fileName);

			try
			{ // Open the text using a stream reader.
				using (sr)
				{ // Read the stream to a string, and write the string to the console.
					String line = sr.ReadToEnd();
					Console.WriteLine(line);
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(“The file could not be read:”);
				Console.WriteLine(e.Message);
			}

			finally 
			{
				sr.Close();
				sr = null;
			}
		}
		
		public bool WriteDetails(string fileName)
		{
			bool result = false;
			outputFile = new StreamWrtiter(fileName);

			string[] lines = { this.PersonID.ToString(), this.FirstName, this.LastName, this.Gender, this.Age.ToString() };

			try
			{
				using (outputFile)
				{
					foreach (string line in lines)
						outputFile.WriteLine(line);
				}
				result = true;
			}

			catch(Exception e)
			{
				Console.WriteLine(“This file could not be written”);
			Console.WriteLine(e.Message);
			result = false;
			}

			finally
			{
				outputFile.Close();
				outputFile = null;
			}
			return result;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if(disposed)
			{
				if(disposed)
				{
					if(sr != null)
					{
						sr.Close();
					}
					if(outputFile != null)
					{
						outputFile.Close();
					}
				}
			}
			disposed = true;
		}
	}
}
