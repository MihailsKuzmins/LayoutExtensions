using JetBrains.Annotations;
using LayoutExtensions.WPF.Extensions;
using System.Collections.Generic;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class GridExtensions
	{
		public static Grid Rows([NotNull] this Grid @this, IEnumerable<RowDefinition> rows)
		{
			@this.RowDefinitions.AddRange(rows);
			return @this;
		}

		public static Grid Cols([NotNull] this Grid @this, IEnumerable<ColumnDefinition> cols)
		{
			@this.ColumnDefinitions.AddRange(cols);
			return @this;
		}
	}
}
