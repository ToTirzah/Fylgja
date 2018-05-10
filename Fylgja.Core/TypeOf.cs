namespace Fylgja.Core
{
	using System;
	using System.Reflection;

	public static class TypeOf<T>
	{
		public static readonly Type Info = typeof(T);
		public static readonly string Name = Info.Name;
		public static readonly string FullName = Info.FullName;
		public static readonly Assembly Assembly = Info.Assembly;
		public static readonly bool IsValueType = Info.IsValueType;
	}
}

