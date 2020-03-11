using System.Windows.Controls.Primitives;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
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
