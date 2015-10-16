using System;
using SwinGameSDK;
namespace MyGame
{
	public abstract class Character : GraphicsObject
	{
		private StateHandler _statehandler;
		private int _statecount;
		protected Bitmap _charactersprite;
		private bool _goingright;

		public Character (StateHandler _state,int posX, int posY):base(_state,posX,posY)
		{
			_statehandler = _state;
			_statecount = 0;
			_goingright = true;
		}

		public override abstract void loadbitmap();

		public Bitmap CharacterSprite
		{
			get
			{
				return _charactersprite;
			}
		}

		public int Statecount
		{
			get
			{
				return _statecount;
			}
			set
			{
				_statecount = value;
			}
		}

		public override void Draw()
		{
		}
	}
}

