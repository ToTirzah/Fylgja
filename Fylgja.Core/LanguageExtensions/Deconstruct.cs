﻿namespace Fylgja.Core
{
	public static partial class LanguageExtensions
	{
		public static void Deconstruct<T>(this T o, out T a) => a = o;
		public static void Deconstruct<T>(this T o, out T a, out T b) => a = b = o;
		public static void Deconstruct<T>(this T o, out T a, out T b, out T c) => a = b = c = o;
		public static void Deconstruct<T>(this T o, out T a, out T b, out T c, out T d) => a = b = c = d = o;
		public static void Deconstruct<T>(this T o, out T a, out T b, out T c, out T d, out T e) => a = b = c = d = e = o;
		public static void Deconstruct<T>(this T o, out T a, out T b, out T c, out T d, out T e, out T f) => a = b = c = d = e = f = o;
		public static void Deconstruct<T>(this T o, out T a, out T b, out T c, out T d, out T e, out T f, out T g) => a = b = c = d = e = f = g = o;
		public static void Deconstruct<T>(this T o, out T a, out T b, out T c, out T d, out T e, out T f, out T g, out T h) => a = b = c = d = e = f = g = h = o;


		public static T To<T>(this T o, out T a, out T b) => a = b = o;
		public static T To<T>(this T o, out T a, out T b, out T c) => a = b = c = o;
		public static T To<T>(this T o, out T a, out T b, out T c, out T d) => a = b = c = d = o;
		public static T To<T>(this T o, out T a, out T b, out T c, out T d, out T e) => a = b = c = d = e = o;
		public static T To<T>(this T o, out T a, out T b, out T c, out T d, out T e, out T f) => a = b = c = d = e = f = o;
		public static T To<T>(this T o, out T a, out T b, out T c, out T d, out T e, out T f, out T g) => a = b = c = d = e = f = g = o;
		public static T To<T>(this T o, out T a, out T b, out T c, out T d, out T e, out T f, out T g, out T h) => a = b = c = d = e = f = g = h = o;
	}
}

