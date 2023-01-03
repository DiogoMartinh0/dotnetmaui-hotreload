
namespace HotReloadNotWorking.Pages;

public partial class ContentPageBase : ContentPage, IVisualTreeElement
{
    public static readonly BindableProperty MNavViewProperty = BindableProperty.Create(nameof(MNavView), typeof(View), typeof(ContentPageBase), defaultBindingMode: BindingMode.TwoWay, propertyChanged: NavViewChanged);

    private static void NavViewChanged(BindableObject bindable, object oldValue, object newValue)
    {
        
    }

    public View MNavView
    {
        get { return (View)GetValue(MNavViewProperty); }
        set { SetValue(MNavViewProperty, value); }
    }

    public static readonly BindableProperty MContentProperty = BindableProperty.Create(nameof(MContent), typeof(View), typeof(ContentPageBase), defaultBindingMode: BindingMode.TwoWay, propertyChanged: ContentChanged);

    private static void ContentChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is ContentPageBase page)
        {
            //if (newValue is View view)
            //{
            //    page.ContentGrid.Content = view;
            //}

            //if (newValue is IVisualTreeElement vtElement)
            //{
            //    VisualDiagnostics.OnChildAdded(page.ContentGrid, vtElement);
            //}

            //page.ContentGrid.Parent = page;
            //page.MContent.Parent = page;
        }
    }

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

    IReadOnlyList<IVisualTreeElement> IVisualTreeElement.GetVisualChildren()
    {
        var elements = new List<IVisualTreeElement>
        {
            //this.Content
            ContentPageBaseContentGrid,
            MNavView,
            MContent
        };



        //elements.AddRange(ContentPageBaseContentGrid.Children.Cast<IVisualTreeElement>());
        //elements.AddRange(ContentPageBaseContentGrid.Children.Select(c => (c as ContentView).Content).Cast<IVisualTreeElement>());

        return elements.ToList().AsReadOnly();
    }
}