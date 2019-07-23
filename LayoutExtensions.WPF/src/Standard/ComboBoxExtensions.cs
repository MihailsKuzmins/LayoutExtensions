using JetBrains.Annotations;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class ComboBoxExtensions
	{
		public static ComboBox Editable([NotNull] this ComboBox @this)
		{
			@this.IsEditable = true;
			return @this;
		}
	}
}
