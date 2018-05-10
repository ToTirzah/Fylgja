namespace Fylgja.Core
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class EnumerableExtensions
	{
		public static Dictionary<TKey, TValue> Append<TKey, TValue>(this Dictionary<TKey, TValue> target, TKey key, TValue value)
		{
			target.Add(key, value);
			return target;
		}


		public static IList<T> AppendRange<T>(this IList<T> target, IEnumerable<T> source)
		{
			source.ForEach(target.Add);
			return target;
		}

		public static IDictionary<TKey, TValue> AppendRange<TKey, TValue>(this IDictionary<TKey, TValue> target,
			IEnumerable<KeyValuePair<TKey, TValue>> source)
		{
			source.ForEach(target.Add);
			return target;
		}


		public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> source, int chunkSize)
		{
			using (var enumerator = source.GetEnumerator())
			{
				do
				{
					if (!enumerator.MoveNext()) yield break;
					yield return ChunkSequence(enumerator, chunkSize);
				} while (true);
			}
		}


		public static IEnumerable<T> Concat<T>(this IEnumerable<T> collection, T singleItem) =>
			collection.Concat(singleItem.ToEnumerable());


		public static IEnumerable<T> Concat<T>(this IEnumerable<T> collection, params T[] items) =>
			Enumerable.Concat(collection, items);


		public static IList<T> ForEach<T>(this IList<T> collection, Action<T> action)
		{
			foreach (var item in collection)
				action(item);
			return collection;
		}


		public static IList<T> ForEach<T, TR>(this IList<T> collection, Func<T, TR> action)
		{
			foreach (var item in collection)
				action(item);
			return collection;
		}


		public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
		{
			foreach (var item in collection)
				action(item);
		}


		public static void ForEach<T, TR>(this IEnumerable<T> collection, Func<T, TR> action)
		{
			foreach (var item in collection)
				action(item);
		}


		public static void Merge<TKey, TValue>(this IDictionary<TKey, TValue> first, IDictionary<TKey, TValue> second)
		{
			foreach (var entry in second)
			{
				first[entry.Key] = entry.Value;
			}
		}


		public static IEnumerable<T> ToEnumerable<T>(this T singleItem)
		{
			yield return singleItem;
		}



		private static IEnumerable<T> ChunkSequence<T>(IEnumerator<T> enumerator, int chunkSize)
		{
			var count = 0;

			do
			{
				yield return enumerator.Current;
			} while (++count < chunkSize && enumerator.MoveNext());
		}
	}
}

