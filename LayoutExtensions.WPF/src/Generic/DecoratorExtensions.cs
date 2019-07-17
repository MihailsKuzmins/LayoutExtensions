using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class DecoratorExtensions
	{
		public static TDecorator Child<TDecorator>([NotNull] this TDecorator @this, UIElement child)
			where TDecorator : Decorator
		{
			@this.Child = child;
			return @this;
		}
	}
}
