using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace LayoutExtensions.WPF.Controls
{
	public static class DataGridColumnExtensions
	{
		public static T Star<T>(this T @this, double star = 1d)
			where T : DataGridColumn
		{
			@this.Width = new DataGridLength(star, DataGridLengthUnitType.Star);
			return @this;
		}

		public static T Header<T>(this T @this, string header)
			where T : DataGridColumn
		{
			@this.Header = header;
			return @this;
		}

		public static T MinWidth<T>(this T @this, double minWidth)
			where T : DataGridColumn
		{
			@this.MinWidth = minWidth;
			@this.MinWidth = minWidth;
			return @this;
		}

		public static T Binding<T>(this T @this, string propertyName, Action<Binding>? applyAction = null)
			where T : DataGridBoundColumn
		{
			var binding = new Binding(propertyName);
			applyAction?.Invoke(binding);

			@this.Binding = binding;
			return @this;
		}

		public static T ElementStyle<T>(this T @this, Style style)
			where T : DataGridBoundColumn
		{
			@this.ElementStyle = style;
			return @this;
		}

		public static T CellTemplate<T>(this T @this, DataTemplate dataTemplate)
			where T : DataGridTemplateColumn
		{
			@this.CellTemplate = dataTemplate;
			return @this;
		}

		public static T CellTemplate<T>(this T @this, Func<DataTemplate> dataTemplateFunc)
			where T : DataGridTemplateColumn
		{
			@this.CellTemplate = dataTemplateFunc();
			return @this;
		}
	}
}
