using System;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF.Templates
{
	public class ContentTemplateCreator<T> : TemplateCreator<T>
		where T : ContentControl
	{
		public ContentTemplateCreator(string? name = null)
			: base(name)
		{
		}

		public ITemplateCreator? Content { get; set; }

		protected override FrameworkElementFactory PrepareFactory()
		{
			if (Content == null)
				throw new NullReferenceException($"{nameof(Content)} is NULL");

			FeFactory.AppendChild(Content.PrepareTemplate());
			return base.PrepareFactory();
		}
	}
}
