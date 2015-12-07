using System;
using System.Collections.Generic;

namespace BlueSageMobile.Core
{
	public class StoresSelectionViewInitModel
	{
		List<Store> _stores;

		public StoresSelectionViewInitModel () : base ()
		{
		}

		public List<Store> Stores {
			get {
				return _stores;
			}
			set {
				_stores = value;
			}
		}

	}
}

