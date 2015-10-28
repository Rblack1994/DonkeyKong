using System;
using Color = System.Drawing.Color;
using SwinGameSDK;
namespace MyGame
{

	public  class GraphicsHandler

	{
		private StateHandler _statehandler;
		private ObjectsHandler _objecthandler;


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
				//drawscores
				break;
			case MenuState.CustomisingKeys:
				DrawKeysMenu ();
				break;
			case MenuState.CustomisingSkins:
				//drawskins
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
			SwinGameSDK.SwinGame.DrawText("Up :", Color.DarkRed, "arial", 38, 200, 250);
			SwinGameSDK.SwinGame.DrawText("Down :", Color.DarkRed, "arial", 38, 200, 300);
			SwinGameSDK.SwinGame.DrawText("Left :", Color.DarkRed, "arial", 38, 200, 350);
			SwinGameSDK.SwinGame.DrawText("Right :", Color.DarkRed, "arial", 38, 200, 400);
			SwinGameSDK.SwinGame.DrawText("Jump :", Color.DarkRed, "arial", 38, 200, 450);
			SwinGameSDK.SwinGame.DrawText("Back", Color.DarkRed, "arial", 38, 200, 500);

			SwinGameSDK.SwinGame.DrawText(Hotkeys._up.ToString(), Color.DarkRed, "arial", 38, 300, 250);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._down.ToString(), Color.DarkRed, "arial", 38, 300, 300);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._left.ToString(), Color.DarkRed, "arial", 38, 300, 350);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._right.ToString(), Color.DarkRed, "arial", 38, 300, 400);
			SwinGameSDK.SwinGame.DrawText(Hotkeys._jump.ToString(), Color.DarkRed, "arial", 38, 300, 450);
			switch (_statehandler._keyscursor)
			{
			case 1:
				SwinGameSDK.SwinGame.DrawText("Up :", Color.White, "arial", 38, 200, 250);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._up.ToString(), Color.White, "arial", 38, 300, 250);
				break;
			case 2:
				SwinGameSDK.SwinGame.DrawText("Down :", Color.White, "arial", 38, 200, 300);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._down.ToString(), Color.White, "arial", 38, 300, 300);
				break;
			case 3:
				SwinGameSDK.SwinGame.DrawText("Left :", Color.White, "arial", 38, 200, 350);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._left.ToString(), Color.White, "arial", 38, 300, 350);
				break;
			case 4:
				SwinGameSDK.SwinGame.DrawText("Right :", Color.White, "arial", 38, 200, 400);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._right.ToString(), Color.White, "arial", 38, 300, 400);
				break;
			case 5:
				SwinGameSDK.SwinGame.DrawText("Jump :", Color.White, "arial", 38, 200, 450);
				SwinGameSDK.SwinGame.DrawText(Hotkeys._jump.ToString(), Color.White, "arial", 38, 300, 450);
				break;
			case 6:
				SwinGameSDK.SwinGame.DrawText ("Back", Color.White, "arial", 38, 200, 500);
				break;
				
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

