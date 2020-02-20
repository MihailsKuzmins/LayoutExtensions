using System.Windows;
using System.Windows.Data;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class BindingExtensions
	{
		public static TFrameworkElement SetBindingEx<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, string path)
			where TFrameworkElement : FrameworkElement
		{
			@this.SetBinding(dp, path);
			return @this;
		}

		public static TFrameworkElement SetBindingEx<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, Binding binding)
			where TFrameworkElement : FrameworkElement
		{
			@this.SetBinding(dp, binding);
			return @this;
		}

		public static TFrameworkElement SetBindingEx<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, string path, BindingMode bindingMode)
			where TFrameworkElement : FrameworkElement
		{
			@this.SetBinding(dp, new Binding(path)
			{
				Mode = bindingMode
			});
			return @this;
		}

		public static TFrameworkElement SetBindingEx<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, string path, IValueConverter converter)
			where TFrameworkElement : FrameworkElement
		{
			@this.SetBinding(dp, new Binding(path)
			{
				Converter = converter
			});
			return @this;
		}
	}
}
