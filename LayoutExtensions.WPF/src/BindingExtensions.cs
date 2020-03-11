using System;
using System.Windows;
using System.Windows.Data;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class BindingExtensions
	{
		public static TFrameworkElement Binding<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, string path)
			where TFrameworkElement : FrameworkElement
		{
			@this.SetBinding(dp, path);
			return @this;
		}

		public static TFrameworkElement Binding<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, string path, Action<Binding> applyFunc)
			where TFrameworkElement : FrameworkElement
		{
			var binding = new Binding(path);
			applyFunc(binding);

			@this.SetBinding(dp, binding);
			return @this;
		}
	}
}
