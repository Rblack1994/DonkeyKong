using System;
using SwinGameSDK;
using Color = System.Drawing.Color;
namespace MyGame
{
	public class Barrel : GraphicsObject
	{
		private StateHandler _statehandler;
		private int _barrelstate;
		private int _statecount;
		protected Bitmap _charactersprite;
		private bool _goingright;


		public Barrel (StateHandler _state,int posX, int posY):base(_state,posX,posY)
		{
			_statehandler = _state;
			_statecount = 0;
			_goingright = true;
		}
		public void Move ()
		{ _statecount++;
			if (Xpos == 725 || Xpos == 50)
			{
				_goingright = !_goingright; 
			}
			if (_goingright)
			{
				Xpos++;
			}
			else
			{
				Xpos--;
			}
			if (Xpos >= 700 || Xpos <= 75)
			{
				Ypos++;
			}
			if (_statecount > (8*50) && _statecount % 50 == 0 && _statecount < (74*50))
			{
				Ypos+= 3;
			}
		}

		public override void loadbitmap()
		{
			_charactersprite = SwinGame.LoadBitmap (SwinGame.PathToResource ("barrel1.png", ResourceKind.BitmapResource),true,Color.Black);
		}

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
			SwinGameSDK.SwinGame.DrawBitmap(_charactersprite,Xpos,Ypos);
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