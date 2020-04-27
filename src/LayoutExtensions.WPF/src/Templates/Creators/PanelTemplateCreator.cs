using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF.Templates
{
	public class PanelTemplateCreator<T> : TemplateCreator<T>
		where T : Panel
	{
		public PanelTemplateCreator(string? name = null)
			: base(name)
		{
		}

		public IList<ITemplateCreator> Children { get; } = new List<ITemplateCreator>();

		protected override FrameworkElementFactory PrepareFactory()
		{
			for (var i = 0; i < Children.Count; i++)
				FeFactory.AppendChild(Children[i].PrepareTemplate());

			return base.PrepareFactory();
		}
	}
}
