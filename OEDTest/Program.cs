using LinguisticsBot;
using System;
using System.IO;
using System.Text;

namespace OEDTest
{
    class Program
	{
		static void Main(string[] args)
		{
			string output = "";
            if (OED.GetOEDIPA("measurable", ref output))
            {
                using (var stream = new FileStream("Output.txt", FileMode.Create))
                {
                    var buffer = Encoding.UTF8.GetBytes(output);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            else
            {
                Console.WriteLine("Failed to retrieve IPA");
            }
		}
	}
}
