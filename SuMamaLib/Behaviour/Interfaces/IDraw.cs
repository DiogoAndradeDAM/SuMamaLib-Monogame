using System;

namespace SuMamaLib.Behaviour.Interfaces
{
	public interface IDraw
	{
        public int DrawOrder { get; set; }
		public bool Visible { get; set; }

		protected event EventHandler<EventArgs> DrawOrderChanged;
		protected event EventHandler<EventArgs> VisibleChanged;

        public void Draw();
	}
}
