using JetBrains.Annotations;
using System.Windows.Controls;
using SBV = System.Windows.Controls.ScrollBarVisibility;

namespace LayoutExtensions.WPF
{
	public static class ScrollViewerExtensions
	{
		public static ScrollViewer ScrollBarAuto([NotNull] this ScrollViewer @this)
		{
			return @this
				.ScrollBarVisibilityH(SBV.Auto)
				.ScrollBarVisibilityV(SBV.Auto);
		}

		public static ScrollViewer ScrollBarAutoH([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Auto);

		public static ScrollViewer ScrollBarAutoV([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Auto);

		public static ScrollViewer ScrollBarHidden([NotNull] this ScrollViewer @this)
		{
			return @this
				.ScrollBarVisibilityH(SBV.Hidden)
				.ScrollBarVisibilityV(SBV.Hidden);
		}

		public static ScrollViewer ScrollBarHiddenH([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Hidden);

		public static ScrollViewer ScrollBarHiddenV([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Hidden);

		public static ScrollViewer ScrollBarVisible([NotNull] this ScrollViewer @this)
		{
			return @this
				.ScrollBarVisibilityH(SBV.Visible)
				.ScrollBarVisibilityV(SBV.Visible);
		}

		public static ScrollViewer ScrollBarVisibleH([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Visible);

		public static ScrollViewer ScrollBarVisibleV([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Visible);

		public static ScrollViewer ScrollBarDisabled([NotNull] this ScrollViewer @this)
		{
			return @this
				.ScrollBarVisibilityH(SBV.Disabled)
				.ScrollBarVisibilityV(SBV.Disabled);
		}

		public static ScrollViewer ScrollBarDisabledH([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Disabled);

		public static ScrollViewer ScrollBarDisbledV([NotNull] this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Disabled);

		private static ScrollViewer ScrollBarVisibilityH([NotNull] this ScrollViewer @this, SBV scrollBarVisibility)
		{
			@this.HorizontalScrollBarVisibility = scrollBarVisibility;
			return @this;
		}

		private static ScrollViewer ScrollBarVisibilityV([NotNull] this ScrollViewer @this, SBV scrollBarVisibility)
		{
			@this.VerticalScrollBarVisibility = scrollBarVisibility;

			return @this;
		}
	}
}
