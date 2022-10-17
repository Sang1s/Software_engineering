
using PSI.ViewModels;

namespace PSI.Views;

public partial class ReportView : ContentPage
{
    private string _report;
    public ReportView(ArticleViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    async void OnCancelButtonClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");



}