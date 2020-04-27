using System.Windows.Media.Animation;

namespace LayoutExtensions.WPF.Templates
{
	public static class TriggerCreatorExtensions
	{
		public static TriggerCreator AddStoryboard(this TriggerCreator @this, Storyboard storyboard, string name)
		{
			var beginStoryBoard = new BeginStoryboard
			{
				Storyboard = storyboard,
				Name = name
			};

			@this.AddBeginStoryboard(beginStoryBoard);
			@this.ExitActions.Add(new StopStoryboard
			{
				BeginStoryboardName = name
			});

			return @this;
		}
	}
}
