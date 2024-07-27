using System;
using System.Collections.Generic;

using SuMamaLib.Behaviour.Interfaces;

namespace SuMamaLib.Behaviour
{
	public class DrawManager
	{
		private Dictionary<short, List<IDraw>> _drawList;

		public DrawManager()
		{
			_drawList = new();
		}

		public void CreateLayer(short layer)
		{
			_drawList[layer] = new List<IDraw>();
		}

		public void CreateLayer(short layer, List<IDraw> list)
		{
			if(list == null) { throw new NullReferenceException(); }
			_drawList[layer] = list;
		}

		public void CreateLayers(short[] layers)
		{
			foreach(short layer in layers)
			{
				_drawList[layer] = new List<IDraw>();
			}
		}

		public void RemoveLayer(short layer)
		{
			if(_drawList[layer] == null) { return; }

			_drawList.Remove(layer);
		}

		public void RemoveLayers(short[] layers)
		{
			foreach(short layer in layers)
			{
				if(_drawList[layer] == null) { continue; }

				_drawList.Remove(layer);
			}
		}

		public void AddItem(IDraw obj, short layer)
		{
			if(obj == null) { throw new NullReferenceException("The obj is null"); }

			_drawList[layer].Add(obj);
		}

		public void RemoveItem(IDraw obj, short layer)
		{
			if(obj == null) { throw new NullReferenceException("The obj is null"); }

			_drawList[layer].Remove(obj);
		}

		public void ClearLayer(short layer)
		{
			_drawList[layer].Clear();
		}

		public void Clear()
		{
			_drawList.Clear();
		}

		public void Draw()
		{
			foreach(short layer in _drawList.Keys)
			{
				foreach(IDraw item in _drawList[layer])
				{
					item.Draw();
				}
			}
		}



	}
}
