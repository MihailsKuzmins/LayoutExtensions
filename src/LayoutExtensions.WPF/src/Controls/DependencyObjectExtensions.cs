using System.Windows;

namespace LayoutExtensions.WPF.Controls
{
	public static class DependencyObjectExtensions
	{
		public static TDependencyObject Assign<TDependencyObject>(this TDependencyObject @this, out TDependencyObject assignElement)
			where TDependencyObject : DependencyObject
		{
			assignElement = @this;
			return @this;
		}
	}
}
