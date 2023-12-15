using AppShoppingCenter.Views.Stores;

namespace AppShoppingCenter
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("Store/detail", typeof(Views.Stores.DetailPage));

        }
    }
}
