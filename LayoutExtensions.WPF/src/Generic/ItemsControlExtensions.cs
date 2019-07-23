using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class ItemsControlExtensions
	{
		public static void GroupStyle<TItemsControl>([NotNull] this TItemsControl @this, DataTemplate headerTemplate)
			where TItemsControl : ItemsControl
		{
			var groupStyle = new GroupStyle
			{
				HeaderTemplate = headerTemplate
			};

			@this.GroupStyle.Add(groupStyle);
		}

		public static TItemsControl ItemsPanel<TItemsControl>([NotNull] this TItemsControl @this, ItemsPanelTemplate itemsPanel)
			where TItemsControl : ItemsControl
		{
			@this.ItemsPanel = itemsPanel;
			return @this;
		}

		public static TItemsControl ItemTemplate<TItemsControl>([NotNull] this TItemsControl @this, DataTemplate itemTemplate)
			where TItemsControl : ItemsControl
		{
			@this.ItemTemplate = itemTemplate;
			return @this;
		}

		public static TItemsControl ItemContainerStyle<TItemsControl>([NotNull] this TItemsControl @this, Style itemContainerStyle)
			where TItemsControl : ItemsControl
		{
			@this.ItemContainerStyle = itemContainerStyle;
			return @this;
		}

		public static TItemsControl DisplayMemberPath<TItemsControl>([NotNull] this TItemsControl @this, string displayMemberPath)
			where TItemsControl : ItemsControl
		{
			@this.DisplayMemberPath = displayMemberPath;
			return @this;
		}
	}
}
