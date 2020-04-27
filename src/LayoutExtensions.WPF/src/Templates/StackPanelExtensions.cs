using System.Windows.Controls;

namespace LayoutExtensions.WPF.Templates
{
	public static class StackPanelExtensions
	{
		public static PanelTemplateCreator<T> Horizontal<T>(this PanelTemplateCreator<T> @this)
			where T : StackPanel
		{
			return @this.Value(StackPanel.OrientationProperty, Orientation.Horizontal);
		}

		public static PanelTemplateCreator<T> Vertical<T>(this PanelTemplateCreator<T> @this)
			where T : StackPanel
		{
			return @this.Value(StackPanel.OrientationProperty, Orientation.Vertical);
		}
	}
}
