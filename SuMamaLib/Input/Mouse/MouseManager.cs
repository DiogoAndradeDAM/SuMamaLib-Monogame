using System;

namespace SuMamaLib.Input.MouseInput
{
	using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

	public class MouseManager
	{
		private MouseState _prev;
		private MouseState _curr;

		public MouseManager()
		{
			_prev = Mouse.GetState();
			_curr = Mouse.GetState();
		}

		public void Update()
		{
			_prev = _curr;
			_curr = Mouse.GetState();
		}

		public void SetMouseTexture(Texture2D texture, Point position)
		{
			MouseCursor.FromTexture2D(texture, position.X, position.Y);
		}

		// Mouse Position

		public Point GetMousePosition()
		{
			return _curr.Position;
		}

		public void SetMousePosition(Point value)
		{
			Mouse.SetPosition(value.X, value.Y);
		}

		// ScrollWheelValue

		public int GetScrollWheelValue()
		{
			return _curr.ScrollWheelValue;
		}

		public bool ScrollWheelValueWasChanged()
		{
			return _prev.ScrollWheelValue - _curr.ScrollWheelValue != 0;
		}

		public bool ScrollWhellValueIncreased()
		{
			return _curr.ScrollWheelValue - _prev.ScrollWheelValue > 0;
		}

		// LeftButton

		public bool LmbIsPressed()
		{
			return _curr.LeftButton == ButtonState.Pressed;
		}

		public bool LmbIsNotPressed()
		{
			return _curr.LeftButton == ButtonState.Released;
		}

		public bool LmbWasPressed()
		{
			Console.WriteLine(_curr.LeftButton == ButtonState.Pressed && !(_prev.LeftButton == ButtonState.Pressed));
			return _curr.LeftButton == ButtonState.Pressed && !(_prev.LeftButton == ButtonState.Pressed);
		}

		public bool LmbReleased()
		{
			return !(_curr.LeftButton == ButtonState.Pressed) && _prev.LeftButton == ButtonState.Pressed;
		}

		// RightButton 

		public bool RmbIsPressed()
		{
			return _curr.RightButton == ButtonState.Pressed;
		}

		public bool RmbIsNotPressed()
		{
			return _curr.RightButton== ButtonState.Released;
		}

		public bool RmbWasPressed()
		{
			return _curr.RightButton == ButtonState.Pressed && !(_prev.RightButton == ButtonState.Pressed);
		}

		public bool RmbReleased()
		{
			return !(_curr.RightButton == ButtonState.Pressed) && _prev.RightButton == ButtonState.Pressed;
		}

		// MiddleButton

		public bool MmbIsPressed()
		{
			return _curr.MiddleButton == ButtonState.Pressed;
		}

		public bool MmbIsNotPressed()
		{
			return _curr.MiddleButton == ButtonState.Released;
		}

		public bool MmbWasPressed()
		{
			return _curr.MiddleButton == ButtonState.Pressed && !(_prev.MiddleButton == ButtonState.Pressed);
		}

		public bool MmbReleased()
		{
			return !(_curr.MiddleButton == ButtonState.Pressed) && _prev.MiddleButton == ButtonState.Pressed;
		}
	}
}
