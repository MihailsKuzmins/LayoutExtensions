using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using H = System.Windows.HorizontalAlignment;
using V = System.Windows.VerticalAlignment;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class FrameworkElementExtensions
	{
		public static TFrameworkElement Width<TFrameworkElement>(this TFrameworkElement @this, double width)
			where TFrameworkElement : FrameworkElement
		{
			@this.Width = width;
			return @this;
		}

		public static TFrameworkElement MinWidth<TFrameworkElement>(this TFrameworkElement @this, double minWidth)
			where TFrameworkElement : FrameworkElement
		{
			@this.MinWidth = minWidth;
			return @this;
		}

		public static TFrameworkElement MaxHeight<TFrameworkElement>(this TFrameworkElement @this, double maxHeight)
			where TFrameworkElement : FrameworkElement
		{
			@this.MaxHeight = maxHeight;
			return @this;
		}

		public static TFrameworkElement Height<TFrameworkElement>(this TFrameworkElement @this, double height)
			where TFrameworkElement : FrameworkElement
		{
			@this.Height = height;
			return @this;
		}

		public static TFrameworkElement MinHeight<TFrameworkElement>(this TFrameworkElement @this, double minHeight)
			where TFrameworkElement : FrameworkElement
		{
			@this.MinHeight = minHeight;
			return @this;
		}

		public static TFrameworkElement MaxWidth<TFrameworkElement>(this TFrameworkElement @this, double maxWidth)
			where TFrameworkElement : FrameworkElement
		{
			@this.MaxWidth = maxWidth;
			return @this;
		}

		public static TFrameworkElement Tag<TFrameworkElement>(this TFrameworkElement @this, object tag)
			where TFrameworkElement : FrameworkElement
		{
			@this.Tag = tag;
			return @this;
		}

		public static T GetTag<TFrameworkElement, T>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return (T)@this.Tag;
		}

		public static TFrameworkElement Name<TFrameworkElement>(this TFrameworkElement @this, string name)
			where TFrameworkElement : FrameworkElement
		{
			@this.Name = name;
			return @this;
		}

		public static TFrameworkElement DataContext<TFrameworkElement>(this TFrameworkElement @this, object dataContext)
			where TFrameworkElement : FrameworkElement
		{
			@this.DataContext = dataContext;
			return @this;
		}

		public static T GetDataContext<TFrameworkElement, T>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return (T)@this.DataContext;
		}

		public static TFrameworkElement UseLayoutRounding<TFrameworkElement>(this TFrameworkElement @this, bool useLayoutRouting)
			where TFrameworkElement : FrameworkElement
		{
			@this.UseLayoutRounding = useLayoutRouting;
			return @this;
		}

		public static TFrameworkElement FlowDirection<TFrameworkElement>(this TFrameworkElement @this, FlowDirection flowDirection)
			where TFrameworkElement : FrameworkElement
		{
			@this.FlowDirection = flowDirection;
			return @this;
		}

		public static TFrameworkElement Margin<TFrameworkElement>(this TFrameworkElement @this, Thickness margin)
			where TFrameworkElement : FrameworkElement
		{
			@this.Margin = margin;
			return @this;
		}

		public static TFrameworkElement Margin<TFrameworkElement>(this TFrameworkElement @this, double uniform)
			where TFrameworkElement : FrameworkElement
		{
			@this.Margin = new Thickness(uniform);
			return @this;
		}

		public static TFrameworkElement Margin<TFrameworkElement>(this TFrameworkElement @this, double horizontal, double vertical)
			where TFrameworkElement : FrameworkElement
		{
			@this.Margin = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TFrameworkElement Margin<TFrameworkElement>(this TFrameworkElement @this, double left, double top, double right, double bottom)
			where TFrameworkElement : FrameworkElement
		{
			@this.Margin = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TFrameworkElement MarginHorizontal<TFrameworkElement>(this TFrameworkElement @this, double horizontal)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(horizontal, margin.Top, horizontal, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginVertical<TFrameworkElement>(this TFrameworkElement @this, double vertical)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, vertical, margin.Right, vertical);
			return @this;
		}

		public static TFrameworkElement MarginLeft<TFrameworkElement>(this TFrameworkElement @this, double left)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(left, margin.Top, margin.Right, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginTop<TFrameworkElement>(this TFrameworkElement @this, double top)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, top, margin.Right, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginRight<TFrameworkElement>(this TFrameworkElement @this, double right)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, margin.Top, right, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginBottom<TFrameworkElement>(this TFrameworkElement @this, double bottom)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, margin.Top, margin.Right, bottom);
			return @this;
		}

		public static TFrameworkElement Style<TFrameworkElement>(this TFrameworkElement @this, Style style)
			where TFrameworkElement : FrameworkElement
		{
			@this.Style = style;
			return @this;
		}

		public static TFrameworkElement OverridesDefaultStyle<TFrameworkElement>(this TFrameworkElement @this, bool overridesDefaultStyle)
			where TFrameworkElement : FrameworkElement
		{
			@this.OverridesDefaultStyle = overridesDefaultStyle;
			return @this;
		}

		public static TFrameworkElement ContextMenu<TFrameworkElement>(this TFrameworkElement @this, ContextMenu contextMenu)
			where TFrameworkElement : FrameworkElement
		{
			@this.ContextMenu = contextMenu;
			return @this;
		}

		public static TFrameworkElement ToolTip<TFrameworkElement>(this TFrameworkElement @this, object toolTip)
			where TFrameworkElement : FrameworkElement
		{
			@this.ToolTip = toolTip;
			return @this;
		}

		public static TFrameworkElement ForceCursor<TFrameworkElement>(this TFrameworkElement @this, bool forceCursor)
			where TFrameworkElement : FrameworkElement
		{
			@this.ForceCursor = forceCursor;
			return @this;
		}

		public static void Cursor<TFrameworkElement>(this TFrameworkElement @this, Cursor cursor)
			where TFrameworkElement : FrameworkElement
		{
			@this.Cursor = cursor;
		}

		public static TFrameworkElement FocusVisualStyle<TFrameworkElement>(this TFrameworkElement @this, Style focusVisualStyle)
			where TFrameworkElement : FrameworkElement
		{
			@this.FocusVisualStyle = focusVisualStyle;
			return @this;
		}

		public static TFrameworkElement Top<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.VerticalAlignment(V.Top);
		}

		public static TFrameworkElement CenterV<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.VerticalAlignment(V.Center);
		}

		public static TFrameworkElement CenterH<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.HorizontalAlignment(H.Center);
		}

		public static TFrameworkElement Center<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this
				.CenterH()
				.CenterV();
		}

		public static TFrameworkElement Bottom<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.VerticalAlignment(V.Bottom);
		}

		public static TFrameworkElement StretchV<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.VerticalAlignment(V.Stretch);
		}

		public static TFrameworkElement StretchH<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.HorizontalAlignment(H.Stretch);
		}

		public static TFrameworkElement Stretch<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this
				.StretchH()
				.StretchV();
		}

		public static TFrameworkElement Left<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.HorizontalAlignment(H.Left);
		}

		public static TFrameworkElement Right<TFrameworkElement>(this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return @this.HorizontalAlignment(H.Right);
		}

		public static TFrameworkElement AddToPanel<TFrameworkElement>(this TFrameworkElement @this, Panel panel)
			where TFrameworkElement : FrameworkElement
		{
			panel.Children.Add(@this);
			return @this;
		}

		private static TFrameworkElement HorizontalAlignment<TFrameworkElement>(this TFrameworkElement @this, H horizontalAlignment)
			where TFrameworkElement : FrameworkElement
		{
			@this.HorizontalAlignment = horizontalAlignment;
			return @this;
		}

		private static TFrameworkElement VerticalAlignment<TFrameworkElement>(this TFrameworkElement @this, V verticalAlignment)
			where TFrameworkElement : FrameworkElement
		{
			@this.VerticalAlignment = verticalAlignment;
			return @this;
		}

		public static TFrameworkElement Binding<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, string path)
			where TFrameworkElement : FrameworkElement
		{
			@this.SetBinding(dp, path);
			return @this;
		}

		public static TFrameworkElement Binding<TFrameworkElement>(this TFrameworkElement @this, DependencyProperty dp, string path, Action<Binding> applyFunc)
			where TFrameworkElement : FrameworkElement
		{
			var binding = new Binding(path);
			applyFunc(binding);

			@this.SetBinding(dp, binding);
			return @this;
		}
	}
}
