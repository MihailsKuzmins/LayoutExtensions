using LayoutExtensions.WPF.Models;
using System.Windows;

namespace LayoutExtensions.WPF
{
	public static class WindowExtensions
	{
		public static Window WindowStyle(this Window @this, WindowStyle windowStyle)
		{
			@this.WindowStyle = windowStyle;
			return @this;
		}

		public static Window ResizeMode(this Window @this, ResizeMode resizeMode)
		{
			@this.ResizeMode = resizeMode;
			return @this;
		}

		public static Window Bounds(this Window @this, double left, double top, double width, double height)
		{
			@this.Left = left;
			@this.Top = top;
			@this.Width = width;
			@this.Height = height;

			return @this;
		}

		public static Window Bounds(this Window @this, WindowBounds windowBounds)
		{
			@this.Left = windowBounds.Left;
			@this.Top = windowBounds.Top;
			@this.Width = windowBounds.Width;
			@this.Height = windowBounds.Height;

			return @this;
		}
	}
}
