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
					HandleTransitionInput ();
					break;
				}
			}
		}

		public  void HandleTransitionInput()
		{
			switch (_statehandler.Transitionstate)
			{
			case TransitionState.Confirmation:
				//
				break;
			case TransitionState.LevelStart:
				//drawscores
				break;
			case TransitionState.LossScreen:
				//drawkeys
				break;
			case TransitionState.PauseScreen:
				PauseMenu ();
				break;
			case TransitionState.WinScreen:
				//
				break;
			}
		}

		public  void  HandleMenuInput()
		{
			switch (_statehandler.Menustate)
			{
			case MenuState.MainMenu:
				HandleMainMenu ();
				break;
			case MenuState.ViewingScores:
				//HandleScores ();
				break;
			case MenuState.CustomisingKeys:
				CustomiseKeys ();
				break;
			case MenuState.CustomisingSkins:
				CustomiseSkins ();
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
					_objecthandler.LevelCharacter.Goingright = false;
					_objecthandler.LevelCharacter.Xpos--;
					if (_statehandler.Characterstate == CharacterState.Standing)
					{
						_statehandler.ChangeState (CharacterState.Moving);
					}
				}
			}
				
			if(SwinGame.KeyDown(Hotkeys._right))
			{
				if (_objecthandler.LevelCharacter.Xpos < 725)
				{
					_objecthandler.LevelCharacter.Goingright = true;
					_objecthandler.LevelCharacter.Xpos++;
					if (_statehandler.Characterstate == CharacterState.Standing)
					{
						_statehandler.ChangeState (CharacterState.Moving);
					}
				}
			}
			if(SwinGame.KeyTyped(Hotkeys._jump)&& ((_statehandler.Characterstate == CharacterState.Moving)||(_statehandler.Characterstate == CharacterState.Standing)))
			{
				_statehandler.ChangeState (CharacterState.Jumping);
				_objecthandler.LevelCharacter.Statecount = 130;
			}

			if (SwinGame.KeyTyped (KeyCode.vk_p))
			{
				_statehandler.ChangeState (GameState.Transition);
				_statehandler.ChangeState (TransitionState.PauseScreen);
			}
		}

		public void PauseMenu()
		{
			if (SwinGame.KeyTyped (Hotkeys._down))
			{
				if ((int)_statehandler._cursor >= 4)
				{
					_statehandler._cursor = (MenuCursor)1;
				}
				else
				{
					_statehandler._cursor++;
				}
			}

			else if (SwinGame.KeyTyped (Hotkeys._up))
			{
				if ((int)_statehandler._cursor <= 1)
				{
					_statehandler._cursor = (MenuCursor)4;
				}
				else
				{
					_statehandler._cursor--;
				}
			}

			else if (SwinGame.KeyDown (Hotkeys._jump))
			{
				switch (_statehandler._cursor)
				{
				case MenuCursor.PlayGame:
					_statehandler.ChangeState (GameState.Game);
					break;
				case MenuCursor.HighScores:
					_statehandler.ChangeState (MenuState.ViewingScores);
					break;
				case MenuCursor.ChangeSkins:
					_statehandler.ChangeState (MenuState.CustomisingSkins);
					break;
				case MenuCursor.ChangeKeys:
					_statehandler.ChangeState (MenuState.CustomisingKeys);
					break;
				}
			}
		}

		public void HandleMainMenu()
		{
			if (SwinGame.KeyTyped (Hotkeys._down))
			{
				if ((int)_statehandler._cursor >= 4)
				{
					_statehandler._cursor = (MenuCursor)1;
				}
				else
				{
					_statehandler._cursor++;
				}
			}

			else if (SwinGame.KeyTyped (Hotkeys._up))
			{
				if ((int)_statehandler._cursor <= 1)
				{
					_statehandler._cursor = (MenuCursor)4;
				}
				else
				{
					_statehandler._cursor--;
				}
			}

			else if (SwinGame.KeyTyped (Hotkeys._jump))
			{
				switch (_statehandler._cursor)
				{
				case MenuCursor.PlayGame:
					_statehandler.ChangeState (GameState.Game);
					break;
				case MenuCursor.HighScores:
					_statehandler.ChangeState (MenuState.ViewingScores);
					break;
				case MenuCursor.ChangeSkins:
					_statehandler.ChangeState (MenuState.CustomisingSkins);
					break;
				case MenuCursor.ChangeKeys:
					_statehandler.ChangeState (MenuState.CustomisingKeys);
					break;
				}
			}
			/*if(SwinGame.KeyDown(Hotkeys._left))
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
			}*/

		}

		public void CustomiseKeys()
		{
			if (SwinGame.KeyTyped (Hotkeys._down))
			{
				if (_statehandler._keyscursor >= 6)
				{
					_statehandler._keyscursor = 1;
				}
				else
				{
					_statehandler._keyscursor++;
				}
			}

			else if (SwinGame.KeyTyped (Hotkeys._up))
			{
				if (_statehandler._keyscursor <= 1)
				{
					_statehandler._keyscursor = 6;
				}
				else
				{
					_statehandler._keyscursor--;
				}
			}

			else if (SwinGame.KeyTyped (Hotkeys._jump))
			{
				//add states for each key in here, case 6 is return to menu
				switch (_statehandler._keyscursor)
				{
				case 6:
					_statehandler.ChangeState (MenuState.MainMenu);
					break;
				default:
					break;
				}
			}
		}

		public void CustomiseSkins()
		{
			if (SwinGame.KeyTyped (Hotkeys._down))
			{
				if (_statehandler._skinscursor >= 2)
				{
					_statehandler._skinscursor = 1;
				}
				else
				{
					_statehandler._skinscursor++;
				}
			}

			else if (SwinGame.KeyTyped (Hotkeys._up))
			{
				if (_statehandler._skinscursor <= 1)
				{
					_statehandler._skinscursor = 2;
				}
				else
				{
					_statehandler._skinscursor--;
				}
			}

			else if (_statehandler._skinscursor == 1)
			{
				switch (_statehandler._skinscursor)
				{
				case 1:
					//change here to select more than one skin by altering skins enum
					if (SwinGame.KeyTyped (Hotkeys._left))
					{
						_statehandler.ChangeState (Skins.Mario);
					}
					else if (SwinGame.KeyTyped (Hotkeys._right))
					{
						_statehandler.ChangeState (Skins.Mario);
					}
					break;
				case 2:
					_statehandler.ChangeState (MenuState.MainMenu);
					break;
				}
			}
		}
			
	}
}

