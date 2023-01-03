
namespace HotReloadNotWorking.Pages;

public partial class ContentPageBase : ContentPage
{
    public static readonly BindableProperty MNavViewProperty = BindableProperty.Create(nameof(MNavView), typeof(View), typeof(ContentPageBase), defaultBindingMode: BindingMode.TwoWay);

    public View MNavView
    {
        get { return (View)GetValue(MNavViewProperty); }
        set { SetValue(MNavViewProperty, value); }
    }

    public static readonly BindableProperty MContentProperty = BindableProperty.Create(nameof(MContent), typeof(View), typeof(ContentPageBase), defaultBindingMode: BindingMode.TwoWay);

    public View MContent
    {
        get { return (View)GetValue(MContentProperty); }
        set { SetValue(MContentProperty, value); }
    }

    public ContentPageBase(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);
    }
}