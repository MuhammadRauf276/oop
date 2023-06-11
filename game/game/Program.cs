using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
using System.IO;
using game.BL;

namespace game
{
    class Program
    {
		

		static void Main(string[] args)
		{

			Console.Clear();
			hero coordinates = new hero();



			char[,] player = new char[8, 11] {
				{ ' ', ' ', ' ', ' ', '&', '&', '&', ' ', ' ', ' ', ' '},
				{ ' ', ' ', ' ', '(', '+', '.', '+', ')', ' ', ' ', ' '},
				{ ' ', ' ', '_', '_', '\\', '=', '/', '_', '_', ' ', ' '},
				{ '<', '|', '_', ' ', '~', '~', '~', ' ', '_', '|', '>'},
				{ ' ', ' ', ' ', '|', '_', '_', '_', '|', ' ', ' ', ' '},
				{ ' ', ' ', ' ', '/', ' ', '_', ' ', '\\', ' ', ' ', ' '},
				{ ' ', ' ', '/', '_', '/', ' ', '\\', '_', '\\', ' ', ' '},
				{ ' ', '/', '_', ')', ' ', ' ', ' ', '(', '_', '\\', ' '},
			  };
			coordinates.playerX = 3;
			coordinates.playerY = 4;
			char[,] enemy1 = new char[6,9]{
				{ ' ', ' ', ' ', ' ', '_', '_', ' ', ' ', ' '},
                { ' ', ' ', ' ', '/', ' ', ' ', '|', ' ', ' '},
                { ' ', ' ', '/', '`', ' ', ' ', '\\', '/', '|'},
                 { ' ', ' ', '\\', '<', '_', '_', '/', '\\', '|'},
                   { ' ', ' ', ' ', '\\', ' ', ' ', '|', ' ', ' '},
                   { ' ', ' ', ' ', ' ', '_', '_', ' ', ' ', ' '},
                    };
			coordinates.enemyX = 120;
			coordinates.enemyY = 12;



			string option = "0";
			
			int count = 0;
			int timer = 50;
			int motion = 0;
			int motion2 = 0;
			
			while (true)
			{


				option = mainmenu(); 
				if (option == "1")
				{
					Console.Clear();
					box();

					mplayer( player,  coordinates);
					// enemy2();
					// enemy1();
					while (true)
					{
						if (Keyboard.IsKeyPressed(Key.UpArrow))
						{
							moveplayerup(player,coordinates);
						}
						if (Keyboard.IsKeyPressed(Key.DownArrow))
						{
							moveplayerdown(player, coordinates);
						}
						if (Keyboard.IsKeyPressed(Key.LeftArrow))
						{
							moveplayerleft(player, coordinates);
						}
						if (Keyboard.IsKeyPressed(Key.RightArrow))
						{
							moveplayerright(player, coordinates);
						}




					}
				}

				if (option == "2")
				{
					while (true)
					{
						instruction();
						break;



					}
					
					
				
				}

				if (option == "3")
				{
					
					break;
				}
				else
				{

					Console.Write("Invalid Input");
					Console.Write("\n");
				}
			}
		}





	

		// main box
		 static void box()
		{
			
			Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("|||                                                                                                                                 |||");
			Console.Write("\n");
			Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
			Console.Write("\n");
		}

	 static string mainmenu()
		{
			
			string option;
			

			Console.Write("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
			Console.Write("\n");
			Console.Write("&     [..        [..[........[..          [..       [....     [..       [..[........              & ");
			Console.Write("\n");
			Console.Write("&     [..        [..[..      [..       [..   [..  [..    [..  [. [..   [...[..                    &");
			Console.Write("\n");
			Console.Write("&     [..   [.   [..[..      [..      [..       [..        [..[.. [.. [ [..[..                    &");
			Console.Write("\n");
			Console.Write("&     [..  [..   [..[......  [..      [..       [..        [..[..  [..  [..[......                &");
			Console.Write("\n");
			Console.Write("&     [.. [. [.. [..[..      [..      [..       [..        [..[..   [.  [..[..                    &");
			Console.Write("\n");
			Console.Write("&     [. [.    [....[..      [..       [..   [..  [..     [.. [..       [..[..                    &");
			Console.Write("\n");
			Console.Write("&     [..        [..[........[........   [....      [....     [..       [..[........              &");
			Console.Write("\n");
			Console.Write("&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&");
			Console.Write("\n");

			Console.Write("\n");
			

			Console.Write(".....___________________________________________________________________________________________.....");
			Console.Write("\n");
			

			Console.Write("__________________~~~~~~~~ Press 1 for start game ~~~~~~~____________________");
			Console.Write("\n");
			

			Console.Write("__________________~~~~~~~~ Press 2 for gmae instruction ~~~~~~_____________________");
			Console.Write("\n");
			

			Console.Write("................. Press 3 for exit ....................");
			Console.Write("\n");
			Console.Write("__________________~~~~~~~~ Enter your option ~~~~~~~____________________");
			Console.Write("\n");
			
			option=Console.ReadLine();
			return option;
		}

		 static void instruction()
		{
			
			Console.Write("  ");
			Console.Write("\n");
			Console.Write(" Press right key for move right");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
			
			Console.Write(" Press left key for move left");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
			
			Console.Write(" Press up key for move up");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
			
			Console.Write(" Press down key for move down");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
			
			Console.Write(" Press space  key for bullet");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
			
			Console.Write(" Press tab  key for bullet");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
			
			Console.Write(" Press escape key  key for resume game ");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
			
			Console.Write(" if you collide with walls then game over ");
			Console.Write("\n");
			Console.Write("  ");
			Console.Write("\n");
		}

		static void mplayer(char[,] player, hero coordinates)
		{
			
			

			for (int x = 0; x < player.GetLength(0); x++)
			{
				Console.SetCursorPosition(coordinates.playerX, coordinates.playerY+x);


				for (int y = 0; y < player.GetLength(1); y++)
				{
					Console.Write(player[x, y]);
				}
				Console.WriteLine();

			}
		}

		static void eraseplayer(char[,] player, hero coordinates)
		{



			for (int x = 0; x < player.GetLength(0); x++)
			{
				Console.SetCursorPosition(coordinates.playerX, coordinates.playerY + x);


				for (int y = 0; y < player.GetLength(1); y++)
				{
					Console.Write(" ");
				}
				Console.WriteLine();

			}
		}


		static void Enemy(char[,] enemy, hero coordinates)
		{



			for (int x = 0; x < enemy.GetLength(0); x++)
			{
				Console.SetCursorPosition(coordinates.playerX, coordinates.playerY + x);


				for (int y = 0; y < enemy.GetLength(1); y++)
				{
					Console.Write(enemy[x, y]);
				}
				Console.WriteLine();

			}
		}

		static void eraseEnemy(char[,] enemy, hero coordinates)
		{



			for (int x = 0; x < enemy.GetLength(0); x++)
			{
				Console.SetCursorPosition(coordinates.playerX, coordinates.playerY + x);


				for (int y = 0; y < enemy.GetLength(1); y++)
				{
					Console.Write(" ");
				}
				Console.WriteLine();

			}
		}

		static void moveplayerright(char[,] player, hero coordinates)
		{

			GetCharAtxy(coordinates.playerX+11, coordinates.playerY );
			if (GetCharAtxy(coordinates.playerX + 11, coordinates.playerY) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 1) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 2) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 3) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 4) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 5) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 6) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 7) == ' ' && GetCharAtxy(coordinates.playerX + 11, coordinates.playerY + 8) == ' ')
			{
				eraseplayer(player,coordinates);
				coordinates.playerX = coordinates.playerX + 1;
				mplayer(player,coordinates);
			}


		}

		static void moveplayerleft(char[,] player, hero coordinates)
		{
			GetCharAtxy(coordinates.playerX - 1, coordinates.playerY);
			if (GetCharAtxy(coordinates.playerX - 1, coordinates.playerY) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 1) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 2) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 3) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 4) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 5) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 6) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 7) == ' ' && GetCharAtxy(coordinates.playerX - 1, coordinates.playerY + 8) == ' ')
			{
				eraseplayer(player,coordinates);
				coordinates.playerX--;
				mplayer(player,coordinates);
			}
		}

		static void moveplayerdown(char[,] player, hero coordinates)
		{
			GetCharAtxy(coordinates.playerX, coordinates.playerY + 7);
			if (GetCharAtxy(coordinates.playerX, coordinates.playerY + 8) == ' ' && GetCharAtxy(coordinates.playerX + 1, coordinates.playerY + 8) == ' ' && GetCharAtxy(coordinates.playerX + 4, coordinates.playerY + 8) == ' ' && GetCharAtxy(coordinates.playerX + 6, coordinates.playerY + 8) == ' ' && GetCharAtxy(coordinates.playerX + 8, coordinates.playerY + 8) == ' ')
			{
				eraseplayer(player,coordinates);
				coordinates.playerY = coordinates.playerY + 1;
				mplayer(player, coordinates);
			}
		}
		static void moveplayerup(char[,] player, hero coordinates)
		{
			GetCharAtxy(coordinates.playerX, coordinates.playerY - 1);
			if (GetCharAtxy(coordinates.playerX, coordinates.playerY - 1) == ' ' && GetCharAtxy(coordinates.playerX + 1, coordinates.playerY - 1) == ' ' && GetCharAtxy(coordinates.playerX + 4, coordinates.playerY - 1) == ' ' && GetCharAtxy(coordinates.playerX + 6, coordinates.playerY - 1) == ' ' && GetCharAtxy(coordinates.playerX + 8, coordinates.playerY - 1) == ' ' && GetCharAtxy(coordinates.playerX + 10, coordinates.playerY - 1) == ' ')
			{
				eraseplayer(player,coordinates);
				coordinates.playerY--;
				mplayer(player,coordinates);
			}
		}


		public static char GetCharAtxy(int x, int y)
		{
			Console.SetCursorPosition(x, y);
			return Console.ReadKey().KeyChar;
		}




	}
}
