namespace Fylgja.Core
{
	using System;

	public static partial class LanguageExtensions
	{
		public static bool[] Check<TA, TB, TC, TD, TE, TF, TG, TH>(this Tuple<TA, TB, TC, TD, TE, TF, TG, TH> t,
			TA a, TB b, TC c, TD d, TE e, TF f, TG g, TH h) => t.Check(
			t.Item1.Is(a), t.Item2.Is(b), t.Item3.Is(c), t.Item4.Is(d), 
			t.Item5.Is(e), t.Item6.Is(f), t.Item7.Is(g), t.Rest.Is(h));
		
		public static bool[] Check<TA, TB, TC, TD, TE, TF, TG>(this Tuple<TA, TB, TC, TD, TE, TF, TG> t,
			TA a, TB b, TC c, TD d, TE e, TF f, TG g) => t.Check(
			t.Item1.Is(a), t.Item2.Is(b), t.Item3.Is(c), t.Item4.Is(d), 
			t.Item5.Is(e), t.Item6.Is(f), t.Item7.Is(g));
		
		public static bool[] Check<TA, TB, TC, TD, TE, TF>(this Tuple<TA, TB, TC, TD, TE, TF> t,
			TA a, TB b, TC c, TD d, TE e, TF f) => t.Check(
			t.Item1.Is(a), t.Item2.Is(b), t.Item3.Is(c), t.Item4.Is(d), 
			t.Item5.Is(e), t.Item6.Is(f));
		
		public static bool[] Check<TA, TB, TC, TD, TE>(this Tuple<TA, TB, TC, TD, TE> t,
			TA a, TB b, TC c, TD d, TE e) => t.Check(
			t.Item1.Is(a), t.Item2.Is(b), t.Item3.Is(c), t.Item4.Is(d), 
			t.Item5.Is(e));
		
		public static bool[] Check<TA, TB, TC, TD>(this Tuple<TA, TB, TC, TD> t,
			TA a, TB b, TC c, TD d) => t.Check(
			t.Item1.Is(a), t.Item2.Is(b), t.Item3.Is(c), t.Item4.Is(d));
		
		public static bool[] Check<TA, TB, TC>(this Tuple<TA, TB, TC> t,
			TA a, TB b, TC c) => t.Check(
			t.Item1.Is(a), t.Item2.Is(b), t.Item3.Is(c));
		
		public static bool[] Check<TA, TB>(this Tuple<TA, TB> t,
			TA a, TB b) => t.Check(
			t.Item1.Is(a), t.Item2.Is(b));
		
		public static bool[] Check<TA>(this Tuple<TA> t,
			TA a) => t.Check(
			t.Item1.Is(a));

	
		public static Tuple<TA, TB, TC, TD, TE, TF, TG> ToTuple<T, TA, TB, TC, TD, TE, TF, TG>(this T o,
			TA a, TB b, TC c, TD d, TE e, TF f, TG g) => Tuple.Create(a, b, c, d, e, f, g);
		
		public static Tuple<TA, TB, TC, TD, TE, TF> ToTuple<T, TA, TB, TC, TD, TE, TF>(this T o,
			TA a, TB b, TC c, TD d, TE e, TF f) => Tuple.Create(a, b, c, d, e, f);
		
		public static Tuple<TA, TB, TC, TD, TE> ToTuple<T, TA, TB, TC, TD, TE>(this T o,
			TA a, TB b, TC c, TD d, TE e) => Tuple.Create(a, b, c, d, e);
		
		public static Tuple<TA, TB, TC, TD> ToTuple<T, TA, TB, TC, TD>(this T o,
			TA a, TB b, TC c, TD d) => Tuple.Create(a, b, c, d);
		
		public static Tuple<TA, TB, TC> ToTuple<T, TA, TB, TC>(this T o,
			TA a, TB b, TC c) => Tuple.Create(a, b, c);
		
		public static Tuple<TA, TB> ToTuple<T, TA, TB>(this T o,
			TA a, TB b) => Tuple.Create(a, b);
		
		public static Tuple<TA> ToTuple<T, TA>(this T o,
			TA a) => Tuple.Create(a);
		
		public static Tuple<T> ToTuple<T>(this T o) 
			=> Tuple.Create(o);

		public static Tuple<TA, TB, TC, TD, TE, TF, TG, TH> To<TA, TB, TC, TD, TE, TF, TG, TH>(this Tuple<TA, TB, TC, TD, TE, TF, TG, TH> t,
			out TA a, out TB b, out TC c, out TD d, out TE e, out TF f, out TG g, out TH h) => t.With(
			a = t.Item1, b = t.Item2, c = t.Item3, d = t.Item4, e = t.Item5, f = t.Item6, g = t.Item7, h = t.Rest);
		
		public static Tuple<TA, TB, TC, TD, TE, TF, TG> To<TA, TB, TC, TD, TE, TF, TG>(this Tuple<TA, TB, TC, TD, TE, TF, TG> t,
			out TA a, out TB b, out TC c, out TD d, out TE e, out TF f, out TG g) => t.With(
			a = t.Item1, b = t.Item2, c = t.Item3, d = t.Item4, e = t.Item5, f = t.Item6, g = t.Item7);
		
		public static Tuple<TA, TB, TC, TD, TE, TF> To<TA, TB, TC, TD, TE, TF>(this Tuple<TA, TB, TC, TD, TE, TF> t,
			out TA a, out TB b, out TC c, out TD d, out TE e, out TF f) => t.With(
			a = t.Item1, b = t.Item2, c = t.Item3, d = t.Item4, e = t.Item5, f = t.Item6);
		
		public static Tuple<TA, TB, TC, TD, TE> To<TA, TB, TC, TD, TE>(this Tuple<TA, TB, TC, TD, TE> t,
			out TA a, out TB b, out TC c, out TD d, out TE e) => t.With(
			a = t.Item1, b = t.Item2, c = t.Item3, d = t.Item4, e = t.Item5);
		
		public static Tuple<TA, TB, TC, TD> To<TA, TB, TC, TD>(this Tuple<TA, TB, TC, TD> t,
			out TA a, out TB b, out TC c, out TD d) => t.With(
			a = t.Item1, b = t.Item2, c = t.Item3, d = t.Item4);
		
		public static Tuple<TA, TB, TC> To<TA, TB, TC>(this Tuple<TA, TB, TC> t,
			out TA a, out TB b, out TC c) => t.With(
			a = t.Item1, b = t.Item2, c = t.Item3);
		
		public static Tuple<TA, TB> To<TA, TB>(this Tuple<TA, TB> t,
			out TA a, out TB b) => t.With(
			a = t.Item1, b = t.Item2);
		
		public static Tuple<TA> To<TA>(this Tuple<TA> t,
			out TA a) => t.With(
			a = t.Item1);
	}
}

