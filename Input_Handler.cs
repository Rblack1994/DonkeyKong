using System;
using Color = System.Drawing.Color;
using SwinGameSDK;
namespace MyGame
{
	public  class Input_Handler
	{
		private StateHandler _statehandler;
		private ObjectsHandler _objecthandler;

		public Input_Handler (StateHandler _state,ObjectsHandler _object)
		{
			_statehandler = _state;
			_objecthandler = _object;
		}

		public  void Run()
		{
			{
				// Background Drawing
				switch (_statehandler.Gamestate)
				{
				case GameState.Menu:
					HandleMenuInput ();
					break;
				case GameState.Game:
					HandleGameInput ();
					break;
				case GameState.Transition:
					//HandleTansitionInput ();
					break;
				}
			}
		}

		public  void  HandleMenuInput()
		{
			switch (_statehandler.Menustate)
			{
			case MenuState.MainMenu:
				HandleMainMenu ();
				break;
			case MenuState.VeiwingScores:
				//handlescores
				break;
			case MenuState.CustomisingKeys:
				//handlekeys
				break;
			case MenuState.CustomisingSkins:
				//handleskins
				break;
			}
		}

		public  void  HandleGameInput()
		{
			switch (_statehandler.Levelstate)
			{
			case LevelState.Level1:
				HandleLevelInput ();
				break;
			case LevelState.Level2:
				break;
			case LevelState.Level3:
				break;
			case LevelState.Level4:
				break;
			}
		}

		public void HandleLevelInput()
		{
			if (SwinGame.KeyDown (Hotkeys._left))
			{
				if (_objecthandler.LevelCharacter.Xpos > 50)
				{
					_objecthandler.LevelCharacter.Xpos--;
				}
			}
			if(SwinGame.KeyDown(Hotkeys._right))
			{
				if (_objecthandler.LevelCharacter.Xpos < 725)
				{
					_objecthandler.LevelCharacter.Xpos++;
				}
			}
			if(SwinGame.KeyTyped(Hotkeys._jump)&& ((_statehandler.Characterstate == CharacterState.Moving)||(_statehandler.Characterstate == CharacterState.Standing)))
			{
				_statehandler.ChangeState (CharacterState.Jumping);
				_objecthandler.LevelCharacter.Statecount = 130;
			}
		}

		public void HandleMainMenu()
		{
			if(SwinGame.KeyDown(Hotkeys._left))
				{
				_objecthandler.MenuCharacter.Xpos--;
				}
			if(SwinGame.KeyDown(Hotkeys._right))
			{
				_objecthandler.MenuCharacter.Xpos++;
			}
			if(SwinGame.KeyTyped(KeyCode.vk_1))
			{
				_statehandler.ChangeState(GameState.Game);
			}
		}
			
	}
}

