using System;
using SwinGameSDK;
namespace MyGame
{
	public static class Hotkeys
	{
		public static KeyCode _left;
		public static KeyCode _right;
		public static KeyCode _up;
		public static KeyCode _down;
		public static KeyCode _jump;
		public static KeyCode _pause;
		 static Hotkeys ()
		{
			_left = KeyCode.vk_LEFT;
			_right = KeyCode.vk_RIGHT;
			_up = KeyCode.vk_UP;
			_down = KeyCode.vk_DOWN;
			_jump = KeyCode.vk_SPACE;
			_pause = KeyCode.vk_p;

		}
	}
}

