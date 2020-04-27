using System;
using System.Windows;
using System.Windows.Data;

namespace LayoutExtensions.WPF.Miscellaneous
{
	public static class StyleExtensions
	{
		public static Style Setter(this Style @this, DependencyProperty dependencyProperty, Binding binding)
		{
			@this.Setters.Add(new Setter(dependencyProperty, binding));
			return @this;
		}

		public static Style Setter(this Style @this, DependencyProperty dependencyProperty, string propertyName, Action<Binding>? applyAction = null)
		{
			var binding = new Binding(propertyName);
			applyAction?.Invoke(binding);

			@this.Setters.Add(new Setter(dependencyProperty, binding));
			return @this;
		}

		public static Style Setter(this Style @this, DependencyProperty dependencyProperty, object value)
		{
			@this.Setters.Add(new Setter(dependencyProperty, value));
			return @this;
		}
	}
}
