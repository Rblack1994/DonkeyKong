using System;
using SwinGameSDK;
using Color = System.Drawing.Color;
namespace MyGame
{
	public class Mario : Character
	{
		public Mario (StateHandler _state,int posX, int posY):base(_state,posX,posY)
		{
		}

		public override void loadbitmap()
		{
			_charactersprite = SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_standing.png", ResourceKind.BitmapResource),true,Color.Black);
		}
	}
}

