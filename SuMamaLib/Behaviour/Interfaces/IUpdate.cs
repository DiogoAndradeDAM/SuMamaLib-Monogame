using System;

using Microsoft.Xna.Framework;

namespace SuMamaLib.Behaviour.Interfaces
{
	public interface IUpdate
	{
		public int UpdateOrder { get; set; }
		public bool Enabled { get; set; }

		event EventHandler<EventArgs> UpdateOrderChanged;
		event EventHandler<EventArgs> EnabledChanged;

		public void Update(GameTime gameTime);
	}
}
