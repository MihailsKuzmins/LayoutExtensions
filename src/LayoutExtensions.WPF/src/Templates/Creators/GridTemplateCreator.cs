using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF.Templates
{
	public class GridTemplateCreator : PanelTemplateCreator<Grid>
	{
		public IList<GridLength> RowDefinitions { get; } = new List<GridLength>();

		public IList<GridLength> ColumnDefinitions { get; } = new List<GridLength>();

		protected override FrameworkElementFactory PrepareFactory()
		{
			for (var i = 0; i < RowDefinitions.Count; i++)
			{
				var row = new FrameworkElementFactory(typeof(RowDefinition));
				row.SetValue(RowDefinition.HeightProperty, RowDefinitions[i]);

				FeFactory.AppendChild(row);
			}

			for (var i = 0; i < ColumnDefinitions.Count; i++)
			{
				var column = new FrameworkElementFactory(typeof(ColumnDefinition));
				column.SetValue(ColumnDefinition.WidthProperty, ColumnDefinitions[i]);

				FeFactory.AppendChild(column);
			}

			return base.PrepareFactory();
		}
	}
}
