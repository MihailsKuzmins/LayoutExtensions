using System.Windows.Controls;

namespace LayoutExtensions.WPF.Controls
{
	public static class ComboBoxExtensions
	{
		public static TComboBox Editable<TComboBox>(this TComboBox @this)
			where TComboBox : ComboBox
		{
			@this.IsEditable = true;
			return @this;
		}
	}
}
