namespace BugWindowsFocus;

public partial class ModalPage : ContentPage
{
	public ModalPage()
	{
		InitializeComponent();
	}

    private void OnCloseModalClicked(object sender, EventArgs e)
    {
		this.Navigation.PopModalAsync();
    }
}