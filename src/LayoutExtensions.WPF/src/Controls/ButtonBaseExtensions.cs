﻿using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace LayoutExtensions.WPF.Controls
{
	public static class ButtonBaseExtensions
	{
		public static TButtonBase Command<TButtonBase>(this TButtonBase @this, ICommand command)
			where TButtonBase : ButtonBase
		{
			@this.Command = command;
			return @this;
		}

		public static TButtonBase CommandParameter<TButtonBase>(this TButtonBase @this, object commandParameter)
			where TButtonBase : ButtonBase
		{
			@this.CommandParameter = commandParameter;
			return @this;
		}
	}
}
