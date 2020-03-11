using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class GridExtensions
	{
		public static TGrid Rows<TGrid>(this TGrid @this, IEnumerable<RowDefinition> rows)
			where TGrid : Grid
		{
			@this.RowDefinitions.AddRange(rows);
			return @this;
		}

		public static TGrid Cols<TGrid>(this TGrid @this, IEnumerable<ColumnDefinition> cols)
			where TGrid : Grid
		{
			@this.ColumnDefinitions.AddRange(cols);
			return @this;
		}

		public static TGrid Rows<TGrid>(this TGrid @this, Func<IEnumerable<RowDefinition>> rowsFunc)
			where TGrid : Grid
		{
			@this.RowDefinitions.AddRange(rowsFunc?.Invoke() ?? Enumerable.Empty<RowDefinition>());
			return @this;
		}

		public static TGrid Cols<TGrid>(this TGrid @this, Func<IEnumerable<ColumnDefinition>> colsFunc)
			where TGrid : Grid
		{
			@this.ColumnDefinitions.AddRange(colsFunc?.Invoke() ?? Enumerable.Empty<ColumnDefinition>());
			return @this;
		}
	}
}
