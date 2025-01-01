using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;



//oh god






namespace battle
{
	public class Program

	{
		public static string Randname() //gen 6 random ascii charecters
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
				string? fuck = new string(name); //sting array to sting? i dont rlly know how this works but it does
				return fuck;
		}
		
		public static int monvals(string statsel)
		{
			string[] test = ["atk", "hp", "def",];
			//3rd time lol
			Random rand = new();
			int stat = rand.Next(0, 50);
			int lvl = rand.Next(0, 100) / 5; //lvl is 0 to 100 split into 5 chunks
			
			if (test.Contains(statsel)) //compare input to string array (i am so glad i found out you could do this)
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
			
			Console.WriteLine("Claire's weird thing \n Press 1 to generate new monters. \n");
			Console.WriteLine(" Press 0 to exit. \n\n");
			ConsoleKeyInfo Key = GetInput();


			//generate monsters
			
			while (Key.KeyChar == '1')
			{
				
				
				string fuck = Randname(); //i would like to consolidate this to its own function but i do not know how to do that currently
				int hp = monvals("hp");
				int atk = monvals("atk");
				int def = monvals("def");
				int lvl = monvals("lvl");
				
				Console.Clear();
				Console.WriteLine("\nmonster gened :3 \n\nname: " + fuck + "\nhp: " + hp + "\natk: " + atk+ "\ndef: " + def + "\nlvl " + lvl + "\n");
				Console.WriteLine("Press 1 to gen again.\nPress 0 to exit.");
				Key = GetInput();

			}
			Environment.Exit(0);
		}
		public static ConsoleKeyInfo GetInput() //better way of doing user input
		{
			ConsoleKeyInfo Keypressed = Console.ReadKey(true);
			int LR, UD;
			return Keypressed;
			
		}
	}
}
