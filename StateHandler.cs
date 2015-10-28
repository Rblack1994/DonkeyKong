using System;

namespace MyGame
{
	public  class StateHandler
	{
		private   GameState _gamestate;
		private  MenuState _menustate;
		private  LevelState _levelstate;
		private  TransitionState _transitionstate;
		private CharacterState _characterstate;
		private Skins _characterskin;
		private   GameState _nextgamestate;
		private  MenuState _nextmenustate;
		private  LevelState _nextlevelstate;
		private  TransitionState _nexttransitionstate;
		private CharacterState _nextcharacterstate;
		private Skins _nextcharacterskin;
		public MenuCursor _cursor;
		private int _score;
		public int _keyscursor;
		public int _skinscursor;

		 public StateHandler ()
		{
			_score = 0;
			_gamestate = GameState.Menu;
			_menustate = MenuState.MainMenu;
			_levelstate = LevelState.Level1;
			_transitionstate = TransitionState.LevelStart;
			_characterstate = CharacterState.Standing;
			_characterskin = Skins.Mario;
			_nextgamestate = GameState.Menu;
			_nextmenustate = MenuState.MainMenu;
			_nextlevelstate = LevelState.Level1;
			_nexttransitionstate = TransitionState.LevelStart;
			_nextcharacterstate = CharacterState.Standing;
			_nextcharacterskin = Skins.Mario;
			_cursor = MenuCursor.PlayGame;
			_keyscursor = 1;
			_skinscursor = 1;
		}

		public void Run()
		{
			_gamestate = _nextgamestate;
			_menustate = _nextmenustate;
			_levelstate = _nextlevelstate;
			_transitionstate = _nexttransitionstate;
			_characterstate = _nextcharacterstate;
			_characterskin = _nextcharacterskin;
		}

		public void ChangeState(GameState next)
		{
			_nextgamestate = next;
		}

		public void ChangeState(MenuState next)
		{
			_nextmenustate = next;
		}

		public void ChangeState(LevelState next)
		{
			_nextlevelstate = next;
		}

		public void ChangeState(TransitionState next)
		{
			_nexttransitionstate = next;
		}

		public void ChangeState(CharacterState next)
		{
			_nextcharacterstate = next;
		}

		public void ChangeState(Skins next)
		{
			_nextcharacterskin = next;
		}

		public   GameState Gamestate
		{
			get
			{
				return _gamestate;
			}
		}

		public  MenuState Menustate
		{
			get
			{
				return _menustate;
			}
		}

		public  LevelState Levelstate
		{
			get
			{
				return _levelstate;
			}
		}

		public  TransitionState Transitionstate
		{
			get
			{
				return _transitionstate;
			}
		}

		public CharacterState Characterstate
		{
			get
			{
				return _characterstate;
			}
		}

		public Skins Skin
		{
			get
			{
				return _characterskin;
			}
		}

		public int Score
		{
			get
			{
				return _score;
			}
			set
			{
				_score = value;
			}
		}
	}
}