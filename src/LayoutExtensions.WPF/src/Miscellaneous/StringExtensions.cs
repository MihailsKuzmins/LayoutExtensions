﻿using System;
using System.IO;
using System.Reflection;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LayoutExtensions.WPF.Miscellaneous
{
	public static class StringExtensions
	{
		public static ImageSource ToImageSource(this string @this, string extension, Assembly assembly, params string[] pathSegments) =>
			GetImageSource(@this, extension, assembly, pathSegments);

		public static ImageSource ToImageSource(this string @this, Images extension, Assembly assembly, params string[] pathSegments)
		{
			var extensionName = extension.ToImageString();
			return GetImageSource(@this, extensionName, assembly, pathSegments);
		}

		private static ImageSource GetImageSource(string fileName, string extension, Assembly assembly, params string[] pathSegments)
		{
			var resourcePath = Path.Combine(pathSegments);

			return new BitmapImage(
				new Uri($"pack://application:,,,/{assembly.FullName};component/{resourcePath}/{fileName}.{extension}"));
		}
	}
}
