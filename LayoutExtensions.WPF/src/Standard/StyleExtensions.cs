using JetBrains.Annotations;
using System.Windows;
using System.Windows.Data;

namespace LayoutExtensions.WPF
{
	public static class StyleExtensions
	{
		public static Style Setter([NotNull] this Style @this, DependencyProperty dependencyProperty, Binding binding)
		{
			@this.Setters.Add(new Setter(dependencyProperty, binding));
			return @this;
		}
	}
}
