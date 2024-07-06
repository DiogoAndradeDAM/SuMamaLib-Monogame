using System;

using Microsoft.Xna.Framework;

using SuMamaLib.Items2D;

namespace SuMamaLib.Behaviour
{
    public abstract class GameObject : IDrawable, IUpdateable, IDisposable
    {
		protected int _drawOrder;
		protected int _updateOrder;
		protected bool _enabled;
		protected bool _visible;

        public event EventHandler<EventArgs> EnabledChanged;
        public event EventHandler<EventArgs> UpdateOrderChanged;
        public event EventHandler<EventArgs> DrawOrderChanged;
        public event EventHandler<EventArgs> VisibleChanged;

        public int DrawOrder
		{
			get { return _drawOrder; }
			set { _drawOrder = value; DrawOrderChanged?.Invoke(this, EventArgs.Empty); }
		}

		public int UpdateOrder
		{
			get { return _updateOrder; }
			set { _updateOrder = value; UpdateOrderChanged?.Invoke(this, EventArgs.Empty); }
		}

		public bool Enabled
		{
			get { return _enabled; }
			set { _enabled = value; EnabledChanged?.Invoke(this, EventArgs.Empty); }
		}

		public bool Visible
		{
			get { return _visible; }
			set { _visible = value; VisibleChanged?.Invoke(this, EventArgs.Empty); }
		}

		public Sprite Sprite { get; private set; }
		public Vector2 Position { get; set; }
		public float Depth { get; set; }
		public Rectangle SrcRect { get; set; }

		
		public GameObject(Vector2 pos)
		{
			Sprite = null;
			Position = pos;
			Depth = 0f;
			SrcRect = Rectangle.Empty;
		}

		public GameObject(Vector2 pos, Rectangle srcRect)
		{
			Sprite = null;
			Position = pos;
			Depth = 0f;
			SrcRect = srcRect;
		}

		public GameObject(Vector2 pos, Rectangle srcRect, float depth)
		{
			Sprite = null;
			Position = pos;
			Depth = depth;
			SrcRect = srcRect;
		}

		public void LoadSprite(Sprite sprite)
		{
			if(sprite != null) { Sprite = sprite; }
			else { throw new ArgumentNullException(); }
		}

		// Initialize the logic of the GameObject one time
		public virtual void Start()
		{
		}

		// Update the logic of the GameObject frame per frame
        public virtual void Update(GameTime gameTime)
        {
        }

		// Draw the GameObject
        public virtual void Draw(GameTime gameTime)
        {
        }

		// Dispose the GameObject
        public virtual void Dispose()
        {
			GC.SuppressFinalize(this);
        }
    }
}
