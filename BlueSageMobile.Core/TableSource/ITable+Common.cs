using System;

namespace BlueSageMobile.Core
{

	public delegate void TableChanged ();

	public delegate void TableValidationChanged ();

	public interface ITable_Common
	{
		TableChanged ValueChanged { get; set; }
		TableValidationChanged ValidationChanged { get; set; }

		bool IsValid { get; }
	}

}

