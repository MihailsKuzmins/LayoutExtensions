using JetBrains.Annotations;
using System.Windows.Controls;
using O = System.Windows.Controls.Orientation;

namespace LayoutExtensions.WPF
{
	public static class StackPanelExtensions
	{
		public static StackPanel Horizontal([NotNull] this StackPanel @this) =>
			@this.Orientation(O.Horizontal);

		public static StackPanel Vertical([NotNull] this StackPanel @this) =>
			@this.Orientation(O.Vertical);

		private static StackPanel Orientation([NotNull] this StackPanel @this, O orientation)
		{
			@this.Orientation = orientation;
			return @this;
		}
	}
}
