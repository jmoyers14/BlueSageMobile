using System;

namespace BlueSageMobile.Core
{
	public partial interface ITable_Private
	{
		void __tableValueChanged (TableEventArgs args);
		void __tableValidationChanged (TableValidationEventArgs args);
	}
}

