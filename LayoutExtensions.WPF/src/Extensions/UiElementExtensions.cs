﻿using System.Windows;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class UiElementExtensionsEx
	{
		public static void SetIsVisible(this UIElement @this, bool isVisible) =>
			@this.Visibility = isVisible
				? Visibility.Visible
				: Visibility.Collapsed;
	}
}