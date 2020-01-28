using System.Windows.Data;

namespace LayoutExtensions.WPF
{
	public static class CollectionViewSourceExtensions
	{
		public static CollectionViewSource GroupDescription(this CollectionViewSource @this, string propertyName)
		{
			var groupDescription = new PropertyGroupDescription(propertyName);
			@this.GroupDescriptions.Add(groupDescription);

			return @this;
		}
	}
}
