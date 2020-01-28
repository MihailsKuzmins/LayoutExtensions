using System.Windows.Controls;
using SBV = System.Windows.Controls.ScrollBarVisibility;

namespace LayoutExtensions.WPF
{
	public static class ScrollViewerExtensions
	{
		public static ScrollViewer ScrollBarAuto(this ScrollViewer @this) =>
			@this
				.ScrollBarVisibilityH(SBV.Auto)
				.ScrollBarVisibilityV(SBV.Auto);

		public static ScrollViewer ScrollBarAutoH(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Auto);

		public static ScrollViewer ScrollBarAutoV(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Auto);

		public static ScrollViewer ScrollBarHidden(this ScrollViewer @this) =>
			@this
				.ScrollBarVisibilityH(SBV.Hidden)
				.ScrollBarVisibilityV(SBV.Hidden);

		public static ScrollViewer ScrollBarHiddenH(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Hidden);

		public static ScrollViewer ScrollBarHiddenV(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Hidden);

		public static ScrollViewer ScrollBarVisible(this ScrollViewer @this) =>
			@this
				.ScrollBarVisibilityH(SBV.Visible)
				.ScrollBarVisibilityV(SBV.Visible);

		public static ScrollViewer ScrollBarVisibleH(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Visible);

		public static ScrollViewer ScrollBarVisibleV(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Visible);

		public static ScrollViewer ScrollBarDisabled(this ScrollViewer @this) =>
			@this
				.ScrollBarVisibilityH(SBV.Disabled)
				.ScrollBarVisibilityV(SBV.Disabled);

		public static ScrollViewer ScrollBarDisabledH(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityH(SBV.Disabled);

		public static ScrollViewer ScrollBarDisabledV(this ScrollViewer @this) =>
			 @this.ScrollBarVisibilityV(SBV.Disabled);

		private static ScrollViewer ScrollBarVisibilityH(this ScrollViewer @this, SBV scrollBarVisibility)
		{
			@this.HorizontalScrollBarVisibility = scrollBarVisibility;
			return @this;
		}

		private static ScrollViewer ScrollBarVisibilityV(this ScrollViewer @this, SBV scrollBarVisibility)
		{
			@this.VerticalScrollBarVisibility = scrollBarVisibility;
			return @this;
		}
	}
}
