using JetBrains.Annotations;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LayoutExtensions.WPF
{
	public static class StringExtensions
	{
		public static ImageSource ToImageSource([NotNull] this string @this, string iconNameWithExtension, Assembly assembly, params string[] pathSegments)
		{
			var assemblyName = assembly.FullName;
			var resourcePath = Path.Combine(pathSegments);

			return new BitmapImage(
				new Uri($"pack://application:,,,/{assemblyName};component/{resourcePath}/{iconNameWithExtension}"));
		}
	}
}
