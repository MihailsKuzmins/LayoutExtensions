using JetBrains.Annotations;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF
{
	public static class ImageExtensions
	{
		public static Image Source([NotNull] this Image @this, ImageSource imageSource)
		{
			@this.Source = imageSource;
			return @this;
		}
	}
}
