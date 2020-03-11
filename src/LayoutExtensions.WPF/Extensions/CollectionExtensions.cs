using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
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
