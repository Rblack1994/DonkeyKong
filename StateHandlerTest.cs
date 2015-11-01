using NUnit.Framework;
using System;

namespace MyGame
{
	[TestFixture ()]
	public class StateHandlerTest
	{
		[Test ()]
		public void TestCaseStateHandling()
		{
			StateHandler s = new StateHandler ();

			// check all default states
			Assert.IsTrue (s.Gamestate == GameState.Menu);
			Assert.IsTrue (s.Menustate == MenuState.MainMenu);
			Assert.IsTrue (s.Levelstate == LevelState.Level1);
			Assert.IsTrue (s.Transitionstate == TransitionState.LevelStart);
			Assert.IsTrue (s.Characterstate == CharacterState.Standing);

			//check gamestate transitions
			s.ChangeState(GameState.Game);
			s.Run ();
			Assert.IsTrue(s.Gamestate == GameState.Game);

			s.ChangeState(GameState.Menu);
			s.Run ();
			Assert.IsTrue(s.Gamestate == GameState.Menu);

			s.ChangeState(GameState.Transition);
			s.Run ();
			Assert.IsTrue(s.Gamestate == GameState.Transition);

			// check menu state transtitons
			s.ChangeState(MenuState.ViewingScores);
			s.Run ();
			Assert.IsTrue(s.Menustate == MenuState.ViewingScores);

			// check level state transition
			s.ChangeState(LevelState.Level2);
			s.Run ();
			Assert.IsTrue(s.Levelstate == LevelState.Level2);

			// check transition state
			s.ChangeState(TransitionState.WinScreen);
			s.Run ();
			Assert.IsTrue(s.Transitionstate == TransitionState.WinScreen);

			//check character state transition
			s.ChangeState(CharacterState.Jumping);
			s.Run ();
			Assert.IsTrue(s.Characterstate == CharacterState.Jumping);


		}
	}
}

