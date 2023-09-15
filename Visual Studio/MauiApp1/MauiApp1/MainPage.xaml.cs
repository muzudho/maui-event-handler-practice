namespace MauiApp1;

using MauiApp1.ViewModels;
using System.Diagnostics;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        this.BindingContext = new MainPageViewModel();

		InitializeComponent();
	}

	/// <summary>
	///		テキスト変更時
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        Trace.WriteLine("テキスト変更時");
    }

    /// <summary>
    ///		<pre>
    ///			セットボタン　クリック時
	///			
	///			イベントハンドラをセットします
    ///		</pre>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void SetsButton_Clicked(object sender, EventArgs e)
    {
        Trace.WriteLine("セット・ボタン・クリック時");
    }

    /// <summary>
    ///		<pre>
    ///			削除ボタン　クリック時
	///			
	///			イベントハンドラをセットします
    ///		</pre>
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DeletesButton_Clicked(object sender, EventArgs e)
    {
        Trace.WriteLine("削除ボタン・クリック時");
    }

    private void N0SelectButton_Clicked(object sender, EventArgs e)
    {
        Trace.WriteLine("０冊目の本を選択ボタン・クリック時");

        var context = this.BindingContext as MainPageViewModel;
        context.SelectedIndex = 0;
    }

    private void N1SelectButton_Clicked(object sender, EventArgs e)
    {
        Trace.WriteLine("１冊目の本を選択ボタン・クリック時");

        var context = this.BindingContext as MainPageViewModel;
        context.SelectedIndex = 1;
    }

    private void N2SelectButton_Clicked(object sender, EventArgs e)
    {
        Trace.WriteLine("２冊目の本を選択ボタン・クリック時");

        var context = this.BindingContext as MainPageViewModel;
        context.SelectedIndex = 2;
    }
}

