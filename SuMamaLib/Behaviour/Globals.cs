using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SuMamaLib.Behaviour
{
	public static class Globals
	{
		public static SpriteBatch SpriteBatch;
		public static ContentManager Content;

		public static void Initialize(GraphicsDevice graphicsDevice, ContentManager contentManager)
		{
			SpriteBatch = new SpriteBatch(graphicsDevice);
			Content = contentManager;
		}
	}
}
