using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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

		public static TUiElement MouseBinding<TUiElement>([NotNull] this TUiElement @this, MouseAction mouseAction, out MouseBinding mouseBinding)
			where TUiElement : UIElement
		{
			mouseBinding = new MouseBinding
			{
				MouseAction = mouseAction
			};

			@this.InputBindings.Add(mouseBinding);
			return @this;
		}

		public static TUiElement MouseBinding<TUiElement>([NotNull] this TUiElement @this, MouseAction mouseAction, ICommand command)
			where TUiElement : UIElement
		{
			var mouseBinding = new MouseBinding
			{
				MouseAction = mouseAction,
				Command = command
			};

			@this.InputBindings.Add(mouseBinding);
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

		public static TUiElement RenderTransformOrigin<TUiElement>([NotNull] this TUiElement @this, Point point)
			where TUiElement : UIElement
		{
			@this.RenderTransformOrigin = point;
			return @this;

		}

		public static TUiElement RenderTransformOrigin<TUiElement>([NotNull] this TUiElement @this, double uniform)
			where TUiElement : UIElement
		{
			@this.RenderTransformOrigin = new Point(uniform, uniform);
			return @this;
		}

		public static TUiElement RenderTransformOrigin<TUiElement>([NotNull] this TUiElement @this, double x, double y)
			where TUiElement : UIElement
		{
			@this.RenderTransformOrigin = new Point(x, y);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>([NotNull] this TUiElement @this, KeyBinding keyBinding)
			where TUiElement : UIElement
		{
			@this.InputBindings.Add(keyBinding);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>([NotNull] this TUiElement @this, Key key, out KeyBinding keyBinding)
			where TUiElement : UIElement
		{
			keyBinding = new KeyBinding
			{
				Key = key
			};

			@this.InputBindings.Add(keyBinding);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>([NotNull] this TUiElement @this, Key key, ICommand command)
			where TUiElement : UIElement
		{
			var keyBinding = new KeyBinding
			{
				Key = key,
				Command = command
			};

			@this.InputBindings.Add(keyBinding);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>([NotNull] this TUiElement @this, ModifierKeys modifier, Key key, out KeyBinding keyBinding)
			where TUiElement : UIElement
		{
			keyBinding = new KeyBinding
			{
				Key = key,
				Modifiers = modifier
			};

			@this.InputBindings.Add(keyBinding);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>([NotNull] this TUiElement @this, ModifierKeys modifier, Key key, ICommand command)
			where TUiElement : UIElement
		{
			var keyBinding = new KeyBinding
			{
				Key = key,
				Modifiers = modifier,
				Command = command
			};

			@this.InputBindings.Add(keyBinding);
			return @this;
		}

		private static TUiElement Visibility<TUiElement>([NotNull] this TUiElement @this, V visibility)
			where TUiElement : UIElement
		{
			@this.Visibility = visibility;
			return @this;
		}
	}
}
