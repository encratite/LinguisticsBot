using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

using BIRCh;

namespace LinguisticsBot
{
	class Bot : Client
	{
		delegate void MatchHandler(Match match, User user, string target, string message);

		List<string> Channels;
		Dictionary<string, MatchHandler> MatchHandlers;

		public Bot(List<string> channels)
		{
			Channels = channels;
			MatchHandlers = new Dictionary<string, MatchHandler>();
			MatchHandlers["^\x01VERSION\x01$"] = OnVersion;
			MatchHandlers["^\\.ipa (.+)$"] = OnIPA;
			MatchHandlers["^\\.oed (.+)$"] = OnOED;
		}

		protected override void OnConnect()
		{
			Console.WriteLine("Connected");
		}

		protected override void OnDisconnect(Exception exception)
		{
			if(exception == null)
				Console.WriteLine("Disconnected by server");
			else
				Console.WriteLine("Disconnected: {0}", exception.Message);
		}

		protected override void OnReceive(string line)
		{
			Console.WriteLine("< {0}", line);
		}

		protected override void OnSend(string line)
		{
			Console.WriteLine("> {0}", line);
		}

		protected override void OnEntry()
		{
			Console.WriteLine("Successfully logged onto the server");
			foreach (string channel in Channels)
				JoinChannel(channel);
		}

		protected override void OnInvite(User user, string channel)
		{
			JoinChannel(channel);
		}

		protected override void OnMessage(User user, string target, string message)
		{
			Console.WriteLine("[{0}] <{1}@{2}> {3}", target, user.Nick, user.Host, message);
			foreach (var pair in MatchHandlers)
			{
				Match match = Regex.Match(message, pair.Key);
				if (match.Success)
				{
					pair.Value(match, user, target, message);
					break;
				}
			}
		}

		void Respond(User user, string target, string line)
		{
			bool isPrivateMessage = target.Length > 0 && target[0] != '#';
			if (isPrivateMessage)
				SendMessage(user.Nick, line);
			else

				SendMessage(target, line);
		}

		void OnVersion(Match match, User user, string target, string message)
		{
			int revision = Assembly.GetCallingAssembly().GetName().Version.Revision;
			string response = string.Format("\x01VERSION From the entrails to the dirt, r{0}\x01", revision);
			SendNotice(user.Nick, response);
		}

		void OnIPA(Match match, User user, string target, string message)
		{
			string translation = XSAMPA.TranslateSentence(match.Groups[1].Value);
			Respond(user, target, translation);
		}

		void OnOED(Match match, User user, string target, string message)
		{
			string phonemes = "";
			bool success = OED.GetOEDIPA(match.Groups[1].Value, ref phonemes);
			string response;
			if (success)
				response = phonemes;
			else
				response = "Request failed";
			Respond(user, target, response);
		}
	}
}
