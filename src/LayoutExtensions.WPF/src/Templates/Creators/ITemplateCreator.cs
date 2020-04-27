using System.Windows;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF.Templates
{
	public interface ITemplateCreator
	{
		internal FrameworkElementFactory TemplateFactory { get; }

		internal FrameworkElementFactory PrepareTemplate();
	}
}
