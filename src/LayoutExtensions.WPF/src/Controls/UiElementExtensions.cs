using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using V = System.Windows.Visibility;


namespace LayoutExtensions.WPF.Controls
{
	public static class UiElementExtensions
	{
		public static TUiElement Col<TUiElement>(this TUiElement @this, int column, int colSpan = 1)
			where TUiElement : UIElement
		{
			Grid.SetColumn(@this, column);

			return @this.ColSpan(colSpan);
		}

		public static TUiElement Row<TUiElement>(this TUiElement @this, int row, int rowSpan = 1)
			where TUiElement : UIElement
		{
			Grid.SetRow(@this, row);

			return @this.RowSpan(rowSpan);
		}

		public static TUiElement ColSpan<TUiElement>(this TUiElement @this, int colSpan)
			where TUiElement : UIElement
		{
			Grid.SetColumnSpan(@this, colSpan);
			return @this;
		}

		public static TUiElement RowSpan<TUiElement>(this TUiElement @this, int rowSpan)
			where TUiElement : UIElement
		{
			Grid.SetRowSpan(@this, rowSpan);
			return @this;
		}

		public static TUiElement MouseBinding<TUiElement>(this TUiElement @this, MouseAction mouseAction, out MouseBinding mouseBinding)
			where TUiElement : UIElement
		{
			mouseBinding = new MouseBinding
			{
				MouseAction = mouseAction
			};

			@this.InputBindings.Add(mouseBinding);
			return @this;
		}

		public static TUiElement MouseBinding<TUiElement>(this TUiElement @this, MouseAction mouseAction, ICommand command)
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

		public static TUiElement MouseBinding<TUiElement>(this TUiElement @this, MouseAction mouseAction, ICommand command, object commandParameter)
			where TUiElement : UIElement
		{
			var mouseBinding = new MouseBinding
			{
				MouseAction = mouseAction,
				Command = command,
				CommandParameter = commandParameter
			};

			@this.InputBindings.Add(mouseBinding);
			return @this;
		}

		public static TUiElement MouseBinding<TUiElement>(this TUiElement @this, MouseAction mouseAction, Action<MouseBinding> applyFunc)
			where TUiElement : UIElement
		{
			var mouseBinding = new MouseBinding
			{
				MouseAction = mouseAction
			};

			applyFunc(mouseBinding);

			@this.InputBindings.Add(mouseBinding);
			return @this;
		}

		public static TUiElement Visible<TUiElement>(this TUiElement @this)
			where TUiElement : UIElement
		{
			return @this.Visibility(V.Visible);
		}

		public static TUiElement Hidden<TUiElement>(this TUiElement @this)
			where TUiElement : UIElement
		{
			return @this.Visibility(V.Hidden);
		}

		public static TUiElement Collapsed<TUiElement>(this TUiElement @this)
			where TUiElement : UIElement
		{
			return @this.Visibility(V.Collapsed);
		}

		public static TUiElement RenderTransform<TUiElement>(this TUiElement @this, Transform transform)
			where TUiElement : UIElement
		{
			@this.RenderTransform = transform;
			return @this;
		}

		public static TUiElement RenderTransformOrigin<TUiElement>(this TUiElement @this, Point point)
			where TUiElement : UIElement
		{
			@this.RenderTransformOrigin = point;
			return @this;

		}

		public static TUiElement RenderTransformOrigin<TUiElement>(this TUiElement @this, double uniform)
			where TUiElement : UIElement
		{
			@this.RenderTransformOrigin = new Point(uniform, uniform);
			return @this;
		}

		public static TUiElement RenderTransformOrigin<TUiElement>(this TUiElement @this, double x, double y)
			where TUiElement : UIElement
		{
			@this.RenderTransformOrigin = new Point(x, y);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>(this TUiElement @this, KeyBinding keyBinding)
			where TUiElement : UIElement
		{
			@this.InputBindings.Add(keyBinding);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>(this TUiElement @this, Key key, out KeyBinding keyBinding)
			where TUiElement : UIElement
		{
			keyBinding = new KeyBinding
			{
				Key = key
			};

			@this.InputBindings.Add(keyBinding);
			return @this;
		}

		public static TUiElement KeyBinding<TUiElement>(this TUiElement @this, Key key, ICommand command)
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

		public static TUiElement KeyBinding<TUiElement>(this TUiElement @this, ModifierKeys modifier, Key key, out KeyBinding keyBinding)
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

		public static TUiElement KeyBinding<TUiElement>(this TUiElement @this, ModifierKeys modifier, Key key, ICommand command)
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

		public static TUiElement Opacity<TUiElement>(this TUiElement @this, double opacity)
			where TUiElement : UIElement
		{
			@this.Opacity = opacity;
			return @this;
		}

		public static TUiElement IsEnabled<TUiElement>(this TUiElement @this, bool isEnabled)
			where TUiElement : UIElement
		{
			@this.IsEnabled = isEnabled;
			return @this;
		}

		public static TUiElement Focusable<TUiElement>(this TUiElement @this)
			where TUiElement : UIElement
		{
			@this.Focusable = true;
			return @this;
		}

		public static TUiElement NotFocusable<TUiElement>(this TUiElement @this)
			where TUiElement : UIElement
		{
			@this.Focusable = false;
			return @this;
		}

		public static Viewbox ToViewBox<TUiElement>(this TUiElement @this)
			where TUiElement : UIElement
		{
			return new Viewbox
			{
				Child = @this
			};
		}

		public static void SetIsVisible(this UIElement @this, bool isVisible) =>
			@this.Visibility = isVisible
				? V.Visible
				: V.Collapsed;

		private static TUiElement Visibility<TUiElement>(this TUiElement @this, V visibility)
			where TUiElement : UIElement
		{
			@this.Visibility = visibility;
			return @this;
		}
	}
}
