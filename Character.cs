using System;
using SwinGameSDK;
namespace MyGame
{
	public abstract class Character : GraphicsObject
	{
		private StateHandler _statehandler;
		private int _statecount;
		protected Bitmap[] _charactersprites;
		protected Bitmap _sprite;
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
				if (_statehandler != null)
				{
					switch (_statehandler.Characterstate)
					{
					case CharacterState.Standing:
						return _charactersprites [0];
						break;
					case CharacterState.Climbing:
						return _charactersprites [0];
						break;

					case CharacterState.Dying:
						if (_statecount < 30)
						{
							return _charactersprites [7];
						}
						else if (_statecount < 60)
						{
							return _charactersprites [8];
						}
						else
							return _charactersprites [9];
						break;

					case CharacterState.Hammer:
						return _charactersprites [0];
						break;
					case CharacterState.Moving:
						if (_goingright)
						{
							if ((_statecount % 20) > 10)
							{
								return _charactersprites [1];
							}
							else
							{
								return _charactersprites [3];
							}
						}
						else
						{
							if ((_statecount % 20) > 10)
							{
								return _charactersprites [2];
							}
							else
							{
								return _charactersprites [4];
							}
						}
						break;
					case CharacterState.Jumping:
						if (_goingright)
						{
							return _charactersprites [5];
						}
						else
						{
							return _charactersprites [6];
						}
						break;
					default :
						return _charactersprites [0];
					}
				}
				else
				{
					return _charactersprites [0];
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

		public StateHandler _cstate
		{
			get
			{
				return _statehandler;
			}
		}

		public override void Draw()
		{
			SwinGameSDK.SwinGame.DrawBitmap(CharacterSprite, Xpos, Ypos);
		}

		public bool Goingright 
		{
			get
			{
				return _goingright;
			}
			set
			{
				_goingright = value;
			}
		}
	}
}

