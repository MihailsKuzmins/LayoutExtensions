# LayoutExtensions

[![NuGet Stats](https://img.shields.io/nuget/v/LayoutExtensions.WPF.svg)](https://www.nuget.org/packages/LayoutExtensions.WPF/)

The library provides extension methods for assigning properties to FrameworkElements and Control in a fluent way. Using the library involves creating the UI in C#, not in XAML files. Currently there are only WPF extension methods.
Example:
```cs    
public class MainWindow : Window
{
	private readonly Label _titleLabel;
	private readonly ItemsControl _itemsControl;
	private readonly Button _backButton;

	public MainWindow()
	{
		Content = new Grid
		{
			RowDefinitions =
			{
				new RowDefinition(),
				new RowDefinition().Auto(),
				new RowDefinition().Star(2d)
			},
			ColumnDefinitions =
			{
				new ColumnDefinition().Pixel(200d),
				new ColumnDefinition()
			},
			Children =
			{
				new TextBlock()
					.Col(0, 2)
					.FontSize(25d)
					.Binding(TextBlock.TextProperty, nameof(MainViewModel.SomeText))
					.Assign(out _titleLabel),

				new ItemsControl()
					.Row(1, 2)
					.ItemTemplate(CreateItemTemplate)
					.Assign(out _itemsControl),

				new TextBox()
					.Row(1)
					.Col(1)
					.FontSize(20d)
					.MarginBottom(10d)
					.Binding(TextBox.TextProperty, nameof(MainViewModel.SomeInput), x =>
						x.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged),

				new Button()
					.Row(2)
					.Col(1)
					.Content("Navigate back")
					.CommandParameter(int.MaxValue)
					.Binding(ButtonBase.CommandProperty, nameof(MainViewModel.SomeAction))
					.AddToPanel(contentGrid)
					.Assign(out _backButton)
			}
		};
	
		static DataTemplate CreateItemTemplate() =>
			new DataTemplate(typeof(SomeExampleViewModel))
				.From(typeof(SomeExampleView));
	}
	
	public MainViewModel ViewModel
	{
		get => (MainViewModel) DataContext;
		set => DataContext = value;
	}
}
```

### Animations extensions:
 - **DoubleAnimation** - ToValue;
 - **Timeline** - AddToStoryboard, Duration, Forever, RepeatBehaviour, TargetProperty.

### Controls extensions:
 - **Border** - BackgroundBorder, Border, BorderBottom, BorderBrush, BorderHorizontal, BorderLeft, BorderPadding, BorderPaddingBottom, BorderPaddingHorizontal, BorderPaddingLeft, BorderPaddingRight, BorderPaddingTop, BorderPaddingVertical, BorderRight, BorderTop, BorderVertical, CornerRadius;
 - **ButtonBase** - Command, CommandParameter;
 - **ColumnDefinition** - Auto, Pixel, Star;
 - **ComboBox** - Editable;
 - **ContentControl** - Content, ContentStringFormat, ContentTemplate, ContentTemplateSelector;
 - **ContextMenu** - ApplyTo, MenuItem;
 - **Control** - Background, Bold, BorderBottomControl, BorderBrushControl, BorderControl, BorderHorizontalControl, BorderLeftControl, BorderRightControl, BorderTopControl, BorderVerticalControl, ContentBotton, ContentCenter, ContentCenterH, ContentCenterV, ContentLeft, ContentRight, ContentStretch, ContentStretchH, ContentStretchV, ContentTop, FontFamily, FontSize, FontStyle, FontStretch, FontWeight, Foreground, IsTabStop, Padding, PaddingBottom, PaddingHorizontal, PaddingLeft, PaddingRight, PaddingTop, PaddingVertical, TabIndex, Template;
 - **DataGridColumn** - Binding, CellTemplate, ElementStyle, Header, MinWidth, Star;
 - **DataGrid** - Cols, ColumnsAutoGenerated, ColumnsCannotReorder, ColumnsCannotResize, ColumnsCanReorder, ColumnsCanResize, ColumnsNotAutoGenerated, ExpandLastCol, NotReadOnlyDataGrid, ReadOnlyDataGrid, RowBackground, RowsCannotResize, RowsCanResize, SelectionUnit;
 - **Decorator** - Child;
 - **DependencyObject** - Assign;
 - **FrameworkElement** - AddToPanel, Binding, Bottom, Center, CenterH, CenterV, ContextMenu, Cursor, DataContext, FlowDirection, FocusVisualStyle, ForceCursor, GetDataContext, GetTag, Height, Left, Margin, MarginBottom, MarginHorizontal, MarginLeft, MarginRight, MarginTop, MarginVertical, MaxHeight, MaxWidth, MinHeight, MinWidth, MultiBinding, Name, OverridesDefaultStyle, Right, Size, Style, Stretch, StretchH, StretchV, Tag, ToolTip, Top, UseLayoutRounding, Width;
 - **Grid** - Cols, Rows;
 - **Image** - Source;
 - **ItemsControl** - DisplayMemberPath, GroupStyle, ItemContainerStyle, ItemsPanel, ItemTemplate;
 - **Panel** - BackgroundPanel, Children;
 - **RowDefinition** - Auto, Pixel, Star;
 - **ScrollViewer** - ScrollBarAuto, ScrollBarAutoH, ScrollBarAutoV, ScrollBarDisabled, ScrollBarDisabledH, ScrollBarDisabledV, ScrollBarHidden, ScrollBarHiddenH, ScrollBarHiddenV, ScrollBarVisible, ScrollBarVisibleH, ScrollBarVisibleV;
 - **StackPanel** - Horizontal, Vertical;
 - **TextBlock** - BackgroundTextBlock, BaselineOffset, Bold, FontFamily, FontSize, FontStyle, FontStretch, FontWeight, ForegroundTextBlock, IsHyphenationEnabled, Italic, LineHeight, LineStackingStrategy, NoWrap, Oblique, PaddingBottomTextBlock, PaddingHorizontalTextBlock, PaddingLeftTextBlock, PaddingRightTextBlock, PaddingTextBlock, PaddingTopTextBlock, PaddingVerticalTextBlock, Text, TextAlignment, TextCenter, TextDecorations, TextEffects, TextJustify, TextLeft, TextRight, TextTrimming, TextTrimmingCharacterEllipsis, TextTrimmingNone, TextTrimmingWordEllipsis, TextWrapping, Wrap, WrapWithOverflow;
 - **TextBoxBase** - ReadOnlyTextBox;
 - **UiElement** - Col, Collapsed, ColSpan, Focusable, Hidden, IsEnabled, KeyBinding, MouseBinding, NotFocusable, Opacity, RenderTransform, RenderTransformOrigin, Row, RowSpan, SetIsVisible, ToViewBox, Visible;
 - **Window** - Bounds, ResizeMode, WindowStyle.

### Miscellaneous extensions:
 - **CollectionViewSource** - GroupDescription;
 - **DataTemplate** - DataType, From;
 - **ResourceDictionary** - Get, Source;
 - **String** - ToImageSource;
 - **Style** - Setter.
