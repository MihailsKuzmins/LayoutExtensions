using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public static class ContentControlExtensions
	{
		public static TContentControl ContentTemplate<TContentControl>(this TContentControl @this, DataTemplate template)
			where TContentControl : ContentControl
		{
			@this.ContentTemplate = template;
			return @this;
		}

		public static TContentControl Content<TContentControl>(this TContentControl @this, object content)
			where TContentControl : ContentControl
		{
			@this.Content = content;
			return @this;
		}

		public static TContentControl ContentStringFormat<TContentControl>(this TContentControl @this, string contentStringFormat)
			where TContentControl : ContentControl
		{
			@this.ContentStringFormat = contentStringFormat;
			return @this;
		}

		public static TContentControl ContentTemplateSelector<TContentControl>(this TContentControl @this, DataTemplateSelector contentTemplateSelector)
			where TContentControl : ContentControl
		{
			@this.ContentTemplateSelector = contentTemplateSelector;
			return @this;
		}
	}
}
