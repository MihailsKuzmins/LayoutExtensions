using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.Templates
{
	public static class FrameworkElementExtensions
	{
		public static TemplateCreator<T> RenderTransform<T>(this TemplateCreator<T> @this, Transform transform)
			where T : FrameworkElement
		{
			return @this.Value(UIElement.RenderTransformProperty, transform);
		}

		public static TemplateCreator<T> RenderTransformOrigin<T>(this TemplateCreator<T> @this, double uniform)
			where T : FrameworkElement
		{
			return @this.Value(UIElement.RenderTransformOriginProperty, new Point(uniform, uniform));
		}

		public static TemplateCreator<T> RenderTransformOrigin<T>(this TemplateCreator<T> @this, double x, double y)
			where T : FrameworkElement
		{
			return @this.Value(UIElement.RenderTransformOriginProperty, new Point(x, y));
		}

		public static TemplateCreator<T> Margin<T>(this TemplateCreator<T> @this, Thickness margin)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, margin);
		}

		public static TemplateCreator<T> Margin<T>(this TemplateCreator<T> @this, double uniform)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(uniform));
		}

		public static TemplateCreator<T> Margin<T>(this TemplateCreator<T> @this, double horizontal, double vertical)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(horizontal, vertical, horizontal, vertical));
		}

		public static TemplateCreator<T> Margin<T>(this TemplateCreator<T> @this, double left, double top, double right, double bottom)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(left, top, right, bottom));
		}

		public static TemplateCreator<T> MarginHorizontal<T>(this TemplateCreator<T> @this, double horizontal)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(horizontal, 0d, horizontal, 0d));
		}

		public static TemplateCreator<T> MarginVertical<T>(this TemplateCreator<T> @this, double vertical)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(0d, vertical, 0d, vertical));
		}

		public static TemplateCreator<T> MarginLeft<T>(this TemplateCreator<T> @this, double left)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(left, 0d, 0d, 0d));
		}

		public static TemplateCreator<T> MarginTop<T>(this TemplateCreator<T> @this, double top)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(0d, top, 0d, 0d));
		}

		public static TemplateCreator<T> MarginRight<T>(this TemplateCreator<T> @this, double right)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(0d, 0d, right, 0d));
		}

		public static TemplateCreator<T> MarginBottom<T>(this TemplateCreator<T> @this, double bottom)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.MarginProperty, new Thickness(0d, 0d, 0d, bottom));
		}

		public static TemplateCreator<T> Center<T>(this TemplateCreator<T> @this)
			where T : FrameworkElement
		{
			return @this
				.Value(FrameworkElement.HorizontalAlignmentProperty, HorizontalAlignment.Center)
				.Value(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);
		}

		public static TemplateCreator<T> CenterV<T>(this TemplateCreator<T> @this)
			where T : FrameworkElement
		{
			return @this.Value(FrameworkElement.VerticalAlignmentProperty, VerticalAlignment.Center);
		}

		public static TemplateCreator<T> Opacity<T>(this TemplateCreator<T> @this, double opacity)
			where T : FrameworkElement
		{
			return @this.Value(UIElement.OpacityProperty, opacity);
		}

		public static TemplateCreator<T> Row<T>(this TemplateCreator<T> @this, int row, int rowSpan = 1)
			where T : FrameworkElement
		{
			return @this
				.Value(Grid.RowProperty, row)
				.Value(Grid.RowSpanProperty, rowSpan);
		}

		public static TemplateCreator<T> Col<T>(this TemplateCreator<T> @this, int col, int colSpan = 1)
			where T : FrameworkElement
		{
			return @this
				.Value(Grid.ColumnProperty, col)
				.Value(Grid.ColumnSpanProperty, colSpan);
		}

		public static TemplateCreator<T> RowSpan<T>(this TemplateCreator<T> @this, int rowSpan)
			where T : FrameworkElement
		{
			return @this.Value(Grid.RowSpanProperty, rowSpan);
		}

		public static TemplateCreator<T> ColSpan<T>(this TemplateCreator<T> @this, int colSpan)
			where T : FrameworkElement
		{
			return @this.Value(Grid.ColumnSpanProperty, colSpan);
		}
	}
}
