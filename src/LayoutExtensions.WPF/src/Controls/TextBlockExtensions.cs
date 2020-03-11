using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using TA = System.Windows.TextAlignment;
using TT = System.Windows.TextTrimming;
using TW = System.Windows.TextWrapping;


namespace LayoutExtensions.WPF.Controls
{
	public static class TextBlockExtensions
	{
		public static TTextBlock FontWeight<TTextBlock>(this TTextBlock @this, FontWeight fontWeight)
			where TTextBlock : TextBlock
		{
			@this.FontWeight = fontWeight;
			return @this;
		}

		public static TTextBlock Bold<TTextBlock>(this TTextBlock @this)
			where TTextBlock : TextBlock
		{
			@this.FontWeight = FontWeights.Bold;
			return @this;
		}

		public static TTextBlock FontStyle<TTextBlock>(this TTextBlock @this, FontStyle fontStyle)
			where TTextBlock : TextBlock
		{
			@this.FontStyle = fontStyle;
			return @this;
		}

		public static TTextBlock Italic<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.FontStyle(FontStyles.Italic);

		public static TTextBlock Oblique<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.FontStyle(FontStyles.Oblique);

		public static TTextBlock FontFamily<TTextBlock>(this TTextBlock @this, FontFamily fontFamily)
			where TTextBlock : TextBlock
		{
			@this.FontFamily = fontFamily;
			return @this;
		}

		public static TTextBlock FontFamily<TTextBlock>(this TTextBlock @this, string fontFamily)
			where TTextBlock : TextBlock
		{
			@this.FontFamily = new FontFamily(fontFamily);
			return @this;
		}

		public static TTextBlock FontFamily<TTextBlock>(this TTextBlock @this, Uri uri, string fontFamily)
			where TTextBlock : TextBlock
		{
			@this.FontFamily = new FontFamily(uri, fontFamily);
			return @this;
		}

		public static TTextBlock FontFamily<TTextBlock>(this TTextBlock @this, Fonts font)
			where TTextBlock : TextBlock
		{
			@this.FontFamily = new FontFamily(font.ToFontString());
			return @this;
		}

		public static TTextBlock Text<TTextBlock>(this TTextBlock @this, string text)
			where TTextBlock : TextBlock
		{
			@this.Text = text;
			return @this;
		}

		public static TTextBlock FontStretch<TTextBlock>(this TTextBlock @this, FontStretch fontStretch)
			where TTextBlock : TextBlock
		{
			@this.FontStretch = fontStretch;
			return @this;
		}

		public static TTextBlock BaselineOffset<TTextBlock>(this TTextBlock @this, double baselineOffset)
			where TTextBlock : TextBlock
		{
			@this.BaselineOffset = baselineOffset;
			return @this;
		}

		public static TTextBlock FontSize<TTextBlock>(this TTextBlock @this, double fontSize)
			where TTextBlock : TextBlock
		{
			@this.FontSize = fontSize;
			return @this;
		}

		public static TTextBlock TextWrapping<TTextBlock>(this TTextBlock @this, TW textWrapping)
			where TTextBlock : TextBlock
		{
			@this.TextWrapping = textWrapping;
			return @this;
		}

		public static TTextBlock WrapWithOverflow<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextWrapping(TW.WrapWithOverflow);

		public static TTextBlock NoWrap<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextWrapping(TW.NoWrap);

		public static TTextBlock Wrap<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextWrapping(TW.Wrap);

		public static TTextBlock BackgroundTextBlock<TTextBlock>(this TTextBlock @this, Brush brush)
			where TTextBlock : TextBlock
		{
			@this.Background = brush;
			return @this;
		}

		public static TTextBlock BackgroundTextBlock<TTextBlock>(this TTextBlock @this, Color color)
			where TTextBlock : TextBlock
		{
			@this.Background = new SolidColorBrush(color);
			return @this;
		}

		public static TTextBlock BackgroundTextBlock<TTextBlock>(this TTextBlock @this, byte a, byte r, byte g, byte b)
			where TTextBlock : TextBlock
		{
			@this.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TTextBlock BackgroundTextBlock<TTextBlock>(this TTextBlock @this, byte r, byte g, byte b)
			where TTextBlock : TextBlock
		{
			@this.Background = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TTextBlock TextDecorations<TTextBlock>(this TTextBlock @this, TextDecorationCollection textDecorations)
			where TTextBlock : TextBlock
		{
			@this.TextDecorations = textDecorations;
			return @this;
		}

		public static TTextBlock TextEffects<TTextBlock>(this TTextBlock @this, TextEffectCollection textEffects)
			where TTextBlock : TextBlock
		{
			@this.TextEffects = textEffects;
			return @this;
		}

		public static TTextBlock LineHeight<TTextBlock>(this TTextBlock @this, double lineHeight)
			where TTextBlock : TextBlock
		{
			@this.LineHeight = lineHeight;
			return @this;
		}

		public static TTextBlock LineStackingStrategy<TTextBlock>(this TTextBlock @this, LineStackingStrategy lineStackingStrategy)
			where TTextBlock : TextBlock
		{
			@this.LineStackingStrategy = lineStackingStrategy;
			return @this;
		}

		public static TTextBlock PaddingTextBlock<TTextBlock>(this TTextBlock @this, double uniform)
			where TTextBlock : TextBlock
		{
			@this.Padding = new Thickness(uniform);
			return @this;
		}

		public static TTextBlock PaddingTextBlock<TTextBlock>(this TTextBlock @this, double horizontal, double vertical)
			where TTextBlock : TextBlock
		{
			@this.Padding = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TTextBlock PaddingTextBlock<TTextBlock>(this TTextBlock @this, double left, double top, double right, double bottom)
			where TTextBlock : TextBlock
		{
			@this.Padding = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TTextBlock PaddingHorizontalTextBlock<TTextBlock>(this TTextBlock @this, double horizontal)
			where TTextBlock : TextBlock
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(horizontal, padding.Top, horizontal, padding.Bottom);
			return @this;
		}

		public static TTextBlock PaddingVerticalTextBlock<TTextBlock>(this TTextBlock @this, double vertical)
			where TTextBlock : TextBlock
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, vertical, padding.Right, vertical);
			return @this;
		}

		public static TTextBlock PaddingLeftTextBlock<TTextBlock>(this TTextBlock @this, double left)
			where TTextBlock : TextBlock
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(left, padding.Top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TTextBlock PaddingTopTextBlock<TTextBlock>(this TTextBlock @this, double top)
			where TTextBlock : TextBlock
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, top, padding.Right, padding.Bottom);
			return @this;
		}

		public static TTextBlock PaddingRightTextBlock<TTextBlock>(this TTextBlock @this, double right)
			where TTextBlock : TextBlock
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, right, padding.Bottom);
			return @this;
		}

		public static TTextBlock PaddingBottomTextBlock<TTextBlock>(this TTextBlock @this, double bottom)
			where TTextBlock : TextBlock
		{
			var padding = @this.Padding;

			@this.Padding = new Thickness(padding.Left, padding.Top, padding.Right, bottom);
			return @this;
		}

		public static TTextBlock TextAlignment<TTextBlock>(this TTextBlock @this, TA textAlignment)
			where TTextBlock : TextBlock
		{
			@this.TextAlignment = textAlignment;
			return @this;
		}

		public static TTextBlock TextLeft<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextAlignment(TA.Left);

		public static TTextBlock TextRight<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextAlignment(TA.Right);

		public static TTextBlock TextCenter<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextAlignment(TA.Center);

		public static TTextBlock TextJustify<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextAlignment(TA.Justify);

		public static TTextBlock TextTrimming<TTextBlock>(this TTextBlock @this, TT textTrimming)
			where TTextBlock : TextBlock
		{
			@this.TextTrimming = textTrimming;
			return @this;
		}

		public static TTextBlock TextTrimmingNone<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextTrimming(TT.None);

		public static TTextBlock TextTrimmingCharacterEllipsis<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextTrimming(TT.CharacterEllipsis);

		public static TTextBlock TextTrimmingWordEllipsis<TTextBlock>(this TTextBlock @this) where TTextBlock : TextBlock =>
			@this.TextTrimming(TT.WordEllipsis);

		public static TTextBlock IsHyphenationEnabled<TTextBlock>(this TTextBlock @this, bool isHyphenationEnabled)
			where TTextBlock : TextBlock
		{
			@this.IsHyphenationEnabled = isHyphenationEnabled;
			return @this;
		}

		public static TTextBlock ForegroundTextBlock<TTextBlock>(this TTextBlock @this, Brush brush)
			where TTextBlock : TextBlock
		{
			@this.Foreground = brush;
			return @this;
		}

		public static TTextBlock ForegroundTextBlock<TTextBlock>(this TTextBlock @this, Color color)
			where TTextBlock : TextBlock
		{
			@this.Foreground = new SolidColorBrush(color);
			return @this;
		}

		public static TTextBlock ForegroundTextBlock<TTextBlock>(this TTextBlock @this, byte a, byte r, byte g, byte b)
			where TTextBlock : TextBlock
		{
			@this.Foreground = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TTextBlock ForegroundTextBlock<TTextBlock>(this TTextBlock @this, byte r, byte g, byte b)
			where TTextBlock : TextBlock
		{
			@this.Foreground = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}
	}
}
