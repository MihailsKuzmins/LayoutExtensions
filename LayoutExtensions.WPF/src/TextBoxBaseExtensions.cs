using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class TextBoxBaseExtensions
	{
		public static TTextBoxBase ReadOnly<TTextBoxBase>(this TTextBoxBase @this)
			where TTextBoxBase : TextBoxBase
		{
			@this.IsReadOnly = true;
			return @this;
		}

		public static TTextBoxBase BorderBrush<TTextBoxBase>(this TTextBoxBase @this, Brush brush)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderBrush = brush;
			return @this;
		}

		public static TTextBoxBase BorderBrush<TTextBoxBase>(this TTextBoxBase @this, Color color)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderBrush = new SolidColorBrush(color);
			return @this;
		}

		public static TTextBoxBase BorderBrush<TTextBoxBase>(this TTextBoxBase @this, byte a, byte r, byte g, byte b)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TTextBoxBase BorderBrush<TTextBoxBase>(this TTextBoxBase @this, byte r, byte g, byte b)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderBrush = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TTextBoxBase Border<TTextBoxBase>(this TTextBoxBase @this, Thickness border)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderThickness = border;
			return @this;
		}

		public static TTextBoxBase Border<TTextBoxBase>(this TTextBoxBase @this, double uniform)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderThickness = new Thickness(uniform);
			return @this;
		}

		public static TTextBoxBase Border<TTextBoxBase>(this TTextBoxBase @this, double horizontal, double vertical)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderThickness = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TTextBoxBase Border<TTextBoxBase>(this TTextBoxBase @this, double left, double top, double right, double bottom)
			where TTextBoxBase : TextBoxBase
		{
			@this.BorderThickness = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TTextBoxBase BorderHorizontal<TTextBoxBase>(this TTextBoxBase @this, double horizontal)
			where TTextBoxBase : TextBoxBase
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(horizontal, border.Top, horizontal, border.Bottom);
			return @this;
		}

		public static TTextBoxBase BorderVertical<TTextBoxBase>(this TTextBoxBase @this, double vertical)
			where TTextBoxBase : TextBoxBase
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, vertical, border.Right, vertical);
			return @this;
		}

		public static TTextBoxBase BorderLeft<TTextBoxBase>(this TTextBoxBase @this, double left)
			where TTextBoxBase : TextBoxBase
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(left, border.Top, border.Right, border.Bottom);
			return @this;
		}

		public static TTextBoxBase BorderTop<TTextBoxBase>(this TTextBoxBase @this, double top)
			where TTextBoxBase : TextBoxBase
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, top, border.Right, border.Bottom);
			return @this;
		}

		public static TTextBoxBase BorderRight<TTextBoxBase>(this TTextBoxBase @this, double right)
			where TTextBoxBase : TextBoxBase
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, right, border.Bottom);
			return @this;
		}

		public static TTextBoxBase BorderBottom<TTextBoxBase>(this TTextBoxBase @this, double bottom)
			where TTextBoxBase : TextBoxBase
		{
			var border = @this.BorderThickness;

			@this.BorderThickness = new Thickness(border.Left, border.Top, border.Right, bottom);
			return @this;
		}
	}
}
