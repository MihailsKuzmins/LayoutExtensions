using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF.Controls
{
	public static class ColumnDefinitionExtensions
	{
		public static TColumnDefinition Auto<TColumnDefinition>(this TColumnDefinition @this, double value = 1d)
			where TColumnDefinition : ColumnDefinition
		{
			@this.Width = new GridLength(value, GridUnitType.Auto);
			return @this;
		}

		public static TColumnDefinition Pixel<TColumnDefinition>(this TColumnDefinition @this, double value = 1d)
			where TColumnDefinition : ColumnDefinition
		{
			@this.Width = new GridLength(value, GridUnitType.Pixel);
			return @this;
		}

		public static TColumnDefinition Star<TColumnDefinition>(this TColumnDefinition @this, double value = 1d)
			where TColumnDefinition : ColumnDefinition
		{
			@this.Width = new GridLength(value, GridUnitType.Star);
			return @this;
		}
	}
}
