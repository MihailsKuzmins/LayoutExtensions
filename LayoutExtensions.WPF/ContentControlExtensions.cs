using JetBrains.Annotations;
using System.Windows;
using System.Windows.Controls;

namespace LayoutExtensions.WPF
{
	public static class ContentControlExtensions
	{
		public static TContentControl ContentTemplate<TContentControl>([NotNull] this TContentControl @this, DataTemplate template)
			where TContentControl : ContentControl
		{
			@this.ContentTemplate = template;
			return @this;
		}

		public static TContentControl Content<TContentControl>([NotNull] this TContentControl @this, object content)
			where TContentControl : ContentControl
		{
			@this.Content = content;
			return @this;
		}

		public static TContentControl ContentStringFormat<TContentControl>([NotNull] this TContentControl @this, string contentStringFormat)
			where TContentControl : ContentControl
		{
			@this.ContentStringFormat = contentStringFormat;
			return @this;
		}

		public static TContentControl ContentTemplateSelector<TContentControl>([NotNull] this TContentControl @this, DataTemplateSelector contentTemplateSelector)
			where TContentControl : ContentControl
		{
			@this.ContentTemplateSelector = contentTemplateSelector;
			return @this;
		}
	}
}
