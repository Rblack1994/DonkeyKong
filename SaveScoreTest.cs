using NUnit.Framework;
using System;
using SwinGameSDK;
using System.IO;

namespace MyGame
{
	[TestFixture ()]
	public class SaveScoreTest
	{
		[Test ()]
		public void TestCaseSaveScores ()
		{
			//uncomment when all the functions have been created
			/*StateHandler _statehandler = new StateHandler ();
			ObjectsHandler _objecthandler = new ObjectsHandler (_statehandler);
			GraphicsHandler g = new GraphicsHandler (_statehandler, _objecthandler);

			string PlayerName = "AAA";
			string Player2Name = "BBB";

			g.ClearScores ();  				// CLearScores function must be created
			g.RecordScore (PlayerName,50);  // RecordScore function must be created
			g.RecordScore (Player2Name,200);	// RecordScore function must be created

			g.WriteScores ();		// WriteScores function must be created

			string filename = null;
			filename = SwinGame.PathToResource("highscores.txt");

			// manually reading scores
			StreamReader input = default(StreamReader);
			input = new StreamReader(filename);

			//Read in the # of scores
			int numScores = 0;
			numScores = Convert.ToInt32(input.ReadLine());
			Assert.IsTrue (numScores == 2);

			string line;

			line = input.ReadLine();
			Assert.IsTrue (line == "BBB200");

			line = input.ReadLine();
			Assert.IsTrue (line == "AAA50");

			input.Close();*/

		}
	}
}

