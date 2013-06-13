using System.Collections.Generic;
using System.Linq;

namespace LinguisticsBot
{
	class StringPair
	{
		public string XSAMPA;
		public string IPA;

		public StringPair(string xsampa, string ipa)
		{
			XSAMPA = xsampa;
			IPA = ipa;
		}
	}

	public class XSAMPA
	{
		static List<StringPair> Pairs;

		static XSAMPA()
		{
			Pairs = new List<StringPair>();
			Pairs.Add(new StringPair("a", "a"));
			Pairs.Add(new StringPair("b", "b"));
			Pairs.Add(new StringPair("b_<", "ɓ"));
			Pairs.Add(new StringPair("c", "c"));
			Pairs.Add(new StringPair("d", "d"));
			Pairs.Add(new StringPair("d`", "ɖ"));
			Pairs.Add(new StringPair("d_<", "ɗ"));
			Pairs.Add(new StringPair("e", "e"));
			Pairs.Add(new StringPair("f", "f"));
			Pairs.Add(new StringPair("g", "ɡ"));
			Pairs.Add(new StringPair("g_<", "ɠ"));
			Pairs.Add(new StringPair("h", "h"));
			Pairs.Add(new StringPair("h\\", "ɦ"));
			Pairs.Add(new StringPair("i", "i"));
			Pairs.Add(new StringPair("j", "j"));
			Pairs.Add(new StringPair("j\\", "ʝ"));
			Pairs.Add(new StringPair("k", "k"));
			Pairs.Add(new StringPair("l", "l"));
			Pairs.Add(new StringPair("l`", "ɭ"));
			Pairs.Add(new StringPair("l\\", "ɺ"));
			Pairs.Add(new StringPair("m", "m"));
			Pairs.Add(new StringPair("n", "n"));
			Pairs.Add(new StringPair("n`", "ɳ"));
			Pairs.Add(new StringPair("o", "o"));
			Pairs.Add(new StringPair("p", "p"));
			Pairs.Add(new StringPair("p\\", "ɸ"));
			Pairs.Add(new StringPair("q", "q"));
			Pairs.Add(new StringPair("r", "r"));
			Pairs.Add(new StringPair("r`", "ɽ"));
			Pairs.Add(new StringPair("r\\", "ɹ"));
			Pairs.Add(new StringPair("r\\`", "ɻ"));
			Pairs.Add(new StringPair("s", "s"));
			Pairs.Add(new StringPair("s`", "ʂ"));
			Pairs.Add(new StringPair("s\\", "ɕ"));
			Pairs.Add(new StringPair("t", "t"));
			Pairs.Add(new StringPair("t`", "ʈ"));
			Pairs.Add(new StringPair("u", "u"));
			Pairs.Add(new StringPair("v", "v"));
			Pairs.Add(new StringPair("v\\", "ʋ"));
			Pairs.Add(new StringPair("w", "w"));
			Pairs.Add(new StringPair("x", "x"));
			Pairs.Add(new StringPair("x\\", "ɧ"));
			Pairs.Add(new StringPair("y", "y"));
			Pairs.Add(new StringPair("z", "z"));
			Pairs.Add(new StringPair("z`", "ʐ"));
			Pairs.Add(new StringPair("z\\", "ʑ"));
			Pairs.Add(new StringPair("A", "ɑ"));
			Pairs.Add(new StringPair("B", "β"));
			Pairs.Add(new StringPair("B\\", "ʙ"));
			Pairs.Add(new StringPair("C", "ç"));
			Pairs.Add(new StringPair("D", "ð"));
			Pairs.Add(new StringPair("E", "ɛ"));
			Pairs.Add(new StringPair("F", "ɱ"));
			Pairs.Add(new StringPair("G", "ɣ"));
			Pairs.Add(new StringPair("G\\", "ɢ"));
			Pairs.Add(new StringPair("G\\_<", "ʛ"));
			Pairs.Add(new StringPair("H", "ɥ"));
			Pairs.Add(new StringPair("H\\", "ʜ"));
			Pairs.Add(new StringPair("I", "ɪ"));
			Pairs.Add(new StringPair("I\\", "ɪ̵"));
			Pairs.Add(new StringPair("J", "ɲ"));
			Pairs.Add(new StringPair("J\\", "ɟ"));
			Pairs.Add(new StringPair("J\\_<", "ʄ"));
			Pairs.Add(new StringPair("K", "ɬ"));
			Pairs.Add(new StringPair("K\\", "ɮ"));
			Pairs.Add(new StringPair("L", "ʎ"));
			Pairs.Add(new StringPair("L\\", "ʟ"));
			Pairs.Add(new StringPair("M", "ɯ"));
			Pairs.Add(new StringPair("M\\", "ɰ"));
			Pairs.Add(new StringPair("N", "ŋ"));
			Pairs.Add(new StringPair("N\\", "ɴ"));
			Pairs.Add(new StringPair("O", "ɔ"));
			Pairs.Add(new StringPair("O\\", "ʘ"));
			Pairs.Add(new StringPair("P", "ʋ"));
			Pairs.Add(new StringPair("Q", "ɒ"));
			Pairs.Add(new StringPair("R", "ʁ"));
			Pairs.Add(new StringPair("R\\", "ʀ"));
			Pairs.Add(new StringPair("S", "ʃ"));
			Pairs.Add(new StringPair("T", "θ"));
			Pairs.Add(new StringPair("U", "ʊ"));
			Pairs.Add(new StringPair("U\\", "ʊ̵"));
			Pairs.Add(new StringPair("V", "ʌ"));
			Pairs.Add(new StringPair("W", "ʍ"));
			Pairs.Add(new StringPair("X", "χ"));
			Pairs.Add(new StringPair("X\\", "ħ"));
			Pairs.Add(new StringPair("Y", "ʏ"));
			Pairs.Add(new StringPair("Z", "ʒ"));
			Pairs.Add(new StringPair(".", "."));
			Pairs.Add(new StringPair("\"", "ˈ"));
			Pairs.Add(new StringPair("%", "ˌ"));
			Pairs.Add(new StringPair("'", "ʲ"));
			Pairs.Add(new StringPair(":", "ː"));
			Pairs.Add(new StringPair(":\\", "ˑ"));
			Pairs.Add(new StringPair("@", "ə"));
			Pairs.Add(new StringPair("@\\", "ɘ"));
			Pairs.Add(new StringPair("{", "æ"));
			Pairs.Add(new StringPair("}", "ʉ"));
			Pairs.Add(new StringPair("1", "ɨ"));
			Pairs.Add(new StringPair("2", "ø"));
			Pairs.Add(new StringPair("3", "ɜ"));
			Pairs.Add(new StringPair("3\\", "ɞ"));
			Pairs.Add(new StringPair("4", "ɾ"));
			Pairs.Add(new StringPair("5", "ɫ"));
			Pairs.Add(new StringPair("6", "ɐ"));
			Pairs.Add(new StringPair("7", "ɤ"));
			Pairs.Add(new StringPair("8", "ɵ"));
			Pairs.Add(new StringPair("9", "œ"));
			Pairs.Add(new StringPair("&", "ɶ"));
			Pairs.Add(new StringPair("?", "ʔ"));
			Pairs.Add(new StringPair("?\\", "ʕ"));
			Pairs.Add(new StringPair("<\\", "ʢ"));
			Pairs.Add(new StringPair(">\\", "ʡ"));
			Pairs.Add(new StringPair("^", "↑"));
			Pairs.Add(new StringPair("!", "↓"));
			Pairs.Add(new StringPair("!\\", "ǃ"));
			Pairs.Add(new StringPair("|", "|"));
			Pairs.Add(new StringPair("|\\", "ǀ"));
			Pairs.Add(new StringPair("||", "‖"));
			Pairs.Add(new StringPair("|\\|\\", "ǁ"));
			Pairs.Add(new StringPair("=\\", "ǂ"));
			Pairs.Add(new StringPair("-\\", "‿"));
			Pairs.Add(new StringPair("_\"", "̈"));
			Pairs.Add(new StringPair("_+", "̟"));
			Pairs.Add(new StringPair("_-", "̠"));
			Pairs.Add(new StringPair("_/", "ˇ"));
			Pairs.Add(new StringPair("_0", "̥"));
			Pairs.Add(new StringPair("=", "̩"));
			Pairs.Add(new StringPair("_>", "ʼ"));
			Pairs.Add(new StringPair("_?\\", "ˤ"));
			Pairs.Add(new StringPair("_\\", "ˆ"));
			Pairs.Add(new StringPair("_^", "̯"));
			Pairs.Add(new StringPair("_}", "̚"));
			Pairs.Add(new StringPair("`", "˞"));
			Pairs.Add(new StringPair("~", "̃"));
			Pairs.Add(new StringPair("_A", "̘"));
			Pairs.Add(new StringPair("_a", "̺"));
			Pairs.Add(new StringPair("_B", "̏"));
			Pairs.Add(new StringPair("_c", "̜"));
			Pairs.Add(new StringPair("_d", "̪"));
			Pairs.Add(new StringPair("_e", "̴"));
			Pairs.Add(new StringPair("_F", "̂"));
			Pairs.Add(new StringPair("_G", "ˠ"));
			Pairs.Add(new StringPair("_H", "́"));
			Pairs.Add(new StringPair("_h", "ʰ"));
			Pairs.Add(new StringPair("_j", "ʲ"));
			Pairs.Add(new StringPair("_k", "̰"));
			Pairs.Add(new StringPair("_L", "̀"));
			Pairs.Add(new StringPair("_l", "ˡ"));
			Pairs.Add(new StringPair("_M", "̄"));
			Pairs.Add(new StringPair("_m", "̻"));
			Pairs.Add(new StringPair("_N", "̼"));
			Pairs.Add(new StringPair("_n", "ⁿ"));
			Pairs.Add(new StringPair("_O", "̹"));
			Pairs.Add(new StringPair("_o", "̞"));
			Pairs.Add(new StringPair("_q", "̙"));
			Pairs.Add(new StringPair("_R", "̌"));
			Pairs.Add(new StringPair("_r", "̝"));
			Pairs.Add(new StringPair("_T", "̋"));
			Pairs.Add(new StringPair("_t", "̤"));
			Pairs.Add(new StringPair("_v", "̬"));
			Pairs.Add(new StringPair("_w", "ʷ"));
			Pairs.Add(new StringPair("_X", "̆"));
			Pairs.Add(new StringPair("_x", "̽"));
			Pairs.Add(new StringPair("tS", "t͡ʃ"));
			Pairs.Add(new StringPair("dZ", "d͡ʒ"));
			Pairs.Add(new StringPair("ts", "t͡s"));
			Pairs.Add(new StringPair("dz", "d͡z"));
			Pairs = Pairs.OrderBy((StringPair x) => x.XSAMPA.Length).Reverse().ToList();
		}

		public static string Translate(string input)
		{
			string output = input;
			foreach (var pair in Pairs)
				output = output.Replace(pair.XSAMPA, pair.IPA);
			return output;
		}

		public static string TranslateSentence(string input)
		{
			string output = "";
			int offset = 0;
			while (true)
			{
				int left = input.IndexOf('[', offset);
				if (left == -1)
				{
					output += input.Substring(offset);
					break;
				}
				int right = input.IndexOf(']', left + 1);
				if (right == -1)
				{
					output += input.Substring(offset);
					break;
				}
				right++;
				string phoneticString = input.Substring(left, right - left);
				output += input.Substring(offset, left - offset);
				output += Translate(phoneticString);
				offset = right;
			}
			return output;
		}
	}
}
