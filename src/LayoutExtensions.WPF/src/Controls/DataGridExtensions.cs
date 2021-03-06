﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

namespace LayoutExtensions.WPF.Controls
{
	public static class DataGridExtensions
	{
		public static TDataGrid Cols<TDataGrid>(this TDataGrid @this, Func<IEnumerable<DataGridColumn>> colsFunc, bool expandLast = false)
			where TDataGrid : DataGrid
		{
			@this.Columns.AddRange(colsFunc());

			if (expandLast)
				@this.Columns.Last().Width = new DataGridLength(1, DataGridLengthUnitType.Star);

			return @this;
		}

		public static TDataGrid ExpandLastCol<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.Columns.Last().Width = new DataGridLength(1, DataGridLengthUnitType.Star);
			return @this;
		}

		public static TDataGrid ColumnsCannotResize<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.CanUserResizeColumns = false;
			return @this;
		}

		public static TDataGrid ColumnsCanResize<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.CanUserResizeColumns = true;
			return @this;
		}

		public static TDataGrid RowsCannotResize<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.CanUserResizeRows = false;
			return @this;
		}

		public static TDataGrid RowsCanResize<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.CanUserResizeRows = true;
			return @this;
		}

		public static TDataGrid ColumnsNotAutoGenerated<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.AutoGenerateColumns = false;
			return @this;
		}

		public static TDataGrid ColumnsAutoGenerated<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.AutoGenerateColumns = true;
			return @this;
		}

		public static TDataGrid ColumnsCannotReorder<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.CanUserReorderColumns = false;
			return @this;
		}

		public static TDataGrid ColumnsCanReorder<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.CanUserReorderColumns = true;
			return @this;
		}

		public static TDataGrid ReadOnlyDataGrid<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.IsReadOnly = true;
			return @this;
		}

		public static TDataGrid NotReadOnlyDataGrid<TDataGrid>(this TDataGrid @this)
			where TDataGrid : DataGrid
		{
			@this.IsReadOnly = false;
			return @this;
		}

		public static TDataGrid RowBackground<TDataGrid>(this TDataGrid @this, Brush brush)
			where TDataGrid : DataGrid
		{
			@this.RowBackground = brush;
			return @this;
		}

		public static TDataGrid RowBackground<TDataGrid>(this TDataGrid @this, Color color)
			where TDataGrid : DataGrid
		{
			@this.RowBackground = new SolidColorBrush(color);
			return @this;
		}

		public static TDataGrid RowBackground<TDataGrid>(this TDataGrid @this, byte a, byte r, byte g, byte b)
			where TDataGrid : DataGrid
		{
			@this.RowBackground = new SolidColorBrush(Color.FromArgb(a, r, g, b));
			return @this;
		}

		public static TDataGrid RowBackground<TDataGrid>(this TDataGrid @this, byte r, byte g, byte b)
			where TDataGrid : DataGrid
		{
			@this.RowBackground = new SolidColorBrush(Color.FromRgb(r, g, b));
			return @this;
		}

		public static TDataGrid SelectionUnit<TDataGrid>(this TDataGrid @this, DataGridSelectionUnit selectionUnit)
			where TDataGrid : DataGrid
		{
			@this.SelectionUnit = selectionUnit;
			return @this;
		}
	}
}
