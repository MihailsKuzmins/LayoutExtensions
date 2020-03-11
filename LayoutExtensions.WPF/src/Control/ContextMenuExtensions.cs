using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class ContextMenuExtensions
	{
		public static void ApplyTo<TContextMenu>(this TContextMenu @this, FrameworkElement frameworkElement)
			where TContextMenu : ContextMenu
		{
			frameworkElement.ContextMenu = @this;
		}

		public static TContextMenu MenuItem<TContextMenu>(this TContextMenu @this, MenuItem menuItem)
			where TContextMenu : ContextMenu
		{
			@this.Items.Add(menuItem);
			return @this;
		}

		public static TContextMenu MenuItem<TContextMenu>(this TContextMenu @this, string header, ICommand command)
			where TContextMenu : ContextMenu
		{
			var menuItem = CreateMenuItem(header, command);
			@this.Items.Add(menuItem);

			return @this;
		}

		public static TContextMenu MenuItem<TContextMenu>(this TContextMenu @this, string header, ICommand command, out MenuItem menuItem)
			where TContextMenu : ContextMenu
		{
			menuItem = CreateMenuItem(header, command);
			@this.Items.Add(menuItem);

			return @this;
		}

		public static TContextMenu MenuItem<TContextMenu>(this TContextMenu @this, string header, out MenuItem menuItem)
			where TContextMenu : ContextMenu
		{
			menuItem = CreateMenuItem(header, null);
			@this.Items.Add(menuItem);

			return @this;
		}

		private static MenuItem CreateMenuItem(string header, ICommand? command) =>
			new MenuItem
			{
				Header = header,
				Command = command
			};
	}
}
