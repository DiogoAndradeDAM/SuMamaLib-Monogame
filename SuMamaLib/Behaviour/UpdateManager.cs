using System.Collections.Generic;
using System;

using Microsoft.Xna.Framework;

using SuMamaLib.Behaviour.Interfaces;

namespace SuMamaLib.Behaviour
{
	public class UpdateManager
	{
		private List<IUpdate> _updateList;

		public int Count { get { return _updateList.Count; } }

		public UpdateManager()
		{
			_updateList = new();
		}

		public void Add(IUpdate obj)
		{
			if(obj == null) { throw new NullReferenceException(); }
			_updateList.Add(obj);
		}

		public void Remove(IUpdate obj)
		{
			if(obj == null) { throw new NullReferenceException(); }
			_updateList.Remove(obj);
		}

		public void RemoveAll(IUpdate obj)
		{
			if(obj == null) { throw new NullReferenceException(); }
			_updateList.RemoveAll(item => item == obj);
		}

		public void Update(GameTime gameTime)
		{
			foreach(var item in _updateList)
			{
				item.Update(gameTime);
			}
		}
	}
}
