using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using H = System.Windows.HorizontalAlignment;
using V = System.Windows.VerticalAlignment;


namespace LayoutExtensions.WPF.Controls
{
	public static class ControlExtensions
	{
		public static TControl FontStyle<TControl>(this TControl @this, FontStyle fontStyle)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontStyle = fontStyle;
			return @this;
		}

		public static TControl FontStretch<TControl>(this TControl @this, FontStretch fontStretch)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontStretch = fontStretch;
			return @this;
		}

		public static TControl FontSize<TControl>(this TControl @this, double fontSize)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontSize = fontSize;
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, FontFamily fontFamily)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontFamily = fontFamily;
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, string fontFamily)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontFamily = new FontFamily(fontFamily);
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, Uri uri, string fontFamily)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontFamily = new FontFamily(uri, fontFamily);
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, Fonts font)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontFamily = new FontFamily(font.ToFontString());
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, Brush brush)
			where TControl : System.Windows.Controls.Control
		{
			@this.Background = brush;
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, Color color)
			where TControl : System.Windows.Controls.Control
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, byte a, byte r, byte g, byte b)
			where TControl : System.Windows.Controls.Control
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, byte r, byte g, byte b)
			where TControl : System.Windows.Controls.Control
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, Brush brush)
			where TControl : System.Windows.Controls.Control
		{
			@this.Foreground = brush;
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, Color color)
			where TControl : System.Windows.Controls.Control
		{
			@this.Foreground = new SolidColorBrush(color);
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, byte a, byte r, byte g, byte b)
			where TControl : System.Windows.Controls.Control
		{
			@this.Foreground = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, byte r, byte g, byte b)
			where TControl : System.Windows.Controls.Control
		{
			@this.Foreground = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TControl BorderControl<TControl>(this TControl @this, double uniform)
			where TControl : System.Windows.Controls.Control
		{
			@this.BorderThickness = new Thickness(uniform);
			return @this;
		}

		public static TControl BorderControl<TControl>(this TControl @this, double horizontal, double vertical)
			where TControl : System.Windows.Controls.Control
		{
			@this.BorderThickness = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TControl BorderControl<TControl>(this TControl @this, double left, double top, double right, double bottom)
			where TControl : System.Windows.Controls.Control
		{
			@this.BorderThickness = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TControl BorderHorizontalControl<TControl>(this TControl @this, double horizontal)
			where TControl : System.Windows.Controls.Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(horizontal, border.Top, horizontal, border.Bottom);
			return @this;
		}

		public static TControl BorderVerticalControl<TControl>(this TControl @this, double vertical)
			where TControl : System.Windows.Controls.Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, vertical, border.Right, vertical);
			return @this;
		}

		public static TControl BorderLeftControl<TControl>(this TControl @this, double left)
			where TControl : System.Windows.Controls.Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(left, border.Top, border.Right, border.Bottom);
			return @this;
		}

		public static TControl BorderTopControl<TControl>(this TControl @this, double top)
			where TControl : System.Windows.Controls.Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, top, border.Right, border.Bottom);
			return @this;
		}

		public static TControl BorderRightControl<TControl>(this TControl @this, double right)
			where TControl : System.Windows.Controls.Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, right, border.Bottom);
			return @this;
		}

		public static TControl BorderBottomControl<TControl>(this TControl @this, double bottom)
			where TControl : System.Windows.Controls.Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, border.Right, bottom);
			return @this;
		}

		public static TControl IsTabStop<TControl>(this TControl @this, bool isTabStop)
			where TControl : System.Windows.Controls.Control
		{
			@this.IsTabStop = isTabStop;
			return @this;
		}

		public static TControl TabIndex<TControl>(this TControl @this, int tabIndex)
			where TControl : System.Windows.Controls.Control
		{
			@this.TabIndex = tabIndex;
			return @this;
		}

		public static TControl Padding<TControl>(this TControl @this, double uniform)
			where TControl : System.Windows.Controls.Control
		{
			@this.Padding = new Thickness(uniform);
			return @this;
		}

		public static TControl Padding<TControl>(this TControl @this, double horizontal, double vertical)
			where TControl : System.Windows.Controls.Control
		{
			@this.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TControl Padding<TControl>(this TControl @this, double left, double top, double right, double bottom)
			where TControl : System.Windows.Controls.Control
		{
			@this.Padding = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TControl PaddingHorizontal<TControl>(this TControl @this, double horizontal)
			where TControl : System.Windows.Controls.Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(horizontal, padding.Top, horizontal, padding.Bottom);
			return @this;
		}

		public static TControl PaddingVertical<TControl>(this TControl @this, double vertical)
			where TControl : System.Windows.Controls.Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, vertical, padding.Right, vertical);
			return @this;
		}

		public static TControl PaddingLeft<TControl>(this TControl @this, double left)
			where TControl : System.Windows.Controls.Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(left, padding.Top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TControl PaddingTop<TControl>(this TControl @this, double top)
			where TControl : System.Windows.Controls.Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TControl PaddingRight<TControl>(this TControl @this, double right)
			where TControl : System.Windows.Controls.Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, right, padding.Bottom);
			return @this;
		}

		public static TControl PaddingBottom<TControl>(this TControl @this, double bottom)
			where TControl : System.Windows.Controls.Control
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, padding.Right, bottom);
			return @this;
		}

		public static TControl Template<TControl>(this TControl @this, ControlTemplate template)
			where TControl : System.Windows.Controls.Control
		{
			@this.Template = template;
			return @this;
		}

		public static TControl FontWeight<TControl>(this TControl @this, FontWeight fontWeight)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontWeight = fontWeight;
			return @this;
		}

		public static TControl Bold<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			@this.FontWeight = FontWeights.Bold;
			return @this;
		}

		public static TControl BorderBrushControl<TControl>(this TControl @this, Brush brush)
			where TControl : System.Windows.Controls.Control
		{
			@this.BorderBrush = brush;
			return @this;
		}

		public static TControl BorderBrushControl<TControl>(this TControl @this, Color color)
			where TControl : System.Windows.Controls.Control
		{
			@this.BorderBrush = new SolidColorBrush(color);
			return @this;
		}

		public static TControl BorderBrushControl<TControl>(this TControl @this, byte a, byte r, byte g, byte b)
			where TControl : System.Windows.Controls.Control
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TControl BorderBrushControl<TControl>(this TControl @this, byte r, byte g, byte b)
			where TControl : System.Windows.Controls.Control
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TControl ContentTop<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.VerticalContentAlignment(V.Top);
		}

		public static TControl ContentCenterV<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.VerticalContentAlignment(V.Center);
		}

		public static TControl ContentCenterH<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.HorizontalContentAlignment(H.Center);
		}

		public static TControl ContentCenter<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this
				.ContentCenterH()
				.ContentCenterV();
		}

		public static TControl ContentBotton<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.VerticalContentAlignment(V.Bottom);
		}

		public static TControl ContentStretchV<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.VerticalContentAlignment(V.Stretch);
		}

		public static TControl ContentStretchH<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.HorizontalContentAlignment(H.Stretch);
		}

		public static TControl ContentStretch<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this
				.ContentStretchH()
				.ContentStretchV();
		}

		public static TControl ContentLeft<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.HorizontalContentAlignment(H.Left);
		}

		public static TControl ContentRight<TControl>(this TControl @this)
			where TControl : System.Windows.Controls.Control
		{
			return @this.HorizontalContentAlignment(H.Right);
		}

		private static TControl HorizontalContentAlignment<TControl>(this TControl @this, HorizontalAlignment horizontalAlignment)
			where TControl : System.Windows.Controls.Control
		{
			@this.HorizontalContentAlignment = horizontalAlignment;
			return @this;
		}

		private static TControl VerticalContentAlignment<TControl>(this TControl @this, V verticalAlignment)
			where TControl : System.Windows.Controls.Control
		{
			@this.VerticalContentAlignment = verticalAlignment;
			return @this;
		}
	}
}
