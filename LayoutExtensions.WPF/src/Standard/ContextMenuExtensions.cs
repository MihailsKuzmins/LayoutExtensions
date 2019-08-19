using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LayoutExtensions.WPF
{
	public static class ContextMenuExtensions
	{
		public static void ApplyTo([NotNull] this ContextMenu @this, FrameworkElement frameworkElement)
		{
			frameworkElement.ContextMenu = @this;
		}

		public static ContextMenu MenuItem([NotNull] this ContextMenu @this, MenuItem menuItem)
		{
			@this.Items.Add(menuItem);
			return @this;
		}

		public static ContextMenu MenuItem([NotNull] this ContextMenu @this, string header, ICommand command)
		{
			var menuItem = CreateMenuItem(header, command);
			@this.Items.Add(menuItem);

			return @this;
		}

		public static ContextMenu MenuItem([NotNull] this ContextMenu @this, string header, ICommand command, out MenuItem menuItem)
		{
			menuItem = CreateMenuItem(header, command);
			@this.Items.Add(menuItem);

			return @this;
		}

		public static ContextMenu MenuItem([NotNull] this ContextMenu @this, string header, out MenuItem menuItem)
		{
			menuItem = CreateMenuItem(header, null);
			@this.Items.Add(menuItem);

			return @this;
		}

		private static MenuItem CreateMenuItem(string header, ICommand command) =>
			new MenuItem
			{
				Header = header,
				Command = command
			};
	}
}
