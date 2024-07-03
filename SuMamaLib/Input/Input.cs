using SuMamaLib.Input.KeyboardInput;
using SuMamaLib.Input.MouseInput;

namespace SuMamaLib.Input
{
	public static class Input
	{
		public static KeyboardManager Keyboard;
		public static MouseManager Mouse;

		public static void Initialize()
		{
			Keyboard = new KeyboardManager();
			Mouse = new MouseManager();
		}

		public static void Update()
		{
			Keyboard.Update();
			Mouse.Update();
		}
	}
}
