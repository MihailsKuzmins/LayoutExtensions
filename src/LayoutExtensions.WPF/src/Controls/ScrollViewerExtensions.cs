using System.Windows.Controls;
using SBV = System.Windows.Controls.ScrollBarVisibility;


namespace LayoutExtensions.WPF.Controls
{
	public static class ScrollViewerExtensions
	{
		public static TScrollViewer ScrollBarAuto<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			@this
				.ScrollBarVisibilityH(SBV.Auto)
				.ScrollBarVisibilityV(SBV.Auto);

		public static TScrollViewer ScrollBarAutoH<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			 @this.ScrollBarVisibilityH(SBV.Auto);

		public static TScrollViewer ScrollBarAutoV<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			 @this.ScrollBarVisibilityV(SBV.Auto);

		public static TScrollViewer ScrollBarHidden<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			@this
				.ScrollBarVisibilityH(SBV.Hidden)
				.ScrollBarVisibilityV(SBV.Hidden);

		public static TScrollViewer ScrollBarHiddenH<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			 @this.ScrollBarVisibilityH(SBV.Hidden);

		public static TScrollViewer ScrollBarHiddenV<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			 @this.ScrollBarVisibilityV(SBV.Hidden);

		public static TScrollViewer ScrollBarVisible<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			@this
				.ScrollBarVisibilityH(SBV.Visible)
				.ScrollBarVisibilityV(SBV.Visible);

		public static TScrollViewer ScrollBarVisibleH<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			 @this.ScrollBarVisibilityH(SBV.Visible);

		public static TScrollViewer ScrollBarVisibleV<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			 @this.ScrollBarVisibilityV(SBV.Visible);

		public static TScrollViewer ScrollBarDisabled<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			@this
				.ScrollBarVisibilityH(SBV.Disabled)
				.ScrollBarVisibilityV(SBV.Disabled);

		public static TScrollViewer ScrollBarDisabledH<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer =>
			 @this.ScrollBarVisibilityH(SBV.Disabled);

		public static TScrollViewer ScrollBarDisabledV<TScrollViewer>(this TScrollViewer @this) where TScrollViewer : ScrollViewer => 
			@this.ScrollBarVisibilityV(SBV.Disabled);

		private static TScrollViewer ScrollBarVisibilityH<TScrollViewer>(this TScrollViewer @this, SBV scrollBarVisibility)
			where TScrollViewer : ScrollViewer
		{
			@this.HorizontalScrollBarVisibility = scrollBarVisibility;
			return @this;
		}

		private static TScrollViewer ScrollBarVisibilityV<TScrollViewer>(this TScrollViewer @this, SBV scrollBarVisibility)
			where TScrollViewer : ScrollViewer
		{
			@this.VerticalScrollBarVisibility = scrollBarVisibility;
			return @this;
		}
	}
}
