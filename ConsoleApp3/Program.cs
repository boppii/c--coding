using System.IO;
using System;
using System.Text;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Linq;

namespace To_Binary
{
	public class Program
	{
		private static void Main(string[] FP)
		{
			int value = 0;
			string FilePath = FP[0];
			FileStream fs = File.OpenRead(FilePath);
			int[] binary = new int[fs.Length];
			while (fs.Position != fs.Length)
			{
				binary[value] = fs.ReadByte();
				value++;
			}
			fs.Close();
			foreach (var num in binary)
			{
				string test = Convert.ToString(num, 16);
				int len = test.Length;
				if (len == 1)
				{
					test = "0" + test;
				}
				int i = 0;
				foreach (var c in test)
				{
					string s = Lookup(c);
					i++;
					Console.Write(s);
					if (i % 2 == 0)
					{
						Console.Write("\n");
					}
				}
			}
		}

		private static string Lookup(char c)
		{
			char cl = Char.ToLower(c);
			switch (cl)
			{
				case '0':
					return "0000";
				case '1':
					return "0001";
				case '2':
					return "0010";
				case '3':
					return "0011";
				case '4':
					return "0100";
				case '5':
					return "0101";
				case '6':
					return "0110";
				case '7':
					return "0111";
				case '8':
					return "1000";
				case '9':
					return "1001";
				case 'a':
					return "1010";
				case 'b':
					return "1011";
				case 'c':
					return "1100";
				case 'd':
					return "1101";
				case 'e':
					return "1110";
				case 'f':
					return "1111";
				default:
					return "\n";
			}
		}
	}
}
