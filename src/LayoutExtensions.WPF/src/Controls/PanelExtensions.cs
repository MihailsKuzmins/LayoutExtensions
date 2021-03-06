﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.Controls
{
	public static class PanelExtensions
	{
		public static TPanel Children<TPanel>(this TPanel @this, params UIElement[] uiElements)
			where TPanel : Panel
		{
			for (var i = 0; i < uiElements.Length; i++)
				@this.Children.Add(uiElements[i]);

			return @this;
		}

		public static TPanel Children<TPanel>(this TPanel @this, IEnumerable<UIElement> uiElements)
			where TPanel : Panel
		{
			foreach (var uiElement in uiElements)
				@this.Children.Add(uiElement);

			return @this;
		}

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
