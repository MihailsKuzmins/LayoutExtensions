// ReSharper disable once CheckNamespace
namespace LayoutExtensions.WPF
{
	public struct WindowBounds
	{
		public WindowBounds(double top, double left, double width, double height)
		{
			Top = top;
			Left = left;
			Width = width;
			Height = height;
		}

		public double Top { get; }

		public double Left { get; }

		public double Width { get; }

		public double Height { get; }
	}
}
