using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF
{
	public static class ImageExtensions
	{
		public static Image Source(this Image @this, ImageSource imageSource)
		{
			@this.Source = imageSource;
			return @this;
		}
	}
}
