using System;
using Color = System.Drawing.Color;
using SwinGameSDK;
namespace MyGame
{

	public class GraphicsHandler

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
				//DrawMenu ();
				break;
			case GameState.Game:
				//DrawGame ();
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
				//DrawMainMenu ();
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
				//DrawLevel1 ();
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
		}

		public  void DrawLevel1()
		{
		}
	}
}

