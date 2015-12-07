using System;
using Cirrious.MvvmCross.ViewModels;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;

namespace BlueSageMobile.Core
{
	public class TableSection : MvxNotifyPropertyChanged, ITableSection, ITable_Private
	{
		public TableSection (string identifier = null) : base ()
		{
			Identifier = identifier;
		}

		public void SetRows (IEnumerable<ITableRow> rows)
		{
			Rows = new ObservableCollection<ITableRow> (rows ?? new ITableRow[] { });
		}

		public string Identifier { get; }

		public void AddRow (ITableRow row) 
		{
			(row as ITableRow_Private)?.__setTableSection (this);
			if (row.Section == null)
				System.Diagnostics.Debug.WriteLine ("NULL"); 

			Rows.Add (row);
		}


		ObservableCollection<ITableRow> _rows;
		public ObservableCollection<ITableRow> Rows
		{
			get { return _rows ?? (_rows = new ObservableCollection<ITableRow> ()); }
			protected set 
			{
				_rows = value;

				if (_rows != null) 
				{
					foreach (var row in _rows) 
					{
						(row as ITableRow_Private)?.__setTableSection (this);
					}
				}

				RaisePropertyChanged ();
			}
		}

	}
}

