﻿using System.Windows;

namespace LayoutExtensions.WPF.Controls
{
	public static class DependencyObjectExtensions
	{
		public static void Assign<TDependencyObject>(this TDependencyObject @this, out TDependencyObject assignElement)
			where TDependencyObject : DependencyObject
		{
			assignElement = @this;
		}
	}
}