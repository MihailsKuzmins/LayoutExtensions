using System.Windows;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class DependencyObjectExtensions
	{
		public static void Assign<TDependencyObject>(this TDependencyObject @this, out TDependencyObject assignElement)
			where TDependencyObject : DependencyObject
		{
			assignElement = @this;
		}
	}
}
