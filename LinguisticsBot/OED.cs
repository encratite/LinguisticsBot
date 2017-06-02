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
				string url = string.Format("http://en.oxforddictionaries.com/definition/{0}", HttpUtility.UrlEncode(term));
				WebClient client = new WebClient();
				client.Encoding = Encoding.UTF8;
				string content = client.DownloadString(url);
				Match match = Regex.Match(content, "<span class=\"phoneticspelling\">\\/(.+?)\\/</span>");
				if (!match.Success)
					return false;
				output = string.Format("/{0}/", match.Groups[1].Value);
				return true;
			}
			catch (WebException)
			{
				return false;
			}
		}
	}
}
