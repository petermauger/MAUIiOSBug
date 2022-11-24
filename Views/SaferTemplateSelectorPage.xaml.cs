namespace iOSCellReuseBug.Views;

public partial class SaferTemplateSelectorPage : ContentPage
{
	public List<CellViewModel> Cells { get; }

	public SaferTemplateSelectorPage()
	{
        Cells = new List<CellViewModel>();
        for (int i = 0; i < 1000; i++)
        {
            if(Random.Shared.NextDouble() >= 0.5)
                Cells.Add(new CellViewModel());
            else
                Cells.Add(new ScrollableCellViewModel());
        }
        InitializeComponent();
        list.BindingContext = this;
	}

}