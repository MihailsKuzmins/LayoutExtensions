using System.Collections.Generic;
using System.Windows;
using System.Windows.Media.Animation;

// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF.Templates
{
	public class TriggerCreator
	{
		private readonly Trigger _trigger;
		private readonly IList<BeginStoryboard> _storyboards = new List<BeginStoryboard>();

		public TriggerCreator(DependencyProperty dependencyProperty, object value)
		{
			_trigger = new Trigger
			{
				Property = dependencyProperty,
				Value = value
			};
		}

		internal TriggerActionCollection EnterActions => _trigger.EnterActions;

		internal TriggerActionCollection ExitActions => _trigger.ExitActions;

		public Trigger ToTrigger(FrameworkTemplate template)
		{
			for (var i = 0; i < _storyboards.Count; i++)
				template.RegisterName(_storyboards[i].Name, _storyboards[i]);

			return _trigger;
		}

		internal void AddBeginStoryboard(BeginStoryboard beginStoryboard)
		{
			_storyboards.Add(beginStoryboard);
			EnterActions.Add(beginStoryboard);
		}
	}
}
