using System.Windows.Controls;
using System.Windows.Media;

// ReSharper disable once CheckNamespace
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
