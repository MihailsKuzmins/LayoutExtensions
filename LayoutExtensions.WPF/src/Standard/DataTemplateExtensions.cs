using JetBrains.Annotations;
using System;
using System.Windows;
using System.Windows.Data;

namespace LayoutExtensions.WPF.src.Standard
{
	public static class DataTemplateExtensions
	{
		public static DataTemplate From([NotNull] this DataTemplate @this, Type viewType)
		{
			var templateFactory = new FrameworkElementFactory(viewType);
			templateFactory.SetBinding(FrameworkElement.DataContextProperty, new Binding());

			@this.VisualTree = templateFactory;
			return @this;
		}

		public static DataTemplate DataType([NotNull] this DataTemplate @this, Type dataType)
		{
			@this.DataType = dataType;
			return @this;
		}
	}
}
