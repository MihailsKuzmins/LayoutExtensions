using LayoutExtensions.WPF.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class GridExtensions
	{
		public static Grid Rows(this Grid @this, IEnumerable<RowDefinition> rows)
		{
			@this.RowDefinitions.AddRange(rows);
			return @this;
		}

		public static Grid Cols(this Grid @this, IEnumerable<ColumnDefinition> cols)
		{
			@this.ColumnDefinitions.AddRange(cols);
			return @this;
		}

		public static Grid Rows(this Grid @this, Func<IEnumerable<RowDefinition>> rowsFunc)
		{
			@this.RowDefinitions.AddRange(rowsFunc?.Invoke() ?? Enumerable.Empty<RowDefinition>());
			return @this;
		}

		public static Grid Cols(this Grid @this, Func<IEnumerable<ColumnDefinition>> colsFunc)
		{
			@this.ColumnDefinitions.AddRange(colsFunc?.Invoke() ?? Enumerable.Empty<ColumnDefinition>());
			return @this;
		}
	}
}
