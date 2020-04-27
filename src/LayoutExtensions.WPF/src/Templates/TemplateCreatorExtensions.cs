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

		public static T TemplateMultiBinding<T>(this T @this, DependencyProperty dependencyProperty, Action<MultiBinding> applyAction, params string[] propertyNames)
			where T : ITemplateCreator
		{
			var multiBinding = new MultiBinding();
			applyAction.Invoke(multiBinding);

			for (var i = 0; i < propertyNames.Length; i++)
			{
				var binding = new Binding(propertyNames[i])
				{
					RelativeSource = RelativeSource.TemplatedParent
				};

				multiBinding.Bindings.Add(binding);
			}

			@this.TemplateFactory.SetBinding(dependencyProperty, multiBinding);
			return @this;
		}
	}
}
