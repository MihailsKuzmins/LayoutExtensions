using LayoutExtensions.WPF.Controls;
using Microsoft.Extensions.ObjectPool;
using System;
using System.Linq;
using System.Reflection;

namespace LayoutExtensions.Wpf.MethodDescriptionGenerator
{
	internal class Program
	{
		private static void Main()
		{
			const string extensionsSuffix = "Extensions";

			var stringBuilderPool = new DefaultObjectPoolProvider()
				.CreateStringBuilderPool();

			var extensionGroups = typeof(DependencyObjectExtensions).Assembly
				.GetExportedTypes()
				.Where(x => x.Name.EndsWith(extensionsSuffix))
				.GroupBy(x =>
				{
					// ReSharper disable once PossibleNullReferenceException
					var groupSeparatorIndex = x.Namespace.LastIndexOf('.');
					return x.Namespace.Substring(groupSeparatorIndex + 1);
				}, x => (x.Name, Funcs: x.GetMethods(BindingFlags.Public | BindingFlags.Static)))
				.OrderBy(x => x.Key)
				.Select(grouping =>
				{
					var classes = grouping
						.Select(x =>
						{
							var funcNames = x.Funcs
								.Select(y => y.Name)
								.Distinct()
								.OrderBy(y => y);

							return stringBuilderPool.Get()
								.AppendFormat(" - **{0}** - ", x.Name.Replace(extensionsSuffix, string.Empty))
								.AppendJoin(", ", funcNames)
								.ToString();
						});

					return stringBuilderPool.Get()
						.AppendFormat("### {0} extensions:", grouping.Key)
						.AppendLine()
						.AppendJoin(';' + Environment.NewLine, classes)
						.ToString();
				});

			var description = stringBuilderPool.Get()
				.AppendJoin('.' + Environment.NewLine + Environment.NewLine, extensionGroups)
				.Append('.')
				.ToString();
		}
	}
}
