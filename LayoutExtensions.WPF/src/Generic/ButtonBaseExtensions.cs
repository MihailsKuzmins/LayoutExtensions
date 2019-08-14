using JetBrains.Annotations;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace LayoutExtensions.WPF.src.Generic
{
	public static class ButtonBaseExtensions
	{
		public static TButtonBase Command<TButtonBase>([NotNull] this TButtonBase @this, ICommand command)
			where TButtonBase : ButtonBase
		{
			@this.Command = command;
			return @this;
		}
	}
}
