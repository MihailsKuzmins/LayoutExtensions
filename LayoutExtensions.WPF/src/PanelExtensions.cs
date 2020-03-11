using System.Windows.Controls;
using System.Windows.Media;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class PanelExtensions
	{
		public static TPanel BackgroundPanel<TPanel>(this TPanel @this, Brush brush)
			where TPanel : Panel
		{
			@this.Background = brush;
			return @this;
		}

		public static TPanel BackgroundPanel<TPanel>(this TPanel @this, Color color)
			where TPanel : Panel
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TPanel BackgroundPanel<TPanel>(this TPanel @this, byte a, byte r, byte g, byte b)
			where TPanel : Panel
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TPanel BackgroundPanel<TPanel>(this TPanel @this, byte r, byte g, byte b)
			where TPanel : Panel
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}
	}
}
