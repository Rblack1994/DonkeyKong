using System;
using SwinGameSDK;
namespace MyGame
{
	public static class Hotkeys
	{
		public static KeyCode _left;
		public static KeyCode _right;
		public static KeyCode _jump;
		 static Hotkeys ()
		{
			_left = KeyCode.vk_LEFT;
			_right = KeyCode.vk_RIGHT;
			_jump = KeyCode.vk_UP;
		}
	}
}

