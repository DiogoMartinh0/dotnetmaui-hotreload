using HotReloadNotWorking.Pages;

namespace HotReloadNotWorking;

public partial class MainPage : ContentPageTyped<DummyVM>
{
    public MainPage(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        InitializeComponent();
        MNavView.Parent = this;
        MContent.Parent = this;

    }
}

