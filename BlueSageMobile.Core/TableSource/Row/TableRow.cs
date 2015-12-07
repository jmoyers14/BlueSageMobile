using System;
using Cirrious.MvvmCross.ViewModels;

namespace BlueSageMobile.Core
{
	public class TableRow<TModel> : MvxNotifyPropertyChanged, ITableRow<TModel> where TModel : class
	{
		public TableRow (string identifier, int rowType = 0, int rowStyle = 0) : base ()
		{
		}

		public TableRow () : this (null, 0, 0) { }

		public virtual int RowType { get; set; }

		public virtual int RowStyle { get; set; }

		public string Identifier { get; set; }


		WeakReference<ITableSection> _weakSection;
		public virtual ITableSection Section
		{
			get 
			{
				ITableSection section = null;
				if (_weakSection != null)
					_weakSection.TryGetTarget (out section);
				return section;
			}
			protected set 
			{
				if (_weakSection == null)
					_weakSection = new WeakReference<ITableSection> (value);
				else
					_weakSection.SetTarget (value);
			}
		}

		bool _enabled;
		public virtual bool Enabled
		{
			get { return _enabled; }
			set { _enabled = value; RaisePropertyChanged (); }
		}

		bool _selectable;
		public virtual bool Selectable
		{
			get { return _selectable; }
			set { _selectable = value; RaisePropertyChanged (); }
		}

		public TableRowSelected Selected { get; set; }

		TModel _model;
		public TModel Model
		{
			get { return _model ?? WeakModel; }
			set { _model = value; }
		}

		WeakReference<TModel> _weakModel;
		public TModel WeakModel
		{
			get 
			{
				TModel model = default(TModel);
				if (_weakModel != null)
					_weakModel.TryGetTarget (out model);
				return model ?? _model;
			}
			set 
			{
				if (_weakModel == null)
					_weakModel = new WeakReference<TModel> (value);
				else
					_weakModel.SetTarget (value);
			}
		}

		public void __setTableSection (ITableSection section) 
		{
			Section = section;
		}


	}

	/*
	public class TableRow : ITableRow<object>, ITableRow
	{
		public TableRow (string identifier, int rowType, int rowStyle) : base (identifier, rowType, rowStyle)
		{
		}

		public TableRow () : base ()
		{
		}
	}
	*/
}

