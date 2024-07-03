namespace SuMamaLib.Input.KeyboardInput
{
using Microsoft.Xna.Framework.Input;

	public class KeyboardManager
	{
		private KeyboardState _prev;
		private KeyboardState _curr;

		public KeyboardManager()
		{
			_prev = Keyboard.GetState();
			_curr = Keyboard.GetState();
		}

		public void Update()
		{
			_prev = _curr;
			_curr = Keyboard.GetState();
		}

		public bool KeyIsPressed(Keys key)
		{
			return _curr.IsKeyDown(key);
		}

		public bool KeyIsNotPressed(Keys key)
		{
			return _curr.IsKeyUp(key);
		}

		public bool KeyWasPressed(Keys key)
		{
			return _curr.IsKeyDown(key) && !(_prev.IsKeyDown(key));
		}

		public bool KeyReleased(Keys key)
		{
			return !(_curr.IsKeyDown(key)) && _prev.IsKeyDown(key);
		}

		public bool KeysIsPressed(Keys[] keys)
		{
			foreach(var key in keys)
			{
				if(!_curr.IsKeyDown(key)) { return false; }
			}

			return true;
		}

		public bool KeysIsNotPressed(Keys[] keys)
		{
			foreach(var key in keys)
			{
				if(!_curr.IsKeyUp(key)) { return false; }
			}

			return true;
		}


		public bool KeysWasPressed(Keys[] keys)
		{
			foreach(var key in keys)
			{
				if(!(_curr.IsKeyDown(key)) && _prev.IsKeyDown(key)) { return false; }
			}

			return true;
		}
		
		public bool KeysReleased(Keys[] keys)
		{
			foreach(var key in keys)
			{
				if(_curr.IsKeyDown(key) && !(_prev.IsKeyDown(key))) { return false; }
			}

			return true;
		}

	}
}
