using System.Windows.Media.Animation;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class DoubleAnimationExtensions
	{
		public static DoubleAnimation ToValue(this DoubleAnimation @this, double toValue)
		{
			@this.To = toValue;
			return @this;
		}
	}
}
