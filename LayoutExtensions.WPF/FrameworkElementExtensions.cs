﻿using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LayoutExtensions.WPF
{
	public static class FrameworkElementExtensions
	{
		public static TFrameworkElement Width<TFrameworkElement>([NotNull] this TFrameworkElement @this, double width)
			where TFrameworkElement : FrameworkElement
		{
			@this.Width = width;
			return @this;
		}

		public static TFrameworkElement MinWidth<TFrameworkElement>([NotNull] this TFrameworkElement @this, double minWidth)
			where TFrameworkElement : FrameworkElement
		{
			@this.MinWidth = minWidth;
			return @this;
		}

		public static TFrameworkElement MaxHeight<TFrameworkElement>([NotNull] this TFrameworkElement @this, double maxHeight)
			where TFrameworkElement : FrameworkElement
		{
			@this.MaxHeight = maxHeight;
			return @this;
		}

		public static TFrameworkElement Height<TFrameworkElement>([NotNull] this TFrameworkElement @this, double height)
			where TFrameworkElement : FrameworkElement
		{
			@this.Height = height;
			return @this;
		}

		public static TFrameworkElement MinHeight<TFrameworkElement>([NotNull] this TFrameworkElement @this, double minHeight)
			where TFrameworkElement : FrameworkElement
		{
			@this.MinHeight = minHeight;
			return @this;
		}

		public static TFrameworkElement MaxWidth<TFrameworkElement>([NotNull] this TFrameworkElement @this, double maxWidth)
			where TFrameworkElement : FrameworkElement
		{
			@this.MaxWidth = maxWidth;
			return @this;
		}

		public static TFrameworkElement Tag<TFrameworkElement>([NotNull] this TFrameworkElement @this, object tag)
			where TFrameworkElement : FrameworkElement
		{
			@this.Tag = tag;
			return @this;
		}

		public static T GetTag<TFrameworkElement, T>([NotNull] this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return (T)@this.Tag;
		}

		public static TFrameworkElement Name<TFrameworkElement>([NotNull] this TFrameworkElement @this, string name)
			where TFrameworkElement : FrameworkElement
		{
			@this.Name = name;
			return @this;
		}

		public static TFrameworkElement DataContext<TFrameworkElement>([NotNull] this TFrameworkElement @this, object dataContext)
			where TFrameworkElement : FrameworkElement
		{
			@this.DataContext = dataContext;
			return @this;
		}

		public static T GetDataContext<TFrameworkElement, T>([NotNull] this TFrameworkElement @this)
			where TFrameworkElement : FrameworkElement
		{
			return (T)@this.DataContext;
		}

		public static TFrameworkElement UseLayoutRounding<TFrameworkElement>([NotNull] this TFrameworkElement @this, bool useLayoutRouting)
			where TFrameworkElement : FrameworkElement
		{
			@this.UseLayoutRounding = useLayoutRouting;
			return @this;
		}

		public static TFrameworkElement FlowDirection<TFrameworkElement>([NotNull] this TFrameworkElement @this, FlowDirection flowDirection)
			where TFrameworkElement : FrameworkElement
		{
			@this.FlowDirection = flowDirection;
			return @this;
		}

		public static TFrameworkElement Margin<TFrameworkElement>([NotNull] this TFrameworkElement @this, double uniform)
			where TFrameworkElement : FrameworkElement
		{
			@this.Margin = new Thickness(uniform);
			return @this;
		}

		public static TFrameworkElement Margin<TFrameworkElement>([NotNull] this TFrameworkElement @this, double horizontal, double vertical)
			where TFrameworkElement : FrameworkElement
		{
			@this.Margin = new Thickness(horizontal, vertical, horizontal, vertical);
			return @this;
		}

		public static TFrameworkElement Margin<TFrameworkElement>([NotNull] this TFrameworkElement @this, double left, double top, double right, double bottom)
			where TFrameworkElement : FrameworkElement
		{
			@this.Margin = new Thickness(left, top, right, bottom);
			return @this;
		}

		public static TFrameworkElement MarginHorizontal<TFrameworkElement>([NotNull] this TFrameworkElement @this, double horizontal)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(horizontal, margin.Top, horizontal, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginVertical<TFrameworkElement>([NotNull] this TFrameworkElement @this, double vertical)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, vertical, margin.Right, vertical);
			return @this;
		}

		public static TFrameworkElement MarginLeft<TFrameworkElement>([NotNull] this TFrameworkElement @this, double left)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(left, margin.Top, margin.Right, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginTop<TFrameworkElement>([NotNull] this TFrameworkElement @this, double top)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, top, margin.Right, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginRight<TFrameworkElement>([NotNull] this TFrameworkElement @this, double right)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, margin.Top, right, margin.Bottom);
			return @this;
		}

		public static TFrameworkElement MarginBottom<TFrameworkElement>([NotNull] this TFrameworkElement @this, double bottom)
			where TFrameworkElement : FrameworkElement
		{
			var margin = @this.Margin;

			@this.Margin = new Thickness(margin.Left, margin.Top, margin.Right, bottom);
			return @this;
		}

		public static TFrameworkElement Style<TFrameworkElement>([NotNull] this TFrameworkElement @this, Style style)
			where TFrameworkElement : FrameworkElement
		{
			@this.Style = style;
			return @this;
		}

		public static TFrameworkElement VerticalAlignment<TFrameworkElement>([NotNull] this TFrameworkElement @this, VerticalAlignment verticalAlignment)
			where TFrameworkElement : FrameworkElement
		{
			@this.VerticalAlignment = verticalAlignment;
			return @this;
		}

		public static TFrameworkElement OverridesDefaultStyle<TFrameworkElement>([NotNull] this TFrameworkElement @this, bool overridesDefaultStyle)
			where TFrameworkElement : FrameworkElement
		{
			@this.OverridesDefaultStyle = overridesDefaultStyle;
			return @this;
		}

		public static TFrameworkElement HorizontalAlignment<TFrameworkElement>([NotNull] this TFrameworkElement @this, HorizontalAlignment horizontalAlignment)
			where TFrameworkElement : FrameworkElement
		{
			@this.HorizontalAlignment = horizontalAlignment;
			return @this;
		}

		public static TFrameworkElement ContextMenu<TFrameworkElement>([NotNull] this TFrameworkElement @this, ContextMenu contextMenu)
			where TFrameworkElement : FrameworkElement
		{
			@this.ContextMenu = contextMenu;
			return @this;
		}

		public static TFrameworkElement ToolTip<TFrameworkElement>([NotNull] this TFrameworkElement @this, object toolTip)
			where TFrameworkElement : FrameworkElement
		{
			@this.ToolTip = toolTip;
			return @this;
		}

		public static TFrameworkElement ForceCursor<TFrameworkElement>([NotNull] this TFrameworkElement @this, bool forceCursor)
			where TFrameworkElement : FrameworkElement
		{
			@this.ForceCursor = forceCursor;
			return @this;
		}

		public static void Cursor<TFrameworkElement>([NotNull] this TFrameworkElement @this, Cursor cursor)
			where TFrameworkElement : FrameworkElement
		{
			@this.Cursor = cursor;
		}

		public static TFrameworkElement FocusVisualStyle<TFrameworkElement>([NotNull] this TFrameworkElement @this, Style focusVisualStyle)
			where TFrameworkElement : FrameworkElement
		{
			@this.FocusVisualStyle = focusVisualStyle;
			return @this;
		}
	}
}
