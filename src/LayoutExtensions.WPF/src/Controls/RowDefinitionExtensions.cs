using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF.Controls
{
	public static class RowDefinitionExtensions
	{
		public static TRowDefinition Auto<TRowDefinition>(this TRowDefinition @this, double value = 1d)
			where TRowDefinition : RowDefinition
		{
			@this.Height = new GridLength(value, GridUnitType.Auto);
			return @this;
		}

		public static TRowDefinition Pixel<TRowDefinition>(this TRowDefinition @this, double value = 1d)
			where TRowDefinition : RowDefinition
		{
			@this.Height = new GridLength(value, GridUnitType.Pixel);
			return @this;
		}

		public static TRowDefinition Star<TRowDefinition>(this TRowDefinition @this, double value = 1d)
			where TRowDefinition : RowDefinition
		{
			@this.Height = new GridLength(value, GridUnitType.Star);
			return @this;
		}
	}
}
