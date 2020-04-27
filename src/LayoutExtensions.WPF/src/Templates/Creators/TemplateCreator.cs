using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF.Templates
{
	public class TemplateCreator<T> : ITemplateCreator
		where T : FrameworkElement
	{
		protected readonly FrameworkElementFactory FeFactory = new FrameworkElementFactory(typeof(T));

		public TemplateCreator(string? name = null)
		{
			if (!string.IsNullOrEmpty(name))
				FeFactory.Name = name;
		}

		public IList<TriggerCreator> TriggerCreators { get; } = new List<TriggerCreator>();

		FrameworkElementFactory ITemplateCreator.TemplateFactory => FeFactory;

		public ControlTemplate ToControlTemplate<TView>()
			where TView : Control
		{
			var template = new ControlTemplate(typeof(TView))
			{
				VisualTree = PrepareFactory()
			};

			for (var i = 0; i < TriggerCreators.Count; i++)
				template.Triggers.Add(TriggerCreators[i].ToTrigger(template));

			template.Seal();
			return template;
		}

		FrameworkElementFactory ITemplateCreator.PrepareTemplate() =>
			PrepareFactory();

		protected virtual FrameworkElementFactory PrepareFactory() =>
			FeFactory;
	}
}
