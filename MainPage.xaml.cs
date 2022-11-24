namespace iOSCellReuseBug;

public partial class MainPage : ContentPage
{
	public List<CellViewModel> Cells { get; }

	public MainPage()
	{
        Cells = new List<CellViewModel>();
        for (int i = 0; i < 1000; i++)
            Cells.Add(new CellViewModel());
        InitializeComponent();
        list.BindingContext = this;
	}

}