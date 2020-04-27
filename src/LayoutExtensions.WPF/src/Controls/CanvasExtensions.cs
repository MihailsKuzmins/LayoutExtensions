using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.Controls
{
	public static class CanvasExtensions
	{
		public static TCanvas Background<TCanvas>(this TCanvas @this, Brush brush)
			where TCanvas : Canvas
		{
			@this.Background = brush;
			return @this;
		}

		public static TCanvas Background<TCanvas>(this TCanvas @this, Color color)
			where TCanvas : Canvas
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TCanvas Background<TCanvas>(this TCanvas @this, byte a, byte r, byte g, byte b)
			where TCanvas : Canvas
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TCanvas Background<TCanvas>(this TCanvas @this, byte r, byte g, byte b)
			where TCanvas : Canvas
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}
	}
}
