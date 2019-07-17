using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.src
{
	public static class BorderExtensions
	{
		public static Border BorderBrush([NotNull] this Border @this, Brush brush)
		{
			@this.BorderBrush = brush;
			return @this;
		}

		public static Border BorderBrush([NotNull] this Border @this, Color color)
		{
			@this.BorderBrush = new SolidColorBrush(color);
			return @this;
		}

		public static Border BorderBrush([NotNull] this Border @this, byte a, byte r, byte g, byte b)
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static Border BorderBrush([NotNull] this Border @this, byte r, byte g, byte b)
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static Border Border([NotNull] this Border @this, Thickness Border)
		{
			@this.BorderThickness = Border;
			return @this;
		}

		public static Border Border([NotNull] this Border @this, double uniform)
		{
			@this.BorderThickness = new Thickness(uniform);
			return @this;
		}

		public static Border Border([NotNull] this Border @this, double horizontal, double vertical)
		{
			@this.BorderThickness = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static Border Border([NotNull] this Border @this, double left, double top, double right, double bottom)
		{
			@this.BorderThickness = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static Border BorderHorizontal([NotNull] this Border @this, double horizontal)
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(horizontal, border.Top, horizontal, border.Bottom);
			return @this;
		}

		public static Border BorderVertical([NotNull] this Border @this, double vertical)
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, vertical, border.Right, vertical);
			return @this;
		}

		public static Border BorderLeft([NotNull] this Border @this, double left)
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(left, border.Top, border.Right, border.Bottom);
			return @this;
		}

		public static Border BorderTop([NotNull] this Border @this, double top)
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, top, border.Right, border.Bottom);
			return @this;
		}

		public static Border BorderRight([NotNull] this Border @this, double right)
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, right, border.Bottom);
			return @this;
		}

		public static Border BorderBottom([NotNull] this Border @this, double bottom)
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, border.Right, bottom);
			return @this;
		}

		public static Border CornerRadius([NotNull] this Border @this, CornerRadius cornerRadius)
		{
			@this.CornerRadius = cornerRadius;
			return @this;
		}

		public static Border CornerRadius([NotNull] this Border @this, double uniform)
		{
			@this.CornerRadius = new CornerRadius(uniform);
			return @this;
		}
	}
}
