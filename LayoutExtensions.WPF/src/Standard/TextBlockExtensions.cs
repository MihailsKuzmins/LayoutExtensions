using JetBrains.Annotations;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF
{
	public static class TextBlockExtensions
	{
		public static TextBlock Foreground([NotNull] this TextBlock @this, Brush brush)
		{
			@this.Foreground = brush;
			return @this;
		}

		public static TextBlock Foreground([NotNull] this TextBlock @this, Color color)
		{
			@this.Foreground = new SolidColorBrush(color);
			return @this;
		}

		public static TextBlock Foreground([NotNull] this TextBlock @this, byte a, byte r, byte g, byte b)
		{
			@this.Foreground = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TextBlock Foreground([NotNull] this TextBlock @this, byte r, byte g, byte b)
		{
			@this.Foreground = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TextBlock FontSize([NotNull] this TextBlock @this, double fontSize)
		{
			@this.FontSize = fontSize;
			return @this;
		}
	}
}
