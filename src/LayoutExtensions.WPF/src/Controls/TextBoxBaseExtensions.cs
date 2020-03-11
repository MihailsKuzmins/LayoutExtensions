using System.Windows.Controls.Primitives;

namespace LayoutExtensions.WPF.Controls
{
	public static class TextBoxBaseExtensions
	{
		public static TTextBoxBase ReadOnlyTextBox<TTextBoxBase>(this TTextBoxBase @this)
			where TTextBoxBase : TextBoxBase
		{
			@this.IsReadOnly = true;
			return @this;
		}
	}
}
