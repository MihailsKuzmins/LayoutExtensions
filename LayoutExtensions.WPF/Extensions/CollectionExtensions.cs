using System.Collections.Generic;

namespace LayoutExtensions.WPF.Extensions
{
	internal static class CollectionExtensions
	{
		internal static void AddRange<TSource>(this ICollection<TSource> source, IEnumerable<TSource> elements)
		{
			foreach (var element in elements)
				source.Add(element);
		}
	}
}
