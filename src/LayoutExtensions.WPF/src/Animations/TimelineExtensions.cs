using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace LayoutExtensions.WPF.Animations
{
	public static class TimelineExtensions
	{
		public static TTimeline Duration<TTimeline>(this TTimeline @this, TimeSpan duration)
			where TTimeline : Timeline
		{
			@this.Duration = duration.Duration();
			return @this;
		}

		public static TTimeline Forever<TTimeline>(this TTimeline @this)
			where TTimeline : Timeline
		{
			@this.RepeatBehavior = RepeatBehavior.Forever;
			return @this;
		}

		public static TTimeline RepeatBehaviour<TTimeline>(this TTimeline @this, RepeatBehavior repeatBehavior)
			where TTimeline : Timeline
		{
			@this.RepeatBehavior = repeatBehavior;
			return @this;
		}

		public static TTimeline TargetProperty<TTimeline>(this TTimeline @this, string propertyPath)
			where TTimeline : Timeline
		{
			Storyboard.SetTargetProperty(@this, new PropertyPath(propertyPath));
			return @this;
		}

		public static TTimeline AddToStoryboard<TTimeline>(this TTimeline @this, Storyboard storyboard)
			where TTimeline : Timeline
		{
			storyboard.Children.Add(@this);
			return @this;
		}
	}
}
