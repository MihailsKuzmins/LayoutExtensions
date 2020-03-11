using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
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
