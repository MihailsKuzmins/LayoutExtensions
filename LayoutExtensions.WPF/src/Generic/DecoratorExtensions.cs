using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class DecoratorExtensions
	{
		public static TDecorator Child<TDecorator>(this TDecorator @this, UIElement child)
			where TDecorator : Decorator
		{
			@this.Child = child;
			return @this;
		}
	}
}
