using System;
using SwinGameSDK;
using Color = System.Drawing.Color;
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

		public static void ChangeKey(ref KeyCode toChange)
		{	
			string key = toChange.ToString ();
			do{
				bool change = false;
				bool same = false;
				SwinGame.ProcessEvents ();
				SwinGame.DrawText ("press the key which" + key + "should be changed to ? ", Color.White, "arial", 26, 100, 100);
				foreach (KeyCode value in keycodes)
				{
					change = false;
					same = false;
					if (SwinGame.KeyTyped (value))
					{
						change = true;
						foreach(KeyCode value2 in Hotkeys.Currentkeys())
						{
							if (value == value2) 
							{
								same = true;
							}
						}
					}
					if(change && (!same))
					{
						toChange = value;
					}
				}
				SwinGame.RefreshScreen();
			} while (!SwinGame.AnyKeyPressed());
		}

		public static KeyCode[] Currentkeys ()
		{
			return new KeyCode[] {
				_left,
				_right,
				_up,
				_down,
				_jump,
				_pause
			};
		}

		public static KeyCode[] keycodes = {
			KeyCode.vk_Unknown,
			KeyCode.vk_BACKSPACE,
			KeyCode.vk_TAB,
			KeyCode.vk_CLEAR,
			KeyCode.vk_RETURN,
			KeyCode.vk_PAUSE,
			KeyCode.vk_ESCAPE,
			KeyCode.vk_SPACE,
			KeyCode.vk_EXCLAIM,
			KeyCode.vk_QUOTEDBL,
			KeyCode.vk_HASH,
			KeyCode.vk_DOLLAR,
			KeyCode.vk_AMPERSAND,
			KeyCode.vk_QUOTE,
			KeyCode.vk_LEFTPAREN,
			KeyCode.vk_RIGHTPAREN,
			KeyCode.vk_ASTERISK,
			KeyCode.vk_PLUS,
			KeyCode.vk_COMMA,
			KeyCode.vk_MINUS,
			KeyCode.vk_PERIOD,
			KeyCode.vk_SLASH,
			KeyCode.vk_0,
			KeyCode.vk_1,
			KeyCode.vk_2,
			KeyCode.vk_3,
			KeyCode.vk_4,
			KeyCode.vk_5,
			KeyCode.vk_6,
			KeyCode.vk_7,
			KeyCode.vk_8,
			KeyCode.vk_9,
			KeyCode.vk_COLON,
			KeyCode.vk_SEMICOLON,
			KeyCode.vk_LESS,
			KeyCode.vk_EQUALS,
			KeyCode.vk_GREATER,
			KeyCode.vk_QUESTION,
			KeyCode.vk_AT,
			KeyCode.vk_LEFTBRACKET,
			KeyCode.vk_BACKSLASH,
			KeyCode.vk_RIGHTBRACKET,
			KeyCode.vk_CARET,
			KeyCode.vk_UNDERSCORE,
			KeyCode.vk_BACKQUOTE,
			KeyCode.vk_a,
			KeyCode.vk_b,
			KeyCode.vk_c,
			KeyCode.vk_d,
			KeyCode.vk_e,
			KeyCode.vk_f,
			KeyCode.vk_g,
			KeyCode.vk_h,
			KeyCode.vk_i,
			KeyCode.vk_j,
			KeyCode.vk_k,
			KeyCode.vk_l,
			KeyCode.vk_m,
			KeyCode.vk_n,
			KeyCode.vk_o,
			KeyCode.vk_p,
			KeyCode.vk_q,
			KeyCode.vk_r,
			KeyCode.vk_s,
			KeyCode.vk_t,
			KeyCode.vk_u,
			KeyCode.vk_v,
			KeyCode.vk_w,
			KeyCode.vk_x,
			KeyCode.vk_y,
			KeyCode.vk_z,
			KeyCode.vk_DELETE,
			KeyCode.vk_WORLD_0,
			KeyCode.vk_WORLD_1,
			KeyCode.vk_WORLD_2,
			KeyCode.vk_WORLD_3,
			KeyCode.vk_WORLD_4,
			KeyCode.vk_WORLD_5,
			KeyCode.vk_WORLD_6,
			KeyCode.vk_WORLD_7,
			KeyCode.vk_WORLD_8,
			KeyCode.vk_WORLD_9,
			KeyCode.vk_WORLD_10,
			KeyCode.vk_WORLD_11,
			KeyCode.vk_WORLD_12,
			KeyCode.vk_WORLD_13,
			KeyCode.vk_WORLD_14,
			KeyCode.vk_WORLD_15,
			KeyCode.vk_WORLD_16,
			KeyCode.vk_WORLD_17,
			KeyCode.vk_WORLD_18,
			KeyCode.vk_WORLD_19,
			KeyCode.vk_WORLD_20,
			KeyCode.vk_WORLD_21,
			KeyCode.vk_WORLD_22,
			KeyCode.vk_WORLD_23,
			KeyCode.vk_WORLD_24,
			KeyCode.vk_WORLD_25,
			KeyCode.vk_WORLD_26,
			KeyCode.vk_WORLD_27,
			KeyCode.vk_WORLD_28,
			KeyCode.vk_WORLD_29,
			KeyCode.vk_WORLD_30,
			KeyCode.vk_WORLD_31,
			KeyCode.vk_WORLD_32,
			KeyCode.vk_WORLD_33,
			KeyCode.vk_WORLD_34,
			KeyCode.vk_WORLD_35,
			KeyCode.vk_WORLD_36,
			KeyCode.vk_WORLD_37,
			KeyCode.vk_WORLD_38,
			KeyCode.vk_WORLD_39,
			KeyCode.vk_WORLD_40,
			KeyCode.vk_WORLD_41,
			KeyCode.vk_WORLD_42,
			KeyCode.vk_WORLD_43,
			KeyCode.vk_WORLD_44,
			KeyCode.vk_WORLD_45,
			KeyCode.vk_WORLD_46,
			KeyCode.vk_WORLD_47,
			KeyCode.vk_WORLD_48,
			KeyCode.vk_WORLD_49,
			KeyCode.vk_WORLD_50,
			KeyCode.vk_WORLD_51,
			KeyCode.vk_WORLD_52,
			KeyCode.vk_WORLD_53,
			KeyCode.vk_WORLD_54,
			KeyCode.vk_WORLD_55,
			KeyCode.vk_WORLD_56,
			KeyCode.vk_WORLD_57,
			KeyCode.vk_WORLD_58,
			KeyCode.vk_WORLD_59,
			KeyCode.vk_WORLD_60,
			KeyCode.vk_WORLD_61,
			KeyCode.vk_WORLD_62,
			KeyCode.vk_WORLD_63,
			KeyCode.vk_WORLD_64,
			KeyCode.vk_WORLD_65,
			KeyCode.vk_WORLD_66,
			KeyCode.vk_WORLD_67,
			KeyCode.vk_WORLD_68,
			KeyCode.vk_WORLD_69,
			KeyCode.vk_WORLD_70,
			KeyCode.vk_WORLD_71,
			KeyCode.vk_WORLD_72,
			KeyCode.vk_WORLD_73,
			KeyCode.vk_WORLD_74,
			KeyCode.vk_WORLD_75,
			KeyCode.vk_WORLD_76,
			KeyCode.vk_WORLD_77,
			KeyCode.vk_WORLD_78,
			KeyCode.vk_WORLD_79,
			KeyCode.vk_WORLD_80,
			KeyCode.vk_WORLD_81,
			KeyCode.vk_WORLD_82,
			KeyCode.vk_WORLD_83,
			KeyCode.vk_WORLD_84,
			KeyCode.vk_WORLD_85,
			KeyCode.vk_WORLD_86,
			KeyCode.vk_WORLD_87,
			KeyCode.vk_WORLD_88,
			KeyCode.vk_WORLD_89,
			KeyCode.vk_WORLD_90,
			KeyCode.vk_WORLD_91,
			KeyCode.vk_WORLD_92,
			KeyCode.vk_WORLD_93,
			KeyCode.vk_WORLD_94,
			KeyCode.vk_WORLD_95,
			KeyCode.vk_KP0,
			KeyCode.vk_KP1,
			KeyCode.vk_KP2,
			KeyCode.vk_KP3,
			KeyCode.vk_KP4,
			KeyCode.vk_KP5,
			KeyCode.vk_KP6,
			KeyCode.vk_KP7,
			KeyCode.vk_KP8,
			KeyCode.vk_KP9,
			KeyCode.vk_KP_PERIOD,
			KeyCode.vk_KP_DIVIDE,
			KeyCode.vk_KP_MULTIPLY,
			KeyCode.vk_KP_MINUS,
			KeyCode.vk_KP_PLUS,
			KeyCode.vk_KP_ENTER,
			KeyCode.vk_KP_EQUALS,
			KeyCode.vk_UP,
			KeyCode.vk_DOWN,
			KeyCode.vk_RIGHT,
			KeyCode.vk_LEFT,
			KeyCode.vk_INSERT,
			KeyCode.vk_HOME,
			KeyCode.vk_END,
			KeyCode.vk_PAGEUP,
			KeyCode.vk_PAGEDOWN,
			KeyCode.vk_F1,
			KeyCode.vk_F2,
			KeyCode.vk_F3,
			KeyCode.vk_F4,
			KeyCode.vk_F5,
			KeyCode.vk_F6,
			KeyCode.vk_F7,
			KeyCode.vk_F8,
			KeyCode.vk_F9,
			KeyCode.vk_F10,
			KeyCode.vk_F11,
			KeyCode.vk_F12,
			KeyCode.vk_F13,
			KeyCode.vk_F14,
			KeyCode.vk_F15,
			KeyCode.vk_NUMLOCK,
			KeyCode.vk_CAPSLOCK,
			KeyCode.vk_SCROLLOCK,
			KeyCode.vk_RSHIFT,
			KeyCode.vk_LSHIFT,
			KeyCode.vk_RCTRL,
			KeyCode.vk_LCTRL,
			KeyCode.vk_RALT,
			KeyCode.vk_LALT,
			KeyCode.vk_RMETA,
			KeyCode.vk_LMETA,
			KeyCode.vk_LSUPER,
			KeyCode.vk_RSUPER,
			KeyCode.vk_MODE,
			KeyCode.vk_COMPOSE,
			KeyCode.vk_HELP,
			KeyCode.vk_PRINT,
			KeyCode.vk_SYSREQ,
			KeyCode.vk_BREAK,
			KeyCode.vk_MENU,
			KeyCode.vk_POWER,
			KeyCode.vk_EURO
		};
	}
}

