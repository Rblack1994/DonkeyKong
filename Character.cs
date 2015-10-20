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
			SwinGameSDK.SwinGame.DrawBitmap(CharacterSprite,Xpos,Ypos);
		}
		/*public override void Draw()
		{
			switch (_statehandler.Characterstate)
			{
			case CharacterState.Standing:
				//SwinGameSDK.SwinGame.DrawBitmapPart (_charactersprite, 59, 24, 25, 431 - 176, Xpos, Ypos);
				break;
			case CharacterState.Climbing:
				//SwinGameSDK.SwinGame.DrawBitmapPart (_charactersprite, 134, 24, 25, 431 - 176, Xpos , Ypos);
				break;
			case CharacterState.Dying:

				break;
			case CharacterState.Hammer:

				break;
			case CharacterState.Moving:
				//SwinGameSDK.SwinGame.DrawBitmapPart (_charactersprite, 84 + (25 * _statecount), 24, 25, 431 - 176, Xpos, Ypos);
				_statecount++;
				_statecount = _statecount % 2;
				break;
			case CharacterState.Jumping:

				break;
			}
		}*/
	}
}

