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
				//DrawTransition ();
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
			case MenuState.VeiwingScores:
				//drawscores
				break;
			case MenuState.CustomisingKeys:
				//drawkeys
				break;
			case MenuState.CustomisingSkins:
				//drawskins
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

		}

		public  void DrawLevel1()
		{
			SwinGameSDK.SwinGame.DrawText("Donkey Kong Level 1", Color.DarkRed, "arial", 38, 200, 25);
		}
			
	}
}

