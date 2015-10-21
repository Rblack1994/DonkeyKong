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
		_sprite = SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_standing.png", ResourceKind.BitmapResource), true, Color.Black);
		_charactersprites = new Bitmap[] {
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_standing.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_running0.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_running0Right.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_running1.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_running1Right.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_jumping.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_jumpingRight.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_dieing0.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_dieing1.png", ResourceKind.BitmapResource), true, Color.Black),
				SwinGame.LoadBitmap (SwinGame.PathToResource ("mario_dieing2.png", ResourceKind.BitmapResource), true, Color.Black)
			};
		}
	}
}

