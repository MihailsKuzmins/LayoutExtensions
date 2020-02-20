using LayoutExtensions.WPF.Models;
using System.Windows;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class WindowExtensions
	{
		public static TWindow WindowStyle<TWindow>(this TWindow @this, WindowStyle windowStyle)
			where TWindow : Window
		{
			@this.WindowStyle = windowStyle;
			return @this;
		}

		public static TWindow ResizeMode<TWindow>(this TWindow @this, ResizeMode resizeMode)
			where TWindow : Window
		{
			@this.ResizeMode = resizeMode;
			return @this;
		}

		public static TWindow Bounds<TWindow>(this TWindow @this, double left, double top, double width, double height)
			where TWindow : Window
		{
			@this.Left = left;
			@this.Top = top;
			@this.Width = width;
			@this.Height = height;

			return @this;
		}

		public static TWindow Bounds<TWindow>(this TWindow @this, WindowBounds windowBounds)
			where TWindow : Window
		{
			@this.Left = windowBounds.Left;
			@this.Top = windowBounds.Top;
			@this.Width = windowBounds.Width;
			@this.Height = windowBounds.Height;

			return @this;
		}
	}
}
