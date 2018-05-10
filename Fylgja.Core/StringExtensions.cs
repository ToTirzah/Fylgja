namespace Fylgja.Core
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Text;

	public static class StringExtensions
	{

		public static StringBuilder Append(this StringBuilder builder, params string[] values)
		{
			foreach (var value in values)
				builder.Append(value);
			return builder;
		}


		public static bool ContainsIgnoreCase(this string value, string pattern) 
			=> value.ToUpper(CultureInfo.CurrentCulture).Contains(pattern.ToUpper(CultureInfo.CurrentCulture));


		public static bool EqualsIgnoreCase(this string value, string otherValue) 
			=> string.Equals(value, otherValue, StringComparison.InvariantCultureIgnoreCase);


		public static bool IsNullOrEmpty(this string value) => string.IsNullOrEmpty(value);


		public static bool IsNullOrWhiteSpace(this string value) => string.IsNullOrWhiteSpace(value);


		public static string Join(this IEnumerable<string> collection, string separator) 
			=> string.Join(separator, collection);


		public static string Left(this string value, int size) 
			=> value.Length > size ? value.Substring(0, size) : value;


		public static string Right(this string value, int size) 
			=> value.Length > size ? value.Substring(value.Length - size) : value;
	}
}

