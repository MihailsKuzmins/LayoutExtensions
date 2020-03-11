using System.Windows.Media.Animation;

namespace LayoutExtensions.WPF.Animations
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
