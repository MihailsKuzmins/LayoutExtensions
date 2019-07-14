using JetBrains.Annotations;
using System.Windows;
using V = System.Windows.Visibility;

namespace LayoutExtensions.WPF
{
	public static class UiElementExtensions
	{
		public static TUiElement Visible<TUiElement>([NotNull] this TUiElement @this)
			where TUiElement : UIElement
		{
			return @this.Visibility(V.Visible);
		}

		public static TUiElement Hidden<TUiElement>([NotNull] this TUiElement @this)
			where TUiElement : UIElement
		{
			return @this.Visibility(V.Hidden);
		}

		public static TUiElement Collapsed<TUiElement>([NotNull] this TUiElement @this)
			where TUiElement : UIElement
		{
			return @this.Visibility(V.Collapsed);
		}

		private static TUiElement Visibility<TUiElement>([NotNull] this TUiElement @this, V visibility)
			where TUiElement : UIElement
		{
			@this.Visibility = visibility;
			return @this;
		}
	}
}
