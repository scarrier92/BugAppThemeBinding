namespace Bug_AppThemeBinding;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

        ImageSource = "dotnet_bot.png";
        this.BindingContext = this;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{

        if (CounterBtn.Text.StartsWith("Hide"))
            CounterBtn.Text = $"Show First";
        else
            CounterBtn.Text = $"Hide First";

        img1.IsVisible = !img1.IsVisible;

    }

    public string LightImage { get; set; }
    public string DarkImage { get; set; }

    private string _imageSource;
    public string ImageSource
    {
        get { return _imageSource; }
        set
        {
            _imageSource = value;
            LightImage = _imageSource;
            DarkImage = _imageSource.Replace(".png", "_dark.png");
            OnPropertyChanged(nameof(LightImage));
            OnPropertyChanged(nameof(DarkImage));
        }
    }
}


