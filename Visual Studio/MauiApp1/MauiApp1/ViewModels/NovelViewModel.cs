namespace MauiApp1.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
///     小説ビューモデルという名前だが、単に文字列を持っているモデル
/// </summary>
internal class NovelViewModel : ObservableObject
{
    // - その他

    public NovelViewModel(string text)
    {
        this.Text = text;
    }

    // - パブリック変更通知プロパティ

    /// <summary>
    ///     テキスト
    /// </summary>
    public string Text
    {
        get => this.text;
        set
        {
            if (this.text == value)
                return;

            this.text = value;
            OnPropertyChanged(nameof(Text));
        }
    }

    // - プライベート・フィールド

    string text;
}
