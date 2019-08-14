using JetBrains.Annotations;
using System;
using System.Windows;
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

		public static TextBlock FontFamily([NotNull] this TextBlock @this, FontFamily fontFamily)
		{
			@this.FontFamily = fontFamily;
			return @this;
		}

		public static TextBlock FontFamily([NotNull] this TextBlock @this, string fontFamily)
		{
			@this.FontFamily = new FontFamily(fontFamily);
			return @this;
		}

		public static TextBlock FontFamily([NotNull] this TextBlock @this, Uri uri, string fontFamily)
		{
			@this.FontFamily = new FontFamily(uri, fontFamily);
			return @this;
		}

		public static TextBlock FontFamily([NotNull] this TextBlock @this, Fonts font)
		{
			@this.FontFamily = new FontFamily(font.ToFontString());
			return @this;
		}

		public static TextBlock FontWeight([NotNull] this TextBlock @this, FontWeight fontWeight)
		{
			@this.FontWeight = fontWeight;
			return @this;
		}

		public static TextBlock Bold([NotNull] this TextBlock @this)
		{
			@this.FontWeight = FontWeights.Bold;
			return @this;
		}

		public static TextBlock Text([NotNull] this TextBlock @this, string text)
		{
			@this.Text = text;
			return @this;
		}
	}
}
