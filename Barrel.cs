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
		protected Bitmap _charactersprite0;
		protected Bitmap _charactersprite1;
		protected Bitmap _charactersprite2;
		protected Bitmap _charactersprite3;
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
				if (_statecount % 25 == 0)
				{
					_barrelstate++;
				}
				_barrelstate = _barrelstate % 4;
			}
			else
			{
				Xpos--;
				if (_statecount % 25 == 0)
				{
					_barrelstate--;
				}
				if (_barrelstate < 0)
				{
					_barrelstate = 3;
				}
				_barrelstate = _barrelstate % 4;
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
			_charactersprite0 = SwinGame.LoadBitmap (SwinGame.PathToResource ("barrel0.png", ResourceKind.BitmapResource),true,Color.Black);
			_charactersprite1 = SwinGame.LoadBitmap (SwinGame.PathToResource ("barrel1.png", ResourceKind.BitmapResource),true,Color.Black);
			_charactersprite2 = SwinGame.LoadBitmap (SwinGame.PathToResource ("barrel2.png", ResourceKind.BitmapResource),true,Color.Black);
			_charactersprite3 = SwinGame.LoadBitmap (SwinGame.PathToResource ("barrel3.png", ResourceKind.BitmapResource),true,Color.Black);
		}

		public Bitmap CharacterSprite
		{
			get
			{
				switch (_barrelstate)
				{
				case 0:
					return _charactersprite0;
					break;
				case 1:
					return _charactersprite1;
					break;
				case 2:
					return _charactersprite2;
					break;
				case 3:
					return _charactersprite3;
					break;
				default :
					return _charactersprite0;
				}
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
	}
}