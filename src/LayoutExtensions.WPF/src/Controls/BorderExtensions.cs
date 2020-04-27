using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.Controls
{
	public static class BorderExtensions
	{
		public static TBorder BorderBrush<TBorder>(this TBorder @this, Brush brush)
			where TBorder : Border
		{
			@this.BorderBrush = brush;
			return @this;
		}

		public static TBorder BorderBrush<TBorder>(this TBorder @this, Color color)
			where TBorder : Border
		{
			@this.BorderBrush = new SolidColorBrush(color);
			return @this;
		}

		public static TBorder BorderBrush<TBorder>(this TBorder @this, byte a, byte r, byte g, byte b)
			where TBorder : Border
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TBorder BorderBrush<TBorder>(this TBorder @this, byte r, byte g, byte b)
			where TBorder : Border
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TBorder Border<TBorder>(this TBorder @this, Thickness border)
			where TBorder : Border
		{
			@this.BorderThickness = border;
			return @this;
		}

		public static TBorder Border<TBorder>(this TBorder @this, double uniform)
			where TBorder : Border
		{
			@this.BorderThickness = new Thickness(uniform);
			return @this;
		}

		public static TBorder Border<TBorder>(this TBorder @this, double horizontal, double vertical)
			where TBorder : Border
		{
			@this.BorderThickness = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TBorder Border<TBorder>(this TBorder @this, double left, double top, double right, double bottom)
			where TBorder : Border
		{
			@this.BorderThickness = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TBorder BorderHorizontal<TBorder>(this TBorder @this, double horizontal)
			where TBorder : Border
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(horizontal, border.Top, horizontal, border.Bottom);
			return @this;
		}

		public static TBorder BorderVertical<TBorder>(this TBorder @this, double vertical)
			where TBorder : Border
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, vertical, border.Right, vertical);
			return @this;
		}

		public static TBorder BorderLeft<TBorder>(this TBorder @this, double left)
			where TBorder : Border
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(left, border.Top, border.Right, border.Bottom);
			return @this;
		}

		public static TBorder BorderTop<TBorder>(this TBorder @this, double top)
			where TBorder : Border
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, top, border.Right, border.Bottom);
			return @this;
		}

		public static TBorder BorderRight<TBorder>(this TBorder @this, double right)
			where TBorder : Border
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, right, border.Bottom);
			return @this;
		}

		public static TBorder BorderBottom<TBorder>(this TBorder @this, double bottom)
			where TBorder : Border
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, border.Right, bottom);
			return @this;
		}

		public static TBorder CornerRadius<TBorder>(this TBorder @this, CornerRadius cornerRadius)
			where TBorder : Border
		{
			@this.CornerRadius = cornerRadius;
			return @this;
		}

		public static TBorder CornerRadius<TBorder>(this TBorder @this, double uniform)
			where TBorder : Border
		{
			@this.CornerRadius = new CornerRadius(uniform);
			return @this;
		}

		public static TBorder BackgroundBorder<TBorder>(this TBorder @this, Brush brush)
			where TBorder : Border
		{
			@this.Background = brush;
			return @this;
		}

		public static TBorder BackgroundBorder<TBorder>(this TBorder @this, Color color)
			where TBorder : Border
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TBorder BackgroundBorder<TBorder>(this TBorder @this, byte a, byte r, byte g, byte b)
			where TBorder : Border
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TBorder BackgroundBorder<TBorder>(this TBorder @this, byte r, byte g, byte b)
			where TBorder : Border
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TControl BorderPadding<TControl>(this TControl @this, double uniform)
			where TControl : Control
		{
			@this.Padding = new Thickness(uniform);
			return @this;
		}

		public static TControl BorderPadding<TControl>(this TControl @this, double horizontal, double vertical)
			where TControl : Control
		{
			@this.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TControl BorderPadding<TControl>(this TControl @this, double left, double top, double right, double bottom)
			where TControl : Control
		{
			@this.Padding = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TControl BorderPaddingHorizontal<TControl>(this TControl @this, double horizontal)
			where TControl : Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(horizontal, padding.Top, horizontal, padding.Bottom);
			return @this;
		}

		public static TControl BorderPaddingVertical<TControl>(this TControl @this, double vertical)
			where TControl : Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, vertical, padding.Right, vertical);
			return @this;
		}

		public static TControl BorderPaddingLeft<TControl>(this TControl @this, double left)
			where TControl : Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(left, padding.Top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TControl BorderPaddingTop<TControl>(this TControl @this, double top)
			where TControl : Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TControl BorderPaddingRight<TControl>(this TControl @this, double right)
			where TControl : Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, right, padding.Bottom);
			return @this;
		}

		public static TControl BorderPaddingBottom<TControl>(this TControl @this, double bottom)
			where TControl : Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, padding.Right, bottom);
			return @this;
		}
	}
}
