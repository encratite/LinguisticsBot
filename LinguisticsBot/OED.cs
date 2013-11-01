using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace LinguisticsBot
{
	public class OED
	{
		public static bool GetOEDIPA(string term, ref string output)
		{
			try
			{
				string url = string.Format("http://www.oxforddictionaries.com/search/english/?direct=1&multi=1&q={0}", HttpUtility.UrlEncode(term));
				WebClient client = new WebClient();
				client.Encoding = Encoding.UTF8;
				string content = client.DownloadString(url);
				Match match = Regex.Match(content, "<a href=\"http://www.oxforddictionaries.com/words/key-to-pronunciation\"> (/.+?/)</a>");
				if (!match.Success)
					return false;
				output = match.Groups[1].Value;
				return true;
			}
			catch (WebException)
			{
				return false;
			}
		}
	}
}
