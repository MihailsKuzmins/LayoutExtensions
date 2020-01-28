using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class ComboBoxExtensions
	{
		public static ComboBox Editable(this ComboBox @this)
		{
			@this.IsEditable = true;
			return @this;
		}
	}
}
