using JetBrains.Annotations;
using System.Windows;

namespace LayoutExtensions.WPF
{
	public static class DependencyObjectExtensions
	{
		public static void Assign<TDependencyObject>([NotNull] this TDependencyObject dependencyObject, out TDependencyObject assignElement)
			where TDependencyObject : DependencyObject
		{
			assignElement = dependencyObject;
		}
	}
}
