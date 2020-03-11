using System;
using System.Linq;
using System.Reflection;
using LayoutExtensions.WPF;
using LayoutExtensions.WPF.Controls;

namespace LayoutExtensions.Wpf.MethodDescriptionGenerator
{
	internal class Program
	{
		private static void Main()
		{
			var classes = typeof(DependencyObjectExtensions).Assembly
				.GetExportedTypes()
				.Where(x => x.Name.EndsWith("Extensions"));
		}
	}
}
