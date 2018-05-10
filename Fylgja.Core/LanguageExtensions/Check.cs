namespace Fylgja.Core
{
	using System.Linq;
	using IBool = System.Collections.Generic.IEnumerable<bool>;


	public static partial class LanguageExtensions
	{
		public static bool[] Check<T>(this T o, params bool[] pattern) => pattern;

		public static bool All(this IBool pattern, bool value) => pattern.All(value ? Const.IsTrue : Const.IsFalse);
		public static bool Any(this IBool pattern, bool value) => pattern.Any(value ? Const.IsTrue : Const.IsFalse);
		public static int Count(this IBool pattern, bool value) => pattern.Count(value ? Const.IsTrue : Const.IsFalse);
	}
}

