namespace Fylgja.Core
{
	using System.Collections.Generic;

	public static partial class LanguageExtensions
	{
		public static TCollection Merge<TCollection, TElement>(this TCollection collection, IEnumerable<TElement> items)
			where TCollection : ICollection<TElement>
		{
			items.ForEach(collection.Add);
			return collection;
		}

		public static TCollection Merge<TCollection, TElement>(this TCollection collection, params TElement[] items)
			where TCollection : ICollection<TElement> => items.ForEach(collection.Add).Put(collection);
	}
}

