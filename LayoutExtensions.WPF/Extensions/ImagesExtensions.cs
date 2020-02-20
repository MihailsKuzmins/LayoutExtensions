using System;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	internal static class ImagesExtensions
	{
		internal static string ToImageString(this Images source) =>
			source switch
			{
				Images.Jpg => "jpg",
				Images.Png => "png",
				Images.Ico => "ico",
				_ => throw new ArgumentOutOfRangeException($"Cannot resolve image extension for {source}", nameof(source)),
			};
	}
}
