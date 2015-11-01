using NUnit.Framework;
using System;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ObjectHandlerTest
	{
		[Test ()]
		public void TestCase ()
		{
			StateHandler s = new StateHandler ();
			ObjectsHandler h = new ObjectsHandler (s);

			// adds a barrel at location 100,119
			h.AddBarrel (); // addbarrel function required.
			Character c = h.LevelCharacter;
			c.Xpos = 100;
			c.Ypos = 119;
			Assert.IsTrue (h.LevelCharacter.Xpos == 100);
			Assert.IsTrue (h.LevelCharacter.Ypos == 119);
			Assert.IsTrue (s.Characterstate == CharacterState.Standing);

			h.LevelCharacterObject ();
			s.Run ();
			Assert.IsTrue (s.Characterstate == CharacterState.Dying);

		}

		// needs revision
		/*[Test ()]
		public void TestCaseplatformcollision ()
		{

			StateHandler s = new StateHandler ();
			ObjectsHandler h = new ObjectsHandler (s);
			Character c = h.LevelCharacter;

			c.Statecount = 63;
			s.ChangeState (CharacterState.Standing);
			s.Run ();
			//head

			int y = 581;
			c.Xpos = 50;
			c.Ypos = y;

			h.LevelCharacterObject ();
			Assert.IsTrue (c.Ypos == y-1);

			foot - working
			c.Statecount = 67;
			s.ChangeState (CharacterState.Jumping);
			s.Run ();

			y = 581;
			c.Xpos = 50;
			c.Ypos = y;
			h.LevelCharacterObject ();
			Assert.IsTrue (c.Ypos == y-1);

		}*/
	}
}

