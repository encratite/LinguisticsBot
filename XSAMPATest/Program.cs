using System.IO;
using System.Text;

using LinguisticsBot;

namespace XSAMPATest
{
	class Program
	{
		delegate void Writer(string data);

		static void Main(string[] arguments)
		{
			FileStream stream = new FileStream("output", FileMode.Create);
			Writer write = (string input) =>
			{
				string line = XSAMPA.TranslateText(input) + "\n";
				byte[] buffer = Encoding.UTF8.GetBytes(line);
				stream.Write(buffer, 0, buffer.Length);
			};
			write("[QWEASD]");
			write("QWEASD[QWEASD]");
			write("[QWEASD]QWEASD");
			write("QWEASD[QWEASD]QWEASD");
			write("QWEASD[QWEASD]QWEASD[QWEASD]QWEASD");
			write("QWEASD[QWEASD]QWEASD[QWEASDQWEASD");
			write("QWEASD[QWEASD]QWEASD]QWEASDQWEASD");
			stream.Close();
		}
	}
}
