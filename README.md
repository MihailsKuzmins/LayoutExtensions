# LayoutExtensions

[![NuGet Stats](https://img.shields.io/nuget/v/LayoutExtensions.WPF.svg)](https://www.nuget.org/packages/LayoutExtensions.WPF/)

The library provides extension methods for assigning properties to FrameworkElements and Control in a fluent way. Using the library involves creating the UI in C#, non in XAML files. Currently there are only WPF extension methods.
Example:

	public class MainWindow() : Window
	{
		private readonly Label _titleLabel;
		private readonly ItemsControl _itemsControl;
		private readonly Button _backButton;

		public MainWindow()
		{
			new Grid()
			    .Rows(CreateRowDefinitions())
			    .Cols(CreateColumnDefinitions())
			    .Assign(out var contentGrid);

			new Label()
			    .Col(0, 2)
			    .FontSize(25)
			    .AddToPanel(contentGrid)
			    .Assign(out _titleLabel);

			new ItemsControl { ItemTemplate = CreateItemTemplate() }
			    .Row(1, 2)
			    .AddToPanel(contentGrid)
			    .Assign(out _itemsControl);

			new Button()
			    .Row(1, 2)
			    .Col(1)
			    .Content("Navigate back")
			    .AddToPanel(contentGrid)
			    .Assign(out _backButton);

			Content = contentGrid;
		}

		private static IEnumerable<RowDefinition> CreateRowDefinitions()
		{
			yield return new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
			yield return new RowDefinition { Height = GridLength.Auto };
			yield return new RowDefinition { Height = GridLength.Auto };
		}

		private static IEnumerable<ColumnDefinition> CreateColumnDefinitions()
		{
			yield return new ColumnDefinition { Width = new GridLength(200, GridUnitType.Pixel) };
			yield return new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
		}

		private static DataTemplate CreateItemTemplate()
		{
			var viewType = typeof(SomeExampleView);

			var templateFactory = new FrameworkElementFactory(viewType);
			templateFactory.SetBinding(DataContextProperty, new Binding("."));

			return new DataTemplate(viewType)
			{
				VisualTree = templateFactory
			};
		}
	}

Available extensions:
1) FrameworkElement - Width, MinWidth, MaxWidth, Height, MinHeight, MaxWidth, Tag, GetTag, Name, DataContext, GetDataContext, UseLayoutRounding, FlowDirection, Margin, MarginHorizontal, MarginVertical, MarginLeft, MarginTop, MarginRight, MarginBottom, Style, VerticalAlignment, OverridesDefaultStyle, HorizontalAlignment, ContextMenu, ToolTip, ForceCursor, Cursor, FocusVisualStyle, Top, CenterV, CenterH, Center, Botton, StretchV, StretchH, Stretch, Left, Right, AddToPanel, Row, Col;

2) Control - FontStyle, FontStretch, FontSize, FontFamily, FontFamily, Background, Foreground, Border, BorderHorizontal, BorderVertical, BorderLeft, BorderTop, BorderRight, BorderBottom, IsTabStop, VerticalContentAlignment, TabIndex, Padding, PaddingHorizontal, PaddingVertical, PaddingLeft, PaddingTop, PaddingRight, PaddingBottom, Template, FontWeight, BorderBrush, HorizontalContentAlignment, ContentTop, ContentCenterV, ContentCenterH, ContentCenter, ContentBotton, ContentStretchV, ContentStretchH, ContentStretch, ContentLeft, ContentRight;

3) ContentControl - ContentTemplate, Content, ContentStringFormat, ContentTemplateSelector;

4) ContextMenu - ApplyTo, MenuItem;

5) Grid - Rows, Cols.
