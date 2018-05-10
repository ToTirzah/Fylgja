namespace Fylgja.Core
{
	using System;

	public static partial class LanguageExtensions
	{
		public static T Call<T>(this T o, Action action)
		{
			action();
			return o;
		}

		public static T Use<T>(this T o, Action<T> action)
		{
			action(o);
			return o;
		}

		public static T Use<T, TR>(this T o, Func<TR> func) => func().Put(o);
		public static T Use<T, TR>(this T o, Func<T, TR> func) => func(o).Put(o);
		public static T Use<T, TA>(this T o, out TA x, TA a = default(TA)) => (x = a).Put(o); // o.Use(out var x, 2)
	}
}

