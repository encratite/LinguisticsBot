using System.Collections.Generic;
using System.Linq;

namespace LinguisticsBot
{
	public class XSAMPA
	{
		public static string TranslateText(string input)
		{
			string output = TranslateMarkedSegments(input, '[', ']');
			output = TranslateMarkedSegments(output, '/', '/');
			return output;
		}

		private static string TranslateMarkedSegments(string input, char leftDelimiter, char rightDelimiter)
		{
			string output = "";
			int offset = 0;
			while (true)
			{
				int left = input.IndexOf(leftDelimiter, offset);
				if (left == -1)
				{
					output += input.Substring(offset);
					break;
				}
				int right = input.IndexOf(rightDelimiter, left + 1);
				if (right == -1)
				{
					output += input.Substring(offset);
					break;
				}
				right++;
				string phoneticString = input.Substring(left, right - left);
				output += input.Substring(offset, left - offset);
				output += LinguisticsLibrary.Xsampa.ToIpa(phoneticString);
				offset = right;
			}
			return output;
		}
	}
}
