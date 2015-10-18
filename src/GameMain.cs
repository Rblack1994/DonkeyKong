using System;
using System.Reflection;
using SwinGameSDK;
using Color = System.Drawing.Color;
namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            //Start the audio system so sound can be played
            SwinGame.OpenAudio();
            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            SwinGame.ShowSwinGameSplashScreen();
			StateHandler _statehandler = new StateHandler ();
			ObjectsHandler _objecthandler = new ObjectsHandler (_statehandler);
			Input_Handler _inputhandler = new Input_Handler(_statehandler,_objecthandler);
			GraphicsHandler _graphicshandler = new GraphicsHandler (_statehandler,_objecthandler);

            //Run the game loop
            while(false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();
                //Clear the screen and draw the framerate
				SwinGame.ClearScreen(Color.Black);
				_graphicshandler.Run ();
				_objecthandler.Run ();
				_inputhandler.Run ();
				_statehandler.Run ();

                SwinGame.DrawFramerate(0,0);
                //Draw onto the screen
                SwinGame.RefreshScreen();
				System.Threading.Thread.Sleep (2);
            }
            //End the audio
            SwinGame.CloseAudio();
            
            //Close any resources we were using
            SwinGame.ReleaseAllResources();
        }
    }
}