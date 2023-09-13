namespace MauiApp1;

using MauiApp1.ViewModels;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
        this.BindingContext = new NovelViewModel(
            text: "てすとーお");

		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	/// <summary>
	///		テキスト変更時
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {

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

    }
}

