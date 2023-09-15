namespace MauiApp1.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
///     ビューモデル
/// </summary>
internal class MainPageViewModel : ObservableObject
{
    // - その他

    public MainPageViewModel()
    {
    }

    // - パブリック変更通知プロパティ

    /// <summary>
    ///     テキスト
    /// </summary>
    public string Text
    {
        get => this.BookList[this.SelectedIndex].Title;
        set
        {
            if (this.BookList[this.SelectedIndex].Title == value)
                return;

            this.BookList[this.SelectedIndex].Title = value;
            OnPropertyChanged(nameof(Text));
        }
    }

    // - インターナル・プロパティ

    /// <summary>
    ///     何冊目の本か
    /// </summary>
    internal int SelectedIndex
    {
        get => selectedIndex;
        set
        {
            if(this.selectedIndex == value) return;
            this.selectedIndex = value;

            // テキストを変更通知
            OnPropertyChanged(nameof(Text));
        }
    }

    // - プライベート・プロパティ

    /// <summary>
    ///     本のリスト
    /// </summary>
    List<BookViewModel> BookList { get; set; } = new List<BookViewModel>()
    {
        new BookViewModel("ぜろ"),
        new BookViewModel("いち"),
        new BookViewModel("に"),
    };

    // - プライベート・フィールド

    int selectedIndex;
}
