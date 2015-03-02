using System;

namespace TaskManager
{
	class BadDateTimeException : Exception
	{
		public BadDateTimeException () : base("Date/Time you have entered is in the past!")
		{
		}
	}
}

