using System.Windows.Controls.Primitives;

namespace LayoutExtensions.WPF
{
	public static class TextBoxBaseExtensions
	{
		public static TTextBoxBase ReadOnly<TTextBoxBase>(this TTextBoxBase @this)
			where TTextBoxBase : TextBoxBase
		{
			@this.IsReadOnly = true;
			return @this;
		}
	}
}
