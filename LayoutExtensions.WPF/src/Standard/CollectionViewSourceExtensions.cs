using JetBrains.Annotations;
using System.Windows.Data;

namespace LayoutExtensions.WPF
{
	public static class CollectionViewSourceExtensions
	{
		public static CollectionViewSource GroupDescription([NotNull] this CollectionViewSource @this, string propertyName)
		{
			var groupDescription = new PropertyGroupDescription(propertyName);
			@this.GroupDescriptions.Add(groupDescription);

			return @this;
		}
	}
}
