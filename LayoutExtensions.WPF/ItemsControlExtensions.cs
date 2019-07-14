using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class ItemsControlExtensions
	{
		public static void GroupStyle([NotNull] this ItemsControl @this, DataTemplate headerTemplate)
		{
			var groupStyle = new GroupStyle
			{
				HeaderTemplate = headerTemplate
			};

			@this.GroupStyle.Add(groupStyle);
		}

		public static ItemsControl ItemsPanel([NotNull] this ItemsControl @this, ItemsPanelTemplate itemsPanel)
		{
			@this.ItemsPanel = itemsPanel;
			return @this;
		}

		public static ItemsControl ItemTemplate([NotNull] this ItemsControl @this, DataTemplate itemTemplate)
		{
			@this.ItemTemplate = itemTemplate;
			return @this;
		}

		public static ItemsControl ItemContainerStyle([NotNull] this ItemsControl @this, Style itemContainerStyle)
		{
			@this.ItemContainerStyle = itemContainerStyle;
			return @this;
		}
	}
}
