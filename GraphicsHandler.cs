using System;
using Color = System.Drawing.Color;
using SwinGameSDK;
using System.IO;
namespace MyGame
{

	public  class GraphicsHandler

	{
		private StateHandler _statehandler;
		private ObjectsHandler _objecthandler;
		private static System.Collections.Generic.List<Score> _Scores = new System.Collections.Generic.List<Score>();

		private struct Score : IComparable
		{
			public string Name;

			public int Value;
			/// <summary>
			/// Allows scores to be compared to facilitate sorting
			/// </summary>
			/// <param name="obj">the object to compare to</param>
			/// <returns>a value that indicates the sort order</returns>
			public int CompareTo(object obj)
			{
				if (obj is Score) {
					Score other = (Score)obj;

					return other.Value - this.Value;
				} else {
					return 0;
				}
			}
		}

		public GraphicsHandler (StateHandler _state,ObjectsHandler _object)
		{
			_objecthandler = _object;
			_statehandler = _state;
		}

		public  void Run()
		{

			// Background Drawing
			switch (_statehandler.Gamestate)
			{
			case GameState.Menu:
				DrawMenu ();
				break;
			case GameState.Game:
				DrawGame ();

				break;
			case GameState.Transition:
				DrawTransition ();
				break;
			}
		}

		public  void DrawMenu()
		{
			switch (_statehandler.Menustate)
			{
			case MenuState.MainMenu:
				DrawMainMenu ();
				break;
			case MenuState.ViewingScores:
				DrawScores ();
				break;
			case MenuState.CustomisingKeys:
				DrawKeysMenu ();
				break;
			case MenuState.CustomisingSkins:
				DrawSkinsMenu ();
				break;
			}
		}

		public void DrawTransition()
		{
			SwinGameSDK.SwinGame.DrawText ("C# Donkey Kong", Color.DarkRed, "arial", 38, 200, 25);
			SwinGameSDK.SwinGame.DrawText ("Start", Color.DarkRed, "arial", 38, 200, 400);
			SwinGameSDK.SwinGame.DrawText ("High Scores", Color.DarkRed, "arial", 38, 200, 450);
			SwinGameSDK.SwinGame.DrawText ("Customize Keys", Color.DarkRed, "arial", 38, 200, 500);
			SwinGameSDK.SwinGame.DrawText ("Change Skins", Color.DarkRed, "arial", 38, 200, 550);

			switch (_statehandler._cursor)
			{
			case MenuCursor.PlayGame:
				SwinGameSDK.SwinGame.DrawText ("Start", Color.White, "arial", 38, 200, 400);
				break;
			case MenuCursor.HighScores:
				SwinGameSDK.SwinGame.DrawText ("High Scores", Color.White, "arial", 38, 200, 450);
				break;
			case MenuCursor.ChangeKeys:
				SwinGameSDK.SwinGame.DrawText ("Customize Keys", Color.White, "arial", 38, 200, 500);
				break;
			case MenuCursor.ChangeSkins:
				SwinGameSDK.SwinGame.DrawText ("Change Skins", Color.White, "arial", 38, 200, 550);
				break;
			}
		}

		public  void  DrawGame()
		{
			switch (_statehandler.Levelstate)
			{
			case LevelState.Level1:
				DrawLevel1 ();
				break;
			case LevelState.Level2:
				break;
			case LevelState.Level3:
				break;
			case LevelState.Level4:
				break;
			}
		}

		public  void DrawMainMenu()
		{
			SwinGameSDK.SwinGame.DrawText("C# Donkey Kong", Color.DarkRed, "arial", 38, 200, 25);
			SwinGameSDK.SwinGame.DrawText("Start", Color.DarkRed, "arial", 38, 200, 400);
			SwinGameSDK.SwinGame.DrawText("High Scores", Color.DarkRed, "arial", 38, 200, 450);
			SwinGameSDK.SwinGame.DrawText("Customize Keys", Color.DarkRed, "arial", 38, 200, 500);
			SwinGameSDK.SwinGame.DrawText("Change Skins", Color.DarkRed, "arial", 38, 200, 550);

			switch (_statehandler._cursor)
			{
			case MenuCursor.PlayGame:
				SwinGameSDK.SwinGame.DrawText ("Start", Color.White, "arial", 38, 200, 400);
				break;
			case MenuCursor.HighScores:
				SwinGameSDK.SwinGame.DrawText ("High Scores", Color.White, "arial", 38, 200, 450);
				break;
			case MenuCursor.ChangeKeys:
				SwinGameSDK.SwinGame.DrawText ("Customize Keys", Color.White, "arial", 38, 200, 500);
				break;
			case MenuCursor.ChangeSkins:
				SwinGameSDK.SwinGame.DrawText ("Change Skins", Color.White, "arial", 38, 200, 550);
				SwinGameSDK.SwinGame.DrawText (_statehandler.Skin.ToString(), Color.White, "arial", 18, 400, 550);
				break;
			}


		}

		public  void DrawKeysMenu()
		{
			SwinGameSDK.SwinGame.DrawText("Hotkeys", Color.DarkRed, "arial", 38, 200, 25);

			SwinGameSDK.SwinGame.DrawText("Up :", Color.DarkRed, "arial", 24, 200, 250);
			SwinGameSDK.SwinGame.DrawText("Down :", Color.DarkRed, "arial", 24, 200, 300);
			SwinGameSDK.SwinGame.DrawText("Left :", Color.DarkRed, "arial", 24, 200, 350);
			SwinGameSDK.SwinGame.DrawText("Right :", Color.DarkRed, "arial", 24, 200, 400);
			SwinGameSDK.SwinGame.DrawText("Jump :", Color.DarkRed, "arial", 24, 200, 450);
			SwinGameSDK.SwinGame.DrawText("Pause", Color.DarkRed, "arial", 24, 200, 500);
			SwinGameSDK.SwinGame.DrawText("Back", Color.DarkRed, "arial", 24, 200, 550);

			SwinGameSDK.SwinGame.DrawText(Hotkeys._up.ToString(), Color.DarkRed, "arial", 24, 300, 250);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._down.ToString(), Color.DarkRed, "arial", 24, 300, 300);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._left.ToString(), Color.DarkRed, "arial", 24, 300, 350);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._right.ToString(), Color.DarkRed, "arial", 24, 300, 400);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._jump.ToString(), Color.DarkRed, "arial", 24, 300, 450);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._pause.ToString(), Color.DarkRed, "arial", 24, 300, 500);
			switch (_statehandler._keyscursor)
			{
			case 1:
				SwinGameSDK.SwinGame.DrawText("Up :", Color.White, "arial", 24, 200, 250);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._up.ToString(), Color.White, "arial", 24, 300, 250);
				break;
			case 2:
				SwinGameSDK.SwinGame.DrawText("Down :", Color.White, "arial", 24, 200, 300);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._down.ToString(), Color.White, "arial", 24, 300, 300);
				break;
			case 3:
				SwinGameSDK.SwinGame.DrawText("Left :", Color.White, "arial", 24, 200, 350);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._left.ToString(), Color.White, "arial", 24, 300, 350);
				break;
			case 4:
				SwinGameSDK.SwinGame.DrawText("Right :", Color.White, "arial", 24, 200, 400);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._right.ToString(), Color.White, "arial", 24, 300, 400);
				break;
			case 5:
				SwinGameSDK.SwinGame.DrawText("Jump :", Color.White, "arial", 24, 200, 450);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._jump.ToString(), Color.White, "arial", 24, 300, 450);
				break;
			case 6:
				SwinGameSDK.SwinGame.DrawText ("Pause :", Color.White, "arial", 24, 200, 500);
				SwinGameSDK.SwinGame.DrawText (Hotkeys._pause.ToString (), Color.White, "arial", 24, 300, 500);
				break;
			case 7:
				SwinGameSDK.SwinGame.DrawText ("Back", Color.White, "arial", 24, 200, 550);
				break;
				
			}


		}

		public void DrawSkinsMenu ()
		{
			string skinname = "Mario";
			if(_statehandler.Skin == Skins.Luigi)
				skinname = "Luigi";
			
			SwinGameSDK.SwinGame.DrawText("Skins Menu ", Color.DarkRed, "arial", 38, 200, 25);
			SwinGameSDK.SwinGame.DrawText("Skin :", Color.DarkRed, "arial", 38, 200, 250);
			SwinGameSDK.SwinGame.DrawText("Back", Color.DarkRed, "arial", 38, 200, 300);
			SwinGameSDK.SwinGame.DrawText(skinname, Color.DarkRed, "arial", 38, 400, 250);
				
			switch (_statehandler._skinscursor)
			{
			case 1:
				SwinGameSDK.SwinGame.DrawText ("Skin:", Color.White, "arial", 38, 200, 250);
				SwinGameSDK.SwinGame.DrawText (skinname, Color.White, "arial", 38, 400, 250);
				break;
			case 2:
				SwinGameSDK.SwinGame.DrawText ("Back", Color.White, "arial", 38, 200, 300);
				break;
			}
		}

		public void DrawScores()
		{

			string filename = null;
			filename = SwinGame.PathToResource("highscores.txt");
			SwinGameSDK.SwinGame.DrawText(filename, Color.DarkRed, "arial", 12, 100, 100);

			StreamReader input = default(StreamReader);
			input = new StreamReader(filename);

			//Read in the # of scores
			int numScores = 0;
			numScores = Convert.ToInt32(input.ReadLine());
			SwinGameSDK.SwinGame.DrawText(numScores.ToString(), Color.DarkRed, "arial", 12, 125, 150);
			_Scores.Clear();

			int i = 0;

			for (i = 1; i <= numScores; i++) {
				Score s = default(Score);
				string line = null;

				line = input.ReadLine();

				s.Name = line.Substring(0, 3);
				s.Value = Convert.ToInt32(line.Substring(3));
				_Scores.Add(s);
			}
			input.Close();

			SwinGameSDK.SwinGame.DrawText(_Scores.Count.ToString(), Color.DarkRed, "arial", 12, 150, 200);

			const int SCORES_HEADING = 40;
			const int SCORES_TOP = 80;
			const int SCORE_GAP = 30;
			const int SCORES_LEFT = 300;

			SwinGame.DrawText("   High Scores   ", Color.White, "arial",20, SCORES_LEFT, SCORES_HEADING);

			//For all of the scores
			for (i = 0; i <= _Scores.Count - 1; i++) {
				Score s = default(Score);

				s = _Scores[i];

				//for scores 1 - 9 use 01 - 09
				if (i < 9) {
					SwinGame.DrawText(" " + (i + 1) + ":   " + s.Name + "   " + s.Value, Color.White, "arial",20, SCORES_LEFT, SCORES_TOP + i * SCORE_GAP);
				} else {
					SwinGame.DrawText(i + 1 + ":   " + s.Name + "   " + s.Value, Color.White, "arial",20, SCORES_LEFT, SCORES_TOP + i * SCORE_GAP);
				}
			}


		}

		public  void DrawLevel1()
		{
			SwinGameSDK.SwinGame.DrawText(_statehandler.Score.ToString(), Color.AntiqueWhite, "arial",22, 500, 25);
			SwinGameSDK.SwinGame.DrawText("Donkey Kong Level 1", Color.DarkRed, "arial", 38, 200, 25);
			SwinGameSDK.SwinGame.DrawText(_statehandler.Characterstate.ToString(), Color.DarkRed, "arial", 400, 200, 10);
		}
			


	}
}

