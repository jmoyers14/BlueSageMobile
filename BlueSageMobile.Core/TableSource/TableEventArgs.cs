using System;

namespace BlueSageMobile.Core
{
	public class TableEventArgs : EventArgs
	{
		public ITableRow Row { get; }

		public TableEventArgs (ITableRow row) : base () 
		{
			Row = row;
		}
	}
}

