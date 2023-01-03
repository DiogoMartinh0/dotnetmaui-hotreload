namespace HotReloadNotWorking.Pages
{
    public class ContentPageTyped<T> : ContentPageBase
        where T : class
    {
        protected T ContextedViewModel => BindingContext as T ?? null;

        public ContentPageTyped(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            //BindingContext = serviceProvider.GetService<T>();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }

    public class ContentPageTyped : ContentPageBase
    {
        public ContentPageTyped(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}