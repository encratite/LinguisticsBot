using System.IO;
using System.Text;

using LinguisticsBot;

namespace OEDTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string output = "";
			OED.GetOEDIPA("measurable", ref output);
			FileStream stream = new FileStream("output", FileMode.Create);
			byte[] buffer = Encoding.UTF8.GetBytes(output);
			stream.Write(buffer, 0, buffer.Length);
		}
	}
}
