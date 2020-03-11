using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.Controls
{
	public static class ImageExtensions
	{
		public static TImage Source<TImage>(this TImage @this, ImageSource imageSource)
			where TImage : Image
		{
			@this.Source = imageSource;
			return @this;
		}
	}
}
