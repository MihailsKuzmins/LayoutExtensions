using System.Windows.Controls;
using O = System.Windows.Controls.Orientation;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class StackPanelExtensions
	{
		public static StackPanel Horizontal(this StackPanel @this) =>
			@this.Orientation(O.Horizontal);

		public static StackPanel Vertical(this StackPanel @this) =>
			@this.Orientation(O.Vertical);

		private static StackPanel Orientation(this StackPanel @this, O orientation)
		{
			@this.Orientation = orientation;
			return @this;
		}
	}
}
