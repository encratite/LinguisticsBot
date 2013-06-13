using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace LinguisticsBot
{
	class Program
	{
		static void Main(string[] arguments)
		{
			if (arguments.Length < 5)
			{
				Console.WriteLine("Usage:");
				Console.WriteLine("<server> <port> <nick> <user> <real name> <channels to join>");
				return;
			}
			string server = arguments[0];
			int port = Convert.ToInt32(arguments[1]);
			string nick = arguments[2];
			string user = arguments[3];
			string realName = arguments[4];
			List<string> channels = arguments.Skip(5).ToList();
			IPAddress[] addresses = Dns.GetHostAddresses(server);
			IPEndPoint endPoint = new IPEndPoint(addresses[0], port);
			Bot bot = new Bot(channels);
			bot.Nick = nick;
			bot.User = user;
			bot.RealName = realName;
			bot.Run(endPoint);
		}
	}
}
