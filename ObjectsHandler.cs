using System;
using SwinGameSDK;
using Color = System.Drawing.Color;
namespace MyGame
{
	public class ObjectsHandler
	{
		const int FLOOR_OFFSET = 30;
		private StateHandler _statehandler;
		private Character _menucharacter;
		private Character _levelcharacter;
		private Bitmap _level1set;
		private Bitmap _platform;
		private Point2D[] _level1platforms;
		private bool _collision = false;

				public ObjectsHandler (StateHandler _state)
				{
				_statehandler = _state;
				}

		public  void Run()
		{

			// Background Drawing
			switch (_statehandler.Gamestate)
			{
			case GameState.Menu:
				MenuObjects ();
				break;
			case GameState.Game:
				GameObjects ();
				break;
			case GameState.Transition:
				//DrawTransition ();
				break;
			}
		}

		public  void MenuObjects()
		{
			switch (_statehandler.Menustate)
			{
			case MenuState.MainMenu:
				MainMenuObjects ();
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

		public  void  GameObjects()
		{
			switch (_statehandler.Levelstate)
			{
			case LevelState.Level1:
				Level1Objects ();
				break;
			case LevelState.Level2:
				break;
			case LevelState.Level3:
				break;
			case LevelState.Level4:
				break;
			}
		}

		public void MainMenuObjects()
		{
			MainMenuCharacter ();
			MainMenuGame ();
		}

		public void MainMenuCharacter()
		{
		}

		public void MainMenuGame()
		{
		}

		public void Level1Objects ()
		{
		}

		public void LevelCharacterObject()
		{
		}

		public void Level1Background ()
		{
		}

		public Character MenuCharacter 
		{
			get
			{
				return _menucharacter;
			}
		}

		public Character LevelCharacter
		{
			get
			{
				return _levelcharacter;
			}
		}
	}
					
}

