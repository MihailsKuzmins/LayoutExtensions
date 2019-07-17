using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;
using V = System.Windows.Visibility;

namespace LayoutExtensions.WPF
{
	public static class UiElementExtensions
	{
		public static TUiElement Col<TUiElement>([NotNull] this TUiElement @this, int column, int colSpan = 1)
			where TUiElement : UIElement
		{
			Grid.SetColumn(@this, column);

			return @this
				.ColSpan(colSpan);
		}

		public static TUiElement Row<TUiElement>([NotNull] this TUiElement @this, int row, int rowSpan = 1)
			where TUiElement : UIElement
		{
			Grid.SetRow(@this, row);

			return @this
				.RowSpan(rowSpan);
		}

		public static TUiElement ColSpan<TUiElement>([NotNull] this TUiElement @this, int colSpan)
			where TUiElement : UIElement
		{
			Grid.SetColumnSpan(@this, colSpan);
			return @this;
		}

		public static TUiElement RowSpan<TUiElement>([NotNull] this TUiElement @this, int rowSpan)
			where TUiElement : UIElement
		{
			Grid.SetRowSpan(@this, rowSpan);
			return @this;
		}

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
