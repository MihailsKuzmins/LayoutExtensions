using System;
using System.Windows;
using System.Windows.Data;

namespace LayoutExtensions.WPF.Templates
{
	public static class TemplateCreatorExtensions
	{
		public static T Value<T>(this T @this, DependencyProperty dependencyProperty, object value)
			where T : ITemplateCreator
		{
			@this.TemplateFactory.SetValue(dependencyProperty, value);
			return @this;
		}

		public static T Binding<T>(this T @this, DependencyProperty dependencyProperty, string property, Action<Binding>? applyAction = null)
			where T : ITemplateCreator
		{
			var binding = new Binding(property);
			applyAction?.Invoke(binding);

			@this.TemplateFactory.SetBinding(dependencyProperty, binding);
			return @this;
		}

		public static T TemplateBinding<T>(this T @this, DependencyProperty dependencyProperty, string property, Action<Binding>? applyAction = null)
			where T : ITemplateCreator
		{
			var binding = new Binding(property)
			{
				RelativeSource = RelativeSource.TemplatedParent
			};
			applyAction?.Invoke(binding);

			@this.TemplateFactory.SetBinding(dependencyProperty, binding);
			return @this;
		}
	}
}
