using Recipes.Client.Core.ViewModels;

namespace Recipes.Mobile;

public partial class RecipeDetailPage : ContentPage
{
    public RecipeDetailPage()
    {
        InitializeComponent();
        BindingContext = new RecipeDetailViewModel();
        
        // The binding can also be set in XAML, so this code is optional.
        // lblTitle.SetBinding(
        //     Label.TextProperty,
        //     nameof(RecipeDetailViewModel.Title),
        //     BindingMode.OneWay);
    }
}