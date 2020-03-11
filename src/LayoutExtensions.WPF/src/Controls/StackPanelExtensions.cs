using System.Windows.Controls;
using O = System.Windows.Controls.Orientation;


namespace LayoutExtensions.WPF.Controls
{
	public static class StackPanelExtensions
	{
		public static TStackPanel Horizontal<TStackPanel>(this TStackPanel @this) where TStackPanel : StackPanel =>
			@this.Orientation(O.Horizontal);

		public static TStackPanel Vertical<TStackPanel>(this TStackPanel @this) where TStackPanel : StackPanel =>
			@this.Orientation(O.Vertical);

		private static TStackPanel Orientation<TStackPanel>(this TStackPanel @this, O orientation)
			where TStackPanel : StackPanel
		{
			@this.Orientation = orientation;
			return @this;
		}
	}
}
