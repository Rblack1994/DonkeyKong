using System;
using SwinGameSDK;
using System.Collections.Generic;
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
		private List<Barrel> _barrels;
		private bool _collision = false;
		private int _enemycount;

				public ObjectsHandler (StateHandler _state)
				{
			_statehandler = _state;
			_barrels = new List<Barrel> ();
			_enemycount = 0;
			_menucharacter = new Mario (_statehandler, 250, 250) as Character;
			_levelcharacter = new Mario (_statehandler, 110, 552);
					
			_level1set = SwinGame.LoadBitmap(SwinGame.PathToResource("set1.png", ResourceKind.BitmapResource),true,Color.Black);
			_platform = SwinGame.LoadBitmap(SwinGame.PathToResource("platform.png", ResourceKind.BitmapResource),true,Color.Black);

			_level1platforms = new Point2D[] {
				//1st floor
				SwinGame.PointAt(50,580),
				SwinGame.PointAt(100,580),
				SwinGame.PointAt(150,580),
				SwinGame.PointAt(200,580),
				SwinGame.PointAt(250,580),
				SwinGame.PointAt(300,580),
				SwinGame.PointAt(350,580),
				SwinGame.PointAt(400,577),
				SwinGame.PointAt(450,574),
				SwinGame.PointAt(500,571),
				SwinGame.PointAt(550,568),
				SwinGame.PointAt(600,565),
				SwinGame.PointAt(650,562),
				SwinGame.PointAt(700,559),
				//2nd floor
				SwinGame.PointAt(50,499 - FLOOR_OFFSET),
				SwinGame.PointAt(100,502 - FLOOR_OFFSET),
				SwinGame.PointAt(150,505 - FLOOR_OFFSET),
				SwinGame.PointAt(200,508 - FLOOR_OFFSET),
				SwinGame.PointAt(250,511 - FLOOR_OFFSET),
				SwinGame.PointAt(300,514 - FLOOR_OFFSET),
				SwinGame.PointAt(350,517 - FLOOR_OFFSET),
				SwinGame.PointAt(400,520 - FLOOR_OFFSET),
				SwinGame.PointAt(450,523 - FLOOR_OFFSET),
				SwinGame.PointAt(500,526 - FLOOR_OFFSET),
				SwinGame.PointAt(550,529 - FLOOR_OFFSET),
				SwinGame.PointAt(600,532 - FLOOR_OFFSET),
				SwinGame.PointAt(650,535 - FLOOR_OFFSET),
					//SwinGame.PointAt(700,566),
				//3rd floor
					//SwinGame.PointAt(50,580),
				SwinGame.PointAt(100,474 - FLOOR_OFFSET*2),
				SwinGame.PointAt(150,471 - FLOOR_OFFSET*2),
				SwinGame.PointAt(200,468 - FLOOR_OFFSET*2),
				SwinGame.PointAt(250,465 - FLOOR_OFFSET*2),
				SwinGame.PointAt(300,462 - FLOOR_OFFSET*2),
				SwinGame.PointAt(350,459 - FLOOR_OFFSET*2),
				SwinGame.PointAt(400,456 - FLOOR_OFFSET*2),
				SwinGame.PointAt(450,453 - FLOOR_OFFSET*2),
				SwinGame.PointAt(500,450 - FLOOR_OFFSET*2),
				SwinGame.PointAt(550,447 - FLOOR_OFFSET*2),
				SwinGame.PointAt(600,444 - FLOOR_OFFSET*2),
				SwinGame.PointAt(650,441 - FLOOR_OFFSET*2),
				SwinGame.PointAt(700,438 - FLOOR_OFFSET*2),
				//4th floor
				SwinGame.PointAt(50,377 - FLOOR_OFFSET*3),
				SwinGame.PointAt(100,380 - FLOOR_OFFSET*3),
				SwinGame.PointAt(150,383 - FLOOR_OFFSET*3),
				SwinGame.PointAt(200,386 - FLOOR_OFFSET*3),
				SwinGame.PointAt(250,389 - FLOOR_OFFSET*3),
				SwinGame.PointAt(300,392 - FLOOR_OFFSET*3),
				SwinGame.PointAt(350,395 - FLOOR_OFFSET*3),
				SwinGame.PointAt(400,398 - FLOOR_OFFSET*3),
				SwinGame.PointAt(450,401 - FLOOR_OFFSET*3),
				SwinGame.PointAt(500,404 - FLOOR_OFFSET*3),
				SwinGame.PointAt(550,407 - FLOOR_OFFSET*3),
				SwinGame.PointAt(600,410 - FLOOR_OFFSET*3),
				SwinGame.PointAt(650,413 - FLOOR_OFFSET*3),
					//SwinGame.PointAt(700,566),
				//5th floor
					//SwinGame.PointAt(50,580),
				SwinGame.PointAt(100,352 - FLOOR_OFFSET*4),
				SwinGame.PointAt(150,349 - FLOOR_OFFSET*4),
				SwinGame.PointAt(200,346 - FLOOR_OFFSET*4),
				SwinGame.PointAt(250,343 - FLOOR_OFFSET*4),
				SwinGame.PointAt(300,340 - FLOOR_OFFSET*4),
				SwinGame.PointAt(350,337 - FLOOR_OFFSET*4),
				SwinGame.PointAt(400,334 - FLOOR_OFFSET*4),
				SwinGame.PointAt(450,331 - FLOOR_OFFSET*4),
				SwinGame.PointAt(500,328 - FLOOR_OFFSET*4),
				SwinGame.PointAt(550,325 - FLOOR_OFFSET*4),
				SwinGame.PointAt(600,322 - FLOOR_OFFSET*4),
				SwinGame.PointAt(650,319 - FLOOR_OFFSET*4),
				SwinGame.PointAt(700,316 - FLOOR_OFFSET*4),
				//6th floor
				SwinGame.PointAt(50,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(100,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(150,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(200,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(250,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(300,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(350,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(400,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(450,279 - FLOOR_OFFSET*5),
				SwinGame.PointAt(500,282 - FLOOR_OFFSET*5),
				SwinGame.PointAt(550,285 - FLOOR_OFFSET*5),
				SwinGame.PointAt(600,288 - FLOOR_OFFSET*5),
				SwinGame.PointAt(650,291 - FLOOR_OFFSET*5),
					//SwinGame.PointAt(700,566),
											};

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
			case MenuState.viewingScores:
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
			//MainMenuCharacter ();
			MainMenuGame ();
		}

		public void MainMenuCharacter()
		{
			Rectangle Rect = SwinGame.CreateRectangle (150 +8, 100 + 176, 231 - 8,  431 - 176);
			SwinGame.DrawText (_menucharacter.Xpos.ToString (),Color.Red, 500, 200);
			SwinGame.DrawText (_menucharacter.Ypos.ToString (),Color.Red, 500, 220);
			if(SwinGame.BitmapPartPointCollision(_level1set,150,100,Rect,_menucharacter.Xpos,_menucharacter.Ypos +16))
			{ 
				if (_menucharacter.Ypos > 100)
				{
					_menucharacter.Ypos--;
				}
			}
			else 
			{
				if (_menucharacter.Ypos < 350)
				{
					_menucharacter.Ypos++;
				}
			}
			_menucharacter.Draw ();
			switch (_statehandler.Skin)
			{
			case Skins.Mario:
				if(!(_menucharacter is Mario))
					_menucharacter = new Mario (_statehandler, 250, 250) as Character;
				break;
			}
		}

		public void MainMenuGame()
		{
			SwinGameSDK.SwinGame.DrawBitmapPart (_level1set, 8, 176, 231 - 8, 431 - 176, 150, 100);
		}

		public void Level1Objects ()
		{
			LevelCharacterObject ();
			Level1Background ();
			Level1Enemies ();
		}

		public void LevelCharacterObject()
		{
			//increases the character statecount for animation
			//checks for barrel collisions
			foreach (Barrel value in _barrels)
				if (SwinGame.PointInCircle (_levelcharacter.Xpos + 11, _levelcharacter.Ypos + 14, value.Xpos + 5, value.Ypos + 5, 14))
				{
					_statehandler.ChangeState (CharacterState.Dying);
					LevelCharacter.Statecount = 0;
				}

			//handles a dieing character
			if (_statehandler.Characterstate == CharacterState.Dying)
			{
				if (_levelcharacter.Statecount > 90)
				{
					_statehandler.ChangeState (GameState.Menu);
				}
			}

			//checks collision with platforms
			_collision = false;	
			if ((_statehandler.Characterstate != CharacterState.Jumping) || (LevelCharacter.Statecount < 65))
			{
				foreach (Point2D value in _level1platforms)
				{
					if (SwinGame.BitmapPointCollision (_platform, (int)value.X, (int)value.Y, _levelcharacter.Xpos + 15, _levelcharacter.Ypos + 29))
					{ 
						if (_levelcharacter.Ypos > 0)
						{
							_collision = true;
							_levelcharacter.Ypos--;
						}
					}
				}
				if (!_collision)
				{
					_levelcharacter.Ypos++;
				}
			}

			//handles character jumping, with platform collisions
			//platform collsions should perhaps be turned into a function
			_collision = false;	
			if (_statehandler.Characterstate == CharacterState.Jumping)
			{ _levelcharacter.Statecount--;
				if (_levelcharacter.Statecount > 65)
				{
					foreach (Point2D value in _level1platforms)
					{
						if (SwinGame.BitmapPointCollision (_platform, (int)value.X, (int)value.Y, _levelcharacter.Xpos + 15, _levelcharacter.Ypos - 0))
						{
							_collision = true;
							_levelcharacter.Statecount-=2;
						}
					}
					if (!_collision)
					{
						_levelcharacter.Ypos--;
					}
					_levelcharacter.Statecount--;
				}
				else
				{
					_levelcharacter.Statecount--;
					if (_levelcharacter.Statecount < 1)
					{
						_statehandler.ChangeState (CharacterState.Standing);
					}
				}
			}
			//draws the character
			_levelcharacter.Draw ();
			_levelcharacter.Statecount++;
			//initialises the character
			switch (_statehandler.Skin)
			{
			case Skins.Mario:
				if (!(_levelcharacter is Mario))
					_levelcharacter = new Mario (_statehandler, 250, 250);// as Character;
				break;
			}
		}

		public void Level1Background ()
		{
			foreach (Point2D value in _level1platforms)
				SwinGame.DrawBitmap (_platform, value);
		}

		public void Level1Enemies ()
		{
			_enemycount++;
			if(_enemycount >500)
			{
				_barrels.Add( new Barrel (_statehandler, 100, 269 - FLOOR_OFFSET * 5));
				_enemycount = 0;
			}
			foreach (Barrel value in _barrels)
			{
				value.Move();
				value.Draw ();
			}
			foreach (Barrel value in _barrels)
			{
				if (value.Ypos > 800)
					_barrels.Remove (value);
			}
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

