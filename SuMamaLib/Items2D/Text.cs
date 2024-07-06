using System;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SuMamaLib.Items2D
{
	public class Text
	{
		public SpriteFont Font { get; private set; }
		public StringBuilder Wording { get; private set; }
		public int LineSpacing 
		{
			get { return Font.LineSpacing; }
			set { Font.LineSpacing = value; }
		}

		public float Spacing 
		{ 
			get { return Font.Spacing; }
			set { Font.Spacing = value; }
		}

		public int Size { get; private set; }
		public Vector2 Position { get; set; }
		public float Rotate { get; set; }
		public Vector2 Scale { get; set; }
		public Vector2 Origin { get; set; }
		public SpriteEffects SpriteEffects { get; set; }
		public Color Color { get; set; }


		public Text(StringBuilder wording)
		{
			if(wording != null) { Wording = wording; }
			else { throw new ArgumentNullException("ERROR: The text loaded in Text is null"); }
			Font = null;
			Size = 0;
			Position = Vector2.Zero;
			Rotate = 0f;
			Scale = Vector2.One;
			Origin = Vector2.Zero;
			SpriteEffects = SpriteEffects.None;
			Color = Color.White;
		}

		public Text(StringBuilder wording, Vector2 pos)
		{
			if(wording != null) { Wording = wording; }
			else { throw new ArgumentNullException("ERROR: The text loaded in Text is null"); }
			Font = null;
			Size = 0;
			Position = pos;
			Rotate = 0f;
			Scale = Vector2.One;
			Origin = Vector2.Zero;
			SpriteEffects = SpriteEffects.None;
			Color = Color.White;
		}

		public Text(StringBuilder wording, Vector2 pos, Vector2 scale)
		{
			if(wording != null) { Wording = wording; }
			else { throw new ArgumentNullException("ERROR: The text loaded in Text is null"); }
			Font = null;
			Size = 0;
			Position = pos;
			Rotate = 0f;
			Scale = scale; 
			Origin = Vector2.Zero;
			SpriteEffects = SpriteEffects.None;
			Color = Color.White;
		}

		public Text(StringBuilder wording, Vector2 pos, Vector2 scale, Vector2 origin)
		{
			if(wording != null) { Wording = wording; }
			else { throw new ArgumentNullException("ERROR: The text loaded in Text is null"); }
			Font = null;
			Size = 0;
			Position = pos;
			Rotate = 0f;
			Scale = scale; 
			Origin = origin; 
			SpriteEffects = SpriteEffects.None;
			Color = Color.White;
		}

		public Text(StringBuilder wording, Vector2 pos, Vector2 scale, Vector2 origin, Color color)
		{
			if(wording != null) { Wording = wording; }
			else { throw new ArgumentNullException("ERROR: The text loaded in Text is null"); }
			Font = null;
			Position = pos;
			Size = 0;
			Rotate = 0f;
			Scale = scale; 
			Origin = origin; 
			SpriteEffects = SpriteEffects.None;
			Color = color;
		}

		public void LoadFont(SpriteFont font, int size)
		{
			if(font != null)
			{
				Font = font;
				Size = size;
			}
			else { throw new ArgumentNullException("ERROR: Font loaded in LoadFont is null"); }
		}

		public void LoadText(StringBuilder wording)
		{
			if(wording != null) { Wording = wording; }
			else { throw new ArgumentNullException("ERROR: The text loaded in LoadText is null"); }
		}

	}
}
