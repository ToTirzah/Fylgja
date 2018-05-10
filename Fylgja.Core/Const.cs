namespace Fylgja.Core
{
	using System;

	public static class Const<T>
	{
		public static readonly Func<T, bool> IsNull = LanguageExtensions.IsNull;
		public static readonly Func<T, bool> Is = LanguageExtensions.Is;
	}

	public static class Const
	{
		public const object Null = null;
		public static readonly Func<bool, bool> Not = _isFalse;
		public static readonly Func<bool, bool> IsTrue = _isTrue;
		public static readonly Func<bool, bool> IsFalse = _isFalse;
		public static readonly Func<object, bool> IsNull = LanguageExtensions.IsNull;
		public static readonly Func<object, bool> Is = LanguageExtensions.Is;
		public static readonly Action NotImplementedException = () => throw new NotImplementedException();
		public static readonly Action Stub = () => { };


		private static bool _isTrue(this bool b) => b;
		private static bool _isFalse(this bool b) => !b;
	}
}

