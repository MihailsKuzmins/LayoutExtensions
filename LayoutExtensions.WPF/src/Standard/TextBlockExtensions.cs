using JetBrains.Annotations;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TA = System.Windows.TextAlignment;
using TT = System.Windows.TextTrimming;
using TW = System.Windows.TextWrapping;

namespace LayoutExtensions.WPF
{
	public static class TextBlockExtensions
	{
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

		public static TextBlock FontStyle([NotNull] this TextBlock @this, FontStyle fontStyle)
		{
			@this.FontStyle = fontStyle;
			return @this;
		}

		public static TextBlock Italic([NotNull] this TextBlock @this) =>
			@this.FontStyle(FontStyles.Italic);

		public static TextBlock Oblique([NotNull] this TextBlock @this) =>
			@this.FontStyle(FontStyles.Oblique);

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

		public static TextBlock Text([NotNull] this TextBlock @this, string text)
		{
			@this.Text = text;
			return @this;
		}

		public static TextBlock FontStretch([NotNull] this TextBlock @this, FontStretch fontStretch)
		{
			@this.FontStretch = fontStretch;
			return @this;
		}

		public static TextBlock BaselineOffset([NotNull] this TextBlock @this, double baselineOffset)
		{
			@this.BaselineOffset = baselineOffset;
			return @this;
		}

		public static TextBlock FontSize([NotNull] this TextBlock @this, double fontSize)
		{
			@this.FontSize = fontSize;
			return @this;
		}

		public static TextBlock TextWrapping([NotNull] this TextBlock @this, TW textWrapping)
		{
			@this.TextWrapping = textWrapping;
			return @this;
		}

		public static TextBlock WrapWithOverflow([NotNull] this TextBlock @this) =>
			@this.TextWrapping(TW.WrapWithOverflow);

		public static TextBlock NoWrap([NotNull] this TextBlock @this) =>
			@this.TextWrapping(TW.NoWrap);

		public static TextBlock Wrap([NotNull] this TextBlock @this) =>
			@this.TextWrapping(TW.Wrap);

		public static TextBlock Background([NotNull] this TextBlock @this, Brush brush)
		{
			@this.Background = brush;
			return @this;
		}

		public static TextBlock Background([NotNull] this TextBlock @this, Color color)
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TextBlock Background([NotNull] this TextBlock @this, byte a, byte r, byte g, byte b)
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TextBlock Background([NotNull] this TextBlock @this, byte r, byte g, byte b)
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TextBlock TextDecorations([NotNull] this TextBlock @this, TextDecorationCollection textDecorations)
		{
			@this.TextDecorations = textDecorations;
			return @this;
		}

		public static TextBlock TextEffects([NotNull] this TextBlock @this, TextEffectCollection textEffects)
		{
			@this.TextEffects = textEffects;
			return @this;
		}

		public static TextBlock LineHeight([NotNull] this TextBlock @this, double lineHeight)
		{
			@this.LineHeight = lineHeight;
			return @this;
		}

		public static TextBlock LineStackingStrategy([NotNull] this TextBlock @this, LineStackingStrategy lineStackingStrategy)
		{
			@this.LineStackingStrategy = lineStackingStrategy;
			return @this;
		}

		public static TextBlock Padding([NotNull] this TextBlock @this, double uniform)
		{
			@this.Padding = new Thickness(uniform);
			return @this;
		}

		public static TextBlock Padding([NotNull] this TextBlock @this, double horizontal, double vertical)
		{
			@this.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TextBlock Padding([NotNull] this TextBlock @this, double left, double top, double right, double bottom)
		{
			@this.Padding = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TextBlock PaddingHorizontal([NotNull] this TextBlock @this, double horizontal)
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(horizontal, Padding.Top, horizontal, Padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingVertical([NotNull] this TextBlock @this, double vertical)
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, vertical, Padding.Right, vertical);
			return @this;
		}

		public static TextBlock PaddingLeft([NotNull] this TextBlock @this, double left)
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(left, Padding.Top, Padding.Right, Padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingTop([NotNull] this TextBlock @this, double top)
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, top, Padding.Right, Padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingRight([NotNull] this TextBlock @this, double right)
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, Padding.Top, right, Padding.Bottom);
			return @this;
		}

		public static TextBlock PaddingBottom([NotNull] this TextBlock @this, double bottom)
		{
			var Padding = @this.Padding;

			@this.Padding = new Thickness(Padding.Left, Padding.Top, Padding.Right, bottom);
			return @this;
		}

		public static TextBlock TextAlignment([NotNull] this TextBlock @this, TA textAlignment)
		{
			@this.TextAlignment = textAlignment;
			return @this;
		}

		public static TextBlock TextLeft([NotNull] this TextBlock @this) =>
			@this.TextAlignment(TA.Left);

		public static TextBlock TextRight([NotNull] this TextBlock @this) =>
			@this.TextAlignment(TA.Right);

		public static TextBlock TextCenter([NotNull] this TextBlock @this) =>
			@this.TextAlignment(TA.Center);

		public static TextBlock TextJustify([NotNull] this TextBlock @this) =>
			@this.TextAlignment(TA.Justify);

		public static TextBlock TextTrimming([NotNull] this TextBlock @this, TT textTrimming)
		{
			@this.TextTrimming = textTrimming;
			return @this;
		}

		public static TextBlock TextTrimmingNone([NotNull] this TextBlock @this) =>
			@this.TextTrimming(TT.None);

		public static TextBlock TextTrimmingCharacterEllipsis([NotNull] this TextBlock @this) =>
			@this.TextTrimming(TT.CharacterEllipsis);

		public static TextBlock TextTrimmingWordEllipsis([NotNull] this TextBlock @this) =>
			@this.TextTrimming(TT.WordEllipsis);

		public static TextBlock IsHyphenationEnabled([NotNull] this TextBlock @this, bool isHyphenationEnabled)
		{
			@this.IsHyphenationEnabled = isHyphenationEnabled;
			return @this;
		}

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
	}
}
