using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.Templates
{
	public static class ImageExtensions
	{
		public static TemplateCreator<T> Source<T>(this TemplateCreator<T> @this, ImageSource imageSource)
			where T : Image
		{
			return @this.Value(Image.SourceProperty, imageSource);
		}
	}
}
