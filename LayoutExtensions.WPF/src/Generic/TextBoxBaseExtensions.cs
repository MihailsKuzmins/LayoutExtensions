using JetBrains.Annotations;
using System.Windows.Controls.Primitives;

namespace LayoutExtensions.WPF
{
	public static class TextBoxBaseExtensions
	{
		public static TTextBoxBase ReadOnly<TTextBoxBase>([NotNull] this TTextBoxBase @this)
			where TTextBoxBase : TextBoxBase
		{
			@this.IsReadOnly = true;
			return @this;
		}
	}
}
