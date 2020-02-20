using System.Windows.Controls;

// ReSharper disable once CheckNamespace
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
