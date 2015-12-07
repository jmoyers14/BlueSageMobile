using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;

namespace BlueSageMobile.Core
{
	public interface ITableSection : ITable_Common, IMvxNotifyPropertyChanged
	{
		ObservableCollection<ITableRow> Rows { get; }

		ITableSource Table { get; }

		string Identifier { get; }

		void SetRows (IEnumerable<ITableRow> rows);

		void AddRow (ITableRow row);

		void AddRows (params ITableRow[] rows);

		void RemoveRows (params ITableRow[] rows);

		void RemoveRow (params ITableRow[] row);

		void InsertRow (int index, ITableRow row);

		ITableRow GetRow (string identifier);

		void Validate ();
	}
}

