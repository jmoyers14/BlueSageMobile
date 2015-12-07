using System;
using System.Globalization;
using Cirrious.MvvmCross.ViewModels;


namespace BlueSageMobile.Core
{
	public delegate void TableRowSelected (TableEventArgs args);

	public interface ITableRow
	{
		int RowType { get; set; }

		int RowStyle { get; set; }

		string Identifier { get; set; }

		ITableSection Section { get; }

		bool Enabled { get; set; }

		bool Selectable { get; set; }

		TableRowSelected Selected { get; set; } 
	}

	public interface ITableRow<TModel> : ITableRow where TModel : class
	{
		TModel Model { get; }
	}
}

