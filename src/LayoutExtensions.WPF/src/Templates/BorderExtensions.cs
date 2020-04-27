using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF.Templates
{
	public static class BorderExtensions
	{
		public static TemplateCreator<T> Padding<T>(this TemplateCreator<T> @this, double uniform)
			where T : Border
		{
			return @this.Value(Border.PaddingProperty, new Thickness(uniform));
		}
	}
}
