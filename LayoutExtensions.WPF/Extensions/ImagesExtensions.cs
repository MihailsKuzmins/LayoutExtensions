using System;

namespace LayoutExtensions.WPF.Extensions
{
	internal static class ImagesExtensions
	{
		internal static string ToImageString(this Images source)
		{
			switch (source)
			{
				case Images.Jpg:
					return "jpg";
				case Images.Png:
					return "png";
				default:
					throw new ArgumentOutOfRangeException($"Cannot resolve image extension for {source}", nameof(source));
			}
		}
	}
}
