using NUnit.Framework;
using System;
using SwinGameSDK;

namespace MyGame
{
	[TestFixture ()]
	public class ObjectHandlerTest
	{
		[Test ()]
		public void TestCaseBarrelCollide ()
		{
			// test character dies when hit by barrel
			StateHandler s = new StateHandler ();
			ObjectsHandler h = new ObjectsHandler (s);

			// adds a barrel at location 100,119
			h.AddBarrel ();
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

		[Test ()]
		public void TestCaseCharPosReset ()
		{
			// test that character starts in default position after the level resets
			StateHandler sh = new StateHandler ();
			ObjectsHandler oh = new ObjectsHandler (sh);
			Input_Handler ih = new Input_Handler(sh,oh);

			Character c = oh.LevelCharacter;
			c.Xpos = 150;
			c.Ypos = 250;

			ih.ResetCharacter ();

			// check that is at defualt pos
			Assert.IsTrue (c.Xpos == 110);
			Assert.IsTrue (c.Ypos == 552);
			Assert.IsTrue (sh.Gamestate == GameState.Menu);
			Assert.IsTrue (sh.Characterstate == CharacterState.Standing);

		}
		// requires more structured collison coding
		// need to figure out geometry of sprites for head - where is pixel 1x1?
		/*[Test ()]
		public void TestCaseplatformcollision ()
		{
			// checks collisions with platform
			StateHandler s = new StateHandler ();
			ObjectsHandler h = new ObjectsHandler (s);
			Character c = h.LevelCharacter;

			c.Statecount = 63;
			s.ChangeState (CharacterState.Standing);
			s.Run ();
			//head collision

			int y = 581;
			c.Xpos = 50;
			c.Ypos = y;

			h.LevelCharacterObject ();
			Assert.IsTrue (c.Ypos == y-1);

			//foot collision - working
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

