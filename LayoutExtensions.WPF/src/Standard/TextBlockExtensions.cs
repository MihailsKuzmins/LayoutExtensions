using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TA = System.Windows.TextAlignment;
using TT = System.Windows.TextTrimming;
using TW = System.Windows.TextWrapping;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class TextBlockExtensions
	{
		public static TextBlock FontWeight(this TextBlock @this, FontWeight fontWeight)
		{
			@this.FontWeight = fontWeight;
			return @this;
		}

		public static TextBlock Bold(this TextBlock @this)
		{
			@this.FontWeight = FontWeights.Bold;
			return @this;
		}

		public static TextBlock FontStyle(this TextBlock @this, FontStyle fontStyle)
		{
			@this.FontStyle = fontStyle;
			return @this;
		}

		public static TextBlock Italic(this TextBlock @this) =>
			@this.FontStyle(FontStyles.Italic);

		public static TextBlock Oblique(this TextBlock @this) =>
			@this.FontStyle(FontStyles.Oblique);

		public static TextBlock FontFamily(this TextBlock @this, FontFamily fontFamily)
		{
			@this.FontFamily = fontFamily;
			return @this;
		}

		public static TextBlock FontFamily(this TextBlock @this, string fontFamily)
		{
			@this.FontFamily = new FontFamily(fontFamily);
			return @this;
		}

		public static TextBlock FontFamily(this TextBlock @this, Uri uri, string fontFamily)
		{
			@this.FontFamily = new FontFamily(uri, fontFamily);
			return @this;
		}

		public static TextBlock FontFamily(this TextBlock @this, Fonts font)
		{
			@this.FontFamily = new FontFamily(font.ToFontString());
			return @this;
		}

		public static TextBlock Text(this TextBlock @this, string text)
		{
			@this.Text = text;
			return @this;
		}

		public static TextBlock FontStretch(this TextBlock @this, FontStretch fontStretch)
		{
			@this.FontStretch = fontStretch;
			return @this;
		}

		public static TextBlock BaselineOffset(this TextBlock @this, double baselineOffset)
		{
			@this.BaselineOffset = baselineOffset;
			return @this;
		}

		public static TextBlock FontSize(this TextBlock @this, double fontSize)
		{
			@this.FontSize = fontSize;
			return @this;
		}

		public static TextBlock TextWrapping(this TextBlock @this, TW textWrapping)
		{
			@this.TextWrapping = textWrapping;
			return @this;
		}

		public static TextBlock WrapWithOverflow(this TextBlock @this) =>
			@this.TextWrapping(TW.WrapWithOverflow);

		public static TextBlock NoWrap(this TextBlock @this) =>
			@this.TextWrapping(TW.NoWrap);

		public static TextBlock Wrap(this TextBlock @this) =>
			@this.TextWrapping(TW.Wrap);

		public static TextBlock Background(this TextBlock @this, Brush brush)
		{
			@this.Background = brush;
			return @this;
		}

		public static TextBlock Background(this TextBlock @this, Color color)
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TextBlock Background(this TextBlock @this, byte a, byte r, byte g, byte b)
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TextBlock Background(this TextBlock @this, byte r, byte g, byte b)
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TextBlock TextDecorations(this TextBlock @this, TextDecorationCollection textDecorations)
		{
			@this.TextDecorations = textDecorations;
			return @this;
		}

		public static TextBlock TextEffects(this TextBlock @this, TextEffectCollection textEffects)
		{
			@this.TextEffects = textEffects;
			return @this;
		}

		public static TextBlock LineHeight(this TextBlock @this, double lineHeight)
		{
			@this.LineHeight = lineHeight;
			return @this;
		}

		public static TextBlock LineStackingStrategy(this TextBlock @this, LineStackingStrategy lineStackingStrategy)
		{
			@this.LineStackingStrategy = lineStackingStrategy;
			return @this;
		}

		public static TextBlock Padding(this TextBlock @this, double uniform)
		{
			@this.Padding = new Thickness(uniform);
			return @this;
		}

		public static TextBlock Padding(this TextBlock @this, double horizontal, double vertical)
		{
			@this.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TextBlock Padding(this TextBlock @this, double left, double top, double right, double bottom)
		{
			@this.Padding = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TextBlock PaddingHorizontal(this TextBlock @this, double horizontal)
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(horizontal, padding.Top, horizontal, padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingVertical(this TextBlock @this, double vertical)
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, vertical, padding.Right, vertical);
			return @this;
		}

		public static TextBlock PaddingLeft(this TextBlock @this, double left)
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(left, padding.Top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingTop(this TextBlock @this, double top)
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingRight(this TextBlock @this, double right)
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, right, padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingBottom(this TextBlock @this, double bottom)
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, padding.Right, bottom);
			return @this;
		}

		public static TextBlock TextAlignment(this TextBlock @this, TA textAlignment)
		{
			@this.TextAlignment = textAlignment;
			return @this;
		}

		public static TextBlock TextLeft(this TextBlock @this) =>
			@this.TextAlignment(TA.Left);

		public static TextBlock TextRight(this TextBlock @this) =>
			@this.TextAlignment(TA.Right);

		public static TextBlock TextCenter(this TextBlock @this) =>
			@this.TextAlignment(TA.Center);

		public static TextBlock TextJustify(this TextBlock @this) =>
			@this.TextAlignment(TA.Justify);

		public static TextBlock TextTrimming(this TextBlock @this, TT textTrimming)
		{
			@this.TextTrimming = textTrimming;
			return @this;
		}

		public static TextBlock TextTrimmingNone(this TextBlock @this) =>
			@this.TextTrimming(TT.None);

		public static TextBlock TextTrimmingCharacterEllipsis(this TextBlock @this) =>
			@this.TextTrimming(TT.CharacterEllipsis);

		public static TextBlock TextTrimmingWordEllipsis(this TextBlock @this) =>
			@this.TextTrimming(TT.WordEllipsis);

		public static TextBlock IsHyphenationEnabled(this TextBlock @this, bool isHyphenationEnabled)
		{
			@this.IsHyphenationEnabled = isHyphenationEnabled;
			return @this;
		}

		public static TextBlock Foreground(this TextBlock @this, Brush brush)
		{
			@this.Foreground = brush;
			return @this;
		}

		public static TextBlock Foreground(this TextBlock @this, Color color)
		{
			@this.Foreground = new SolidColorBrush(color);
			return @this;
		}

		public static TextBlock Foreground(this TextBlock @this, byte a, byte r, byte g, byte b)
		{
			@this.Foreground = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TextBlock Foreground(this TextBlock @this, byte r, byte g, byte b)
		{
			@this.Foreground = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}
	}
}
