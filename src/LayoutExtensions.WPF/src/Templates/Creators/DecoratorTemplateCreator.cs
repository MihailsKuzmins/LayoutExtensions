using System;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF.Templates
{
	public class DecoratorTemplateCreator<T> : TemplateCreator<T>
		where T : Decorator
	{
		public DecoratorTemplateCreator(string? name = null)
			: base(name)
		{
		}

		public ITemplateCreator? Child { get; set; }

		protected override FrameworkElementFactory PrepareFactory()
		{
			if (Child == null)
				throw new NullReferenceException($"{nameof(Child)} is NULL");

			FeFactory.AppendChild(Child.PrepareTemplate());
			return base.PrepareFactory();
		}
	}
}
