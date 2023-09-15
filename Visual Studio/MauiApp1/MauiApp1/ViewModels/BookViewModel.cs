namespace MauiApp1.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

/// <summary>
///     本
/// </summary>
class BookViewModel : ObservableObject
{
    // - その他

    /// <summary>
    ///     生成
    /// </summary>
    /// <param name="title">タイトル</param>
    internal BookViewModel(string title)
    {
        this.Title = title;
    }

    // - パブリック・プロパティ

    #region プロパティ（タイトル）
    /// <summary>
    ///     タイトル
    /// </summary>
    public string Title { get; set; } = string.Empty;
    #endregion
}
