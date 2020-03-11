# LayoutExtensions

[![NuGet Stats](https://img.shields.io/nuget/v/LayoutExtensions.WPF.svg)](https://www.nuget.org/packages/LayoutExtensions.WPF/)

The library provides extension methods for assigning properties to FrameworkElements and Control in a fluent way. Using the library involves creating the UI in C#, not in XAML files. Currently there are only WPF extension methods.
Example:
```cs    
public class MainWindow() : Window
{
	private readonly Label _titleLabel;
	private readonly ItemsControl _itemsControl;
	private readonly Button _backButton;

	public MainWindow()
	{
		new Grid()
		    .Rows(CreateRowDefinitions)
		    .Cols(CreateColumnDefinitions)
		    .Assign(out var contentGrid);

		new Label()
		    .Col(0, 2)
		    .FontSize(25)
		    .AddToPanel(contentGrid)
		    .Assign(out _titleLabel);

		new ItemsControl()
		    .Row(1, 2)
		    .ItemTemplate(CreateItemTemplate())
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

	private static DataTemplate CreateItemTemplate() =>
		new DataTemplate()
		    .From(typeof(SomeExampleView))
		    .DataType(typeof(SomeExampleViewModel));
}
```

### Control extensions:
 - Border - BorderBrush, Border, BorderHorizontal, BorderVertical, BorderLeft, BorderTop, BorderRight, BorderBottom, CornerRadius;

 - ButtonBaseExtensions - Command, CommandParameter;

 - ComboBox - Editable;
 
 - ContentControl - ContentTemplate, Content, ContentStringFormat, ContentTemplateSelector;

 - ContextMenu - ApplyTo, MenuItem;
 
 - Control - FontStyle, FontStretch, FontSize, FontFamily, FontFamily, Background, Foreground, BorderControl, BorderHorizontal, BorderVertical, BorderLeft, BorderTop, BorderRight, BorderBottom, IsTabStop, TabIndex, Padding, PaddingHorizontal, PaddingVertical, PaddingLeft, PaddingTop, PaddingRight, PaddingBottom, Template, FontWeight, Bold, BorderBrush, ContentTop, ContentCenterV, ContentCenterH, ContentCenter, ContentBotton, ContentStretchV, ContentStretchH, ContentStretch, ContentLeft, ContentRight;

 - DataGrid - ColumnsCannotResize, ColumnsCanResize, RowsCannotResize, RowsCanResize, ColumnsNotAutoGenerated, ColumnsAutoGenerated, ColumnsCannotReorder, ColumnsCanReorder, ReadOnly, NotReadOnly, RowBackground;
  
 - Decorator - Child;

 - DependencyObject - Assign;

 - FrameworkElement - Width, MinWidth, MaxWidth, Height, MinHeight, MaxWidth, Tag, GetTag, Name, DataContext, GetDataContext, UseLayoutRounding, FlowDirection, Margin, MarginHorizontal, MarginVertical, MarginLeft, MarginTop, MarginRight, MarginBottom, Style, OverridesDefaultStyle, ContextMenu, ToolTip, ForceCursor, Cursor, FocusVisualStyle, Top, CenterV, CenterH, Center, Botton, StretchV, StretchH, Stretch, Left, Right, AddToPanel, Binding;

 - Grid - Rows, Cols;
 
 - Image - Source;

 - ItemsControl - GroupStyle, ItemsPanel, ItemTemplate, ItemContainerStyle;

 - Panel - Background;

 - ScrollBar - ScrollBarAuto, ScrollBarAutoH, ScrollBarAutoV, ScrollBarHidden, ScrollBarHiddenH, ScrollBarHiddenV, ScrollBarVisible, ScrollBarVisibleH, ScrollBarVisibleV, ScrollBarDisabled, ScrollBarDisabledH, ScrollBarDisabledV;
 
 - StackPanel - Horizontal, Vertical;

 - TextBlock - FontWeight, Bold, FontStyle, Italic, Oblique, FontFamily, Text, FontStretch, BaselineOffset, FontSize, TextWrapping, WrapWithOverflow, NoWrap, Wrap, Background, TextDecorations, TextEffects, LineHeight, LineStackingStrategy, Padding, PaddingHorizontal, PaddingVertical, PaddingLeft, PaddingTop, PaddingRight, PaddingBottom, TextAlignment, TextLeft, TextRight, TextCenter, TextJustify, TextTrimming, TextTrimmingNone, TextTrimmingCharacterEllipsis, TextTrimmingWordEllipsis, IsHyphenationEnabled, Foreground;
 
 - TextBoxBase - ReadOnly, BorderBrush, Border;

 - Window - WindowStyle, ResizeMode, Bounds;

 - UiElement - Row, Col, ColSpan, RowSpan, MouseBinding, Visible, Hidden, Collapsed, RenderTransform, RenderTransformOrigin, KeyBinding.
 
 ### Animation extensions
 - DoubleAnimation - ToValue;

 - TimelineExtensions - Duration, Forever, RepeatBehaviour, TargetProperty, AddToStoryboard.

### Miscellaneous extensions
 - CollectionViewSource - GroupDescription;
 
 - DataTemplate - From, DataType;
 
 - Style - Setter;

 - String - ToImageSource.
