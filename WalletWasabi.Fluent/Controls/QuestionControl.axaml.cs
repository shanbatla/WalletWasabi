using System.Windows.Input;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace WalletWasabi.Fluent.Controls
{
	public enum HighlightedButton
	{
		None,
		YesButton,
		NoButton,
		Both
	}

	public class QuestionControl : ContentControl
	{
		public static readonly StyledProperty<ICommand> YesCommandProperty =
			AvaloniaProperty.Register<QuestionControl, ICommand>(nameof(YesCommand));

		public static readonly StyledProperty<ICommand> NoCommandProperty =
			AvaloniaProperty.Register<QuestionControl, ICommand>(nameof(NoCommand));

		public static readonly StyledProperty<IImage> IconProperty =
			AvaloniaProperty.Register<QuestionControl, IImage>(nameof(Icon));

		public static readonly StyledProperty<object?> QuestionContentProperty =
			AvaloniaProperty.Register<QuestionControl, object?>(nameof(QuestionContent));

		public static readonly StyledProperty<HighlightedButton> HighlightButtonProperty =
			AvaloniaProperty.Register<QuestionControl, HighlightedButton>(nameof(HighlightButton));

		public ICommand YesCommand
		{
			get => GetValue(YesCommandProperty);
			set => SetValue(YesCommandProperty, value);
		}

		public ICommand NoCommand
		{
			get => GetValue(NoCommandProperty);
			set => SetValue(NoCommandProperty, value);
		}

		public IImage Icon
		{
			get => GetValue(IconProperty);
			set => SetValue(IconProperty, value);
		}

		public object? QuestionContent
		{
			get => GetValue(QuestionContentProperty);
			set => SetValue(QuestionContentProperty, value);
		}

		public HighlightedButton HighlightButton
		{
			get => GetValue(HighlightButtonProperty);
			set => SetValue(HighlightButtonProperty, value);
		}
	}
}