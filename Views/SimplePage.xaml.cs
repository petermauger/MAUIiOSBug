namespace iOSCellReuseBug.Views;

public partial class SimplePage : ContentPage
{
	public List<CellViewModel> Cells { get; }

	public SimplePage()
	{
        Cells = new List<CellViewModel>();
        for (int i = 0; i < 1000; i++)
            Cells.Add(new CellViewModel());
        InitializeComponent();
        list.BindingContext = this;
	}

}