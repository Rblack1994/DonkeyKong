using System;

namespace MyGame
{
	public static class StateHandler
	{
		private GameState _gamestate;
		private MenuStates _menustate;
		private LevelStates _levelstate;
		private TransitionState _transitionstate;

		public StateHandler ()
		{
			_gamestate = GameState.Menu;
			_menustate = MenuStates.MainMenu;
			_levelstate = LevelStates.Level1;
			_transitionstate = TransitionState.LevelStart;
		}
	}
}