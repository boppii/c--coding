using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;

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
		
		
		
		
		
		
		
		public static void Main()
		{
			//init rand gen
			Random rand = new();

			//Monster maker
			//init monster variables
			int hp;
			int atk;
			int def;
			int lvl;
			//
			//Enemy varables init
			int enemy_hp;
			int enemy_atk;
			int enemy_def;
			int enemy_lvl;
			//
			Console.WriteLine("Claire's weird thing \n Press 1 to generate new monters. \n \n");
			//generate monsters
			string? test = "1";
			while (test == Console.ReadLine())
			{
				string fuck = Randname();
				
				hp = rand.Next(0, 50);
				atk = rand.Next(0, 50);
				def = rand.Next(0, 50);
				lvl = rand.Next(0, 100) / 5; //lvl is 0 to 100 split into 5 chunks
				Console.WriteLine("\n name: " + fuck + "\n hp: " + hp + "\n atk: " + atk + "\n def: " + def + "\n lvl: " + lvl + "\n");
				
			}
			
		}
	}
}