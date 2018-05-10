namespace Fylgja.Core
{
	public static partial class LanguageExtensions
	{
		public static T With<T>(this T o, params object[] pattern) => o;
		public static T With<T>(this ref T o, params object[] pattern) where T : struct => o;

		public static T With<T>(this T o) => o;
		public static T With<T, TA>(this T o, TA a) => o;
		public static T With<T, TA, TB>(this T o, TA a, TB b) => o;
		public static T With<T, TA, TB, TC>(this T o, TA a, TB b, TC c) => o;
		public static T With<T, TA, TB, TC, TD>(this T o, TA a, TB b, TC c, TD d) => o;
		public static T With<T, TA, TB, TC, TD, TE>(this T o, TA a, TB b, TC c, TD d, TE e) => o;
		public static T With<T, TA, TB, TC, TD, TE, TF>(this T o, TA a, TB b, TC c, TD d, TE e, TF f) => o;
		public static T With<T, TA, TB, TC, TD, TE, TF, TG>(this T o, TA a, TB b, TC c, TD d, TE e, TF f, TG g) => o;
		public static T With<T, TA, TB, TC, TD, TE, TF, TG, TH>(this T o, TA a, TB b, TC c, TD d, TE e, TF f, TG g, TH h) => o;


		public static T With<T>(this ref T o) where T : struct => o;
		public static T With<T, TA>(this ref T o, TA a) where T : struct => o;
		public static T With<T, TA, TB>(this ref T o, TA a, TB b) where T : struct => o;
		public static T With<T, TA, TB, TC>(this ref T o, TA a, TB b, TC c) where T : struct => o;
		public static T With<T, TA, TB, TC, TD>(this ref T o, TA a, TB b, TC c, TD d) where T : struct => o;
		public static T With<T, TA, TB, TC, TD, TE>(this ref T o, TA a, TB b, TC c, TD d, TE e) where T : struct => o;
		public static T With<T, TA, TB, TC, TD, TE, TF>(this ref T o, TA a, TB b, TC c, TD d, TE e, TF f) where T : struct => o;
		public static T With<T, TA, TB, TC, TD, TE, TF, TG>(this ref T o, TA a, TB b, TC c, TD d, TE e, TF f, TG g) where T : struct => o;
		public static T With<T, TA, TB, TC, TD, TE, TF, TG, TH>(this ref T o, TA a, TB b, TC c, TD d, TE e, TF f, TG g, TH h) where T : struct => o;
	}
}

