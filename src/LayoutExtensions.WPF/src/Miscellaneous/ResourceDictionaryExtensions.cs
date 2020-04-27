using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace LayoutExtensions.WPF.Miscellaneous
{
	public static class ResourceDictionaryExtensions
	{
		public static ResourceDictionary Source(this ResourceDictionary @this, string resourceName, Assembly assembly, params string[] pathSegments)
		{
			var resourcePath = Path.Combine(pathSegments);
			@this.Source = new Uri($"/{assembly.FullName};component/{resourcePath}/{resourceName}.xaml");

			return @this;
		}

		public static T Get<T>(this ResourceDictionary @this, string key) =>
			(T)@this[key];
	}
}
