using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using H = System.Windows.HorizontalAlignment;
using V = System.Windows.VerticalAlignment;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class ControlExtensions
	{
		public static TControl FontStyle<TControl>(this TControl @this, FontStyle fontStyle)
			where TControl : Control
		{
			@this.FontStyle = fontStyle;
			return @this;
		}

		public static TControl FontStretch<TControl>(this TControl @this, FontStretch fontStretch)
			where TControl : Control
		{
			@this.FontStretch = fontStretch;
			return @this;
		}

		public static TControl FontSize<TControl>(this TControl @this, double fontSize)
			where TControl : Control
		{
			@this.FontSize = fontSize;
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, FontFamily fontFamily)
			where TControl : Control
		{
			@this.FontFamily = fontFamily;
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, string fontFamily)
			where TControl : Control
		{
			@this.FontFamily = new FontFamily(fontFamily);
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, Uri uri, string fontFamily)
			where TControl : Control
		{
			@this.FontFamily = new FontFamily(uri, fontFamily);
			return @this;
		}

		public static TControl FontFamily<TControl>(this TControl @this, Fonts font)
			where TControl : Control
		{
			@this.FontFamily = new FontFamily(font.ToFontString());
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, Brush brush)
			where TControl : Control
		{
			@this.Background = brush;
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, Color color)
			where TControl : Control
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, byte a, byte r, byte g, byte b)
			where TControl : Control
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TControl Background<TControl>(this TControl @this, byte r, byte g, byte b)
			where TControl : Control
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, Brush brush)
			where TControl : Control
		{
			@this.Foreground = brush;
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, Color color)
			where TControl : Control
		{
			@this.Foreground = new SolidColorBrush(color);
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, byte a, byte r, byte g, byte b)
			where TControl : Control
		{
			@this.Foreground = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TControl Foreground<TControl>(this TControl @this, byte r, byte g, byte b)
			where TControl : Control
		{
			@this.Foreground = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TControl Border<TControl>(this TControl @this, double uniform)
			where TControl : Control
		{
			@this.BorderThickness = new Thickness(uniform);
			return @this;
		}

		public static TControl Border<TControl>(this TControl @this, double horizontal, double vertical)
			where TControl : Control
		{
			@this.BorderThickness = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TControl Border<TControl>(this TControl @this, double left, double top, double right, double bottom)
			where TControl : Control
		{
			@this.BorderThickness = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TControl BorderHorizontal<TControl>(this TControl @this, double horizontal)
			where TControl : Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(horizontal, border.Top, horizontal, border.Bottom);
			return @this;
		}

		public static TControl BorderVertical<TControl>(this TControl @this, double vertical)
			where TControl : Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, vertical, border.Right, vertical);
			return @this;
		}

		public static TControl BorderLeft<TControl>(this TControl @this, double left)
			where TControl : Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(left, border.Top, border.Right, border.Bottom);
			return @this;
		}

		public static TControl BorderTop<TControl>(this TControl @this, double top)
			where TControl : Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, top, border.Right, border.Bottom);
			return @this;
		}

		public static TControl BorderRight<TControl>(this TControl @this, double right)
			where TControl : Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, right, border.Bottom);
			return @this;
		}

		public static TControl BorderBottom<TControl>(this TControl @this, double bottom)
			where TControl : Control
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, border.Right, bottom);
			return @this;
		}

		public static TControl IsTabStop<TControl>(this TControl @this, bool isTabStop)
			where TControl : Control
		{
			@this.IsTabStop = isTabStop;
			return @this;
		}

		public static TControl TabIndex<TControl>(this TControl @this, int tabIndex)
			where TControl : Control
		{
			@this.TabIndex = tabIndex;
			return @this;
		}

		public static TControl Padding<TControl>(this TControl @this, double uniform)
			where TControl : Control
		{
			@this.Padding = new Thickness(uniform);
			return @this;
		}

		public static TControl Padding<TControl>(this TControl @this, double horizontal, double vertical)
			where TControl : Control
		{
			@this.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TControl Padding<TControl>(this TControl @this, double left, double top, double right, double bottom)
			where TControl : Control
		{
			@this.Padding = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TControl PaddingHorizontal<TControl>(this TControl @this, double horizontal)
			where TControl : Control
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(horizontal, Padding.Top, horizontal, Padding.Bottom);
			return @this;
		}

		public static TControl PaddingVertical<TControl>(this TControl @this, double vertical)
			where TControl : Control
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, vertical, Padding.Right, vertical);
			return @this;
		}

		public static TControl PaddingLeft<TControl>(this TControl @this, double left)
			where TControl : Control
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(left, Padding.Top, Padding.Right, Padding.Bottom);
			return @this;
		}

		public static TControl PaddingTop<TControl>(this TControl @this, double top)
			where TControl : Control
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, top, Padding.Right, Padding.Bottom);
			return @this;
		}

		public static TControl PaddingRight<TControl>(this TControl @this, double right)
			where TControl : Control
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, Padding.Top, right, Padding.Bottom);
			return @this;
		}

		public static TControl PaddingBottom<TControl>(this TControl @this, double bottom)
			where TControl : Control
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, Padding.Top, Padding.Right, bottom);
			return @this;
		}

		public static TControl Template<TControl>(this TControl @this, ControlTemplate template)
			where TControl : Control
		{
			@this.Template = template;
			return @this;
		}

		public static TControl FontWeight<TControl>(this TControl @this, FontWeight fontWeight)
			where TControl : Control
		{
			@this.FontWeight = fontWeight;
			return @this;
		}

		public static TControl Bold<TControl>(this TControl @this)
			where TControl : Control
		{
			@this.FontWeight = FontWeights.Bold;
			return @this;
		}

		public static TControl BorderBrush<TControl>(this TControl @this, Brush brush)
			where TControl : Control
		{
			@this.BorderBrush = brush;
			return @this;
		}

		public static TControl BorderBrush<TControl>(this TControl @this, Color color)
			where TControl : Control
		{
			@this.BorderBrush = new SolidColorBrush(color);
			return @this;
		}

		public static TControl BorderBrush<TControl>(this TControl @this, byte a, byte r, byte g, byte b)
			where TControl : Control
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TControl BorderBrush<TControl>(this TControl @this, byte r, byte g, byte b)
			where TControl : Control
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TControl ContentTop<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.VerticalContentAlignment(V.Top);
		}

		public static TControl ContentCenterV<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.VerticalContentAlignment(V.Center);
		}

		public static TControl ContentCenterH<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.HorizontalContentAlignment(H.Center);
		}

		public static TControl ContentCenter<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this
				.ContentCenterH()
				.ContentCenterV();
		}

		public static TControl ContentBotton<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.VerticalContentAlignment(V.Bottom);
		}

		public static TControl ContentStretchV<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.VerticalContentAlignment(V.Stretch);
		}

		public static TControl ContentStretchH<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.HorizontalContentAlignment(H.Stretch);
		}

		public static TControl ContentStretch<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this
				.ContentStretchH()
				.ContentStretchV();
		}

		public static TControl ContentLeft<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.HorizontalContentAlignment(H.Left);
		}

		public static TControl ContentRight<TControl>(this TControl @this)
			where TControl : Control
		{
			return @this.HorizontalContentAlignment(H.Right);
		}

		private static TControl HorizontalContentAlignment<TControl>(this TControl @this, HorizontalAlignment horizontalAlignment)
			where TControl : Control
		{
			@this.HorizontalContentAlignment = horizontalAlignment;
			return @this;
		}

		private static TControl VerticalContentAlignment<TControl>(this TControl @this, V verticalAlignment)
			where TControl : Control
		{
			@this.VerticalContentAlignment = verticalAlignment;
			return @this;
		}
	}
}
