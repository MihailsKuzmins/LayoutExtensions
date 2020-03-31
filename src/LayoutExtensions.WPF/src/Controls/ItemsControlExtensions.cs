using System;
using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF.Controls
{
	public static class ItemsControlExtensions
	{
		public static void GroupStyle<TItemsControl>(this TItemsControl @this, DataTemplate headerTemplate)
			where TItemsControl : ItemsControl
		{
			var groupStyle = new GroupStyle
			{
				HeaderTemplate = headerTemplate
			};

			@this.GroupStyle.Add(groupStyle);
		}

		public static TItemsControl ItemsPanel<TItemsControl>(this TItemsControl @this, ItemsPanelTemplate itemsPanel)
			where TItemsControl : ItemsControl
		{
			@this.ItemsPanel = itemsPanel;
			return @this;
		}

		public static TItemsControl ItemTemplate<TItemsControl>(this TItemsControl @this, DataTemplate itemTemplate)
			where TItemsControl : ItemsControl
		{
			@this.ItemTemplate = itemTemplate;
			return @this;
		}

		public static TItemsControl ItemTemplate<TItemsControl>(this TItemsControl @this, Func<DataTemplate> itemTemplateFunc)
			where TItemsControl : ItemsControl
		{
			@this.ItemTemplate = itemTemplateFunc();
			return @this;
		}

		public static TItemsControl ItemContainerStyle<TItemsControl>(this TItemsControl @this, Style itemContainerStyle)
			where TItemsControl : ItemsControl
		{
			@this.ItemContainerStyle = itemContainerStyle;
			return @this;
		}

		public static TItemsControl DisplayMemberPath<TItemsControl>(this TItemsControl @this, string displayMemberPath)
			where TItemsControl : ItemsControl
		{
			@this.DisplayMemberPath = displayMemberPath;
			return @this;
		}
	}
}
