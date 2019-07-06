using JetBrains.Annotations;
using System.Collections.Generic;

namespace LayoutExtensions.WPF.Extensions
{
	internal static class CollectionExtensions
	{
		internal static void AddRange<TSource>([NotNull] this ICollection<TSource> source, [NotNull] IEnumerable<TSource> elements)
		{
			foreach (var element in elements)
				source.Add(element);
		}
	}
}
