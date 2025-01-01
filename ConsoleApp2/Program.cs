using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using System.Linq;

//oh god



namespace battle
{
	public class Program
	{
		public static string Randname()
		{
			//init rand gen again :3
			Random rand = new();
			char[] name = new char[6];
				for (int i = 0; i < name.Length; i++)
				{
					int a;
					char b;
					a = rand.Next(65, 122);
					
					b = Convert.ToChar(a);
					
					name[i] = b;
					
					
				}
				string? fuck = new string(name);
				return fuck;
		}
		
		public static int monvals(string statsel)
		{
			string[] test = ["atk", "hp", "def",];
			//3rd time lol
			Random rand = new();
			int stat = rand.Next(0, 50);
			int lvl = rand.Next(0, 100) / 5; //lvl is 0 to 100 split into 5 chunks
			
			if (test.Contains(statsel))
			{
				return stat;
			}
			else if (statsel == "lvl")
			{
				return lvl;
			}
			else
			{
				Console.WriteLine("dummy you didnt do the correct input to statsel");
				return 0;
			}
		}
		
		
		
		
		
		public static void Main()
		{
			//init rand gen
			Random rand = new();

			//Monster maker
			//Enemy varables init (moving them somewhere else later)
			int enemy_hp;
			int enemy_atk;
			int enemy_def;
			int enemy_lvl;
			
			Console.WriteLine("Claire's weird thing \n Press 1 to generate new monters. \n \n");




			
			//generate monsters
			
			
			
			string? test = "1";
			while (test == Console.ReadLine())
			{
				string fuck = Randname();
				
				int hp = monvals("hp");
				int atk = monvals("atk");
				int def = monvals("def");
				int lvl = monvals("lvl");
				
				Console.WriteLine("monster gened :3 \n\n name: " + fuck + "\nhp" + hp + "\natk: " + atk+ "\ndef: " + def + "\nlvl " + lvl);
				
				
				
			}
			
		}
	}
}
