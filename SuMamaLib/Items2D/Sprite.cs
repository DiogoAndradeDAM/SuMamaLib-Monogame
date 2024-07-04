using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SuMamaLib.Items2D
{
	public class Sprite
	{
		public readonly Texture2D Texture;

		public int Width { get; set; }
		public int Height { get; set; }
		public float Rotate { get; set; }
		public Vector2 Origin { get; set; }
		public Vector2 Scale { get; set; }
		public Color Color { get; set; }
		public SpriteEffects SpriteEffects { get; set; }

		public Sprite(Texture2D texture)
		{
			if(texture != null) { Texture = texture; }
			else { throw new ArgumentNullException(); }

			Width = texture.Width;
			Height = texture.Height;
			Rotate = 0f;
			Origin = Vector2.Zero;
			Scale = Vector2.One;
			Color = Color.White;
			SpriteEffects = SpriteEffects.None;
		}

		public Sprite(Texture2D texture, Vector2 scale)
		{
			if(texture != null) { Texture = texture; }
			else { throw new ArgumentNullException(); }

			Width = texture.Width;
			Height = texture.Height;
			Rotate = 0f;
			Origin = Vector2.Zero;
			Scale = scale;
			Color = Color.White;
			SpriteEffects = SpriteEffects.None;
		}

		public Sprite(Texture2D texture, Vector2 scale, Color color)
		{
			if(texture != null) { Texture = texture; }
			else { throw new ArgumentNullException(); }

			Width = texture.Width;
			Height = texture.Height;
			Rotate = 0f;
			Origin = Vector2.Zero;
			Scale = scale; 
			Color = color;
			SpriteEffects = SpriteEffects.None;
		}
		
	}
}
