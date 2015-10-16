using System;
using SwinGameSDK;
namespace MyGame
{
	public abstract class GraphicsObject
	{
		public float Xpos;
		public float Ypos;
		private StateHandler _statehandler;

		public GraphicsObject  (StateHandler _state,int posX, int posY)
		{
			Xpos = posX;
			Ypos = posY;
			_statehandler = _state;
			loadbitmap ();
		}

		public abstract void Draw ();

		public abstract void loadbitmap ();
	}
}

