namespace Fylgja.Core
{
	using System;

	public static partial class LanguageExtensions
	{
		public static TOut Match<TIn, TOut>(this TIn context, Func<TOut> nullCase = null)
			=> context.InvokeMatcher((Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null,
				(Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA>(this TIn context,
			Func<TA, TOut> a, Func<TOut> nullCase = null)
			where TA : TIn
			=> context.InvokeMatcher(a, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null,
				(Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA, TB>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn
			=> context.InvokeMatcher(a, b, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null,
				(Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA, TB, TC>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TC, TOut> c, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn where TC : TIn
			=> context.InvokeMatcher(a, b, c, (Func<TIn, TOut>) null,
				(Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA, TB, TC, TD>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TC, TOut> c, Func<TD, TOut> d, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn where TC : TIn where TD : TIn
			=> context.InvokeMatcher(a, b, c, d,
				(Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA, TB, TC, TD, TE>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TC, TOut> c, Func<TD, TOut> d,
			Func<TE, TOut> e, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn where TC : TIn where TD : TIn where TE : TIn
			=> context.InvokeMatcher(a, b, c, d, e, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA, TB, TC, TD, TE, TF>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TC, TOut> c, Func<TD, TOut> d,
			Func<TE, TOut> e, Func<TF, TOut> f, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn where TC : TIn where TD : TIn where TE : TIn where TF : TIn
			=> context.InvokeMatcher(a, b, c, d, e, f, (Func<TIn, TOut>) null, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA, TB, TC, TD, TE, TF, TG>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TC, TOut> c, Func<TD, TOut> d,
			Func<TE, TOut> e, Func<TF, TOut> f, Func<TG, TOut> g, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn where TC : TIn where TD : TIn where TE : TIn where TF : TIn where TG : TIn
			=> context.InvokeMatcher(a, b, c, d, e, f, g, (Func<TIn, TOut>) null, nullCase);

		public static TOut Match<TIn, TOut, TA, TB, TC, TD, TE, TF, TG, TH>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TC, TOut> c, Func<TD, TOut> d,
			Func<TE, TOut> e, Func<TF, TOut> f, Func<TG, TOut> g, Func<TH, TOut> h, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn where TC : TIn where TD : TIn where TE : TIn where TF : TIn where TG : TIn where TH : TIn
			=> context.InvokeMatcher(a, b, c, d, e, f, g, h, nullCase);
		
		private static TOut InvokeMatcher<TIn, TOut, TA, TB, TC, TD, TE, TF, TG, TH>(this TIn context,
			Func<TA, TOut> a, Func<TB, TOut> b, Func<TC, TOut> c, Func<TD, TOut> d,
			Func<TE, TOut> e, Func<TF, TOut> f, Func<TG, TOut> g, Func<TH, TOut> h, Func<TOut> nullCase = null)
			where TA : TIn where TB : TIn where TC : TIn where TD : TIn where TE : TIn where TF : TIn where TG : TIn where TH : TIn
		{
			switch (context)
			{
				case TA aa when a != null: return a.Invoke(aa);
				case TB bb when b != null: return b.Invoke(bb);
				case TC cc when c != null: return c.Invoke(cc);
				case TD dd when d != null: return d.Invoke(dd);
				case TE ee when e != null: return e.Invoke(ee);
				case TF ff when f != null: return f.Invoke(ff);
				case TG gg when g != null: return g.Invoke(gg);
				case TH hh when h != null: return h.Invoke(hh);
				default:
					return nullCase != null && context.IsNull()
						? nullCase.Invoke()
						: throw new ArgumentException($"Undefined case for '{context}'");
			}
		}
	}
}

