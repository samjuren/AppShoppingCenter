using AppShoppingCenter.Models;
using AppShoppingCenter.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Linq;

namespace AppShoppingCenter.ViewModels.Stores
{
    public partial class ListPageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string textSearch;

        private List<Establishment> establishmentsFull;

        [ObservableProperty]
        private List<Establishment> establishmentsFiltered;

        public ListPageViewModel()
        {
            var service = App.Current?.Handler.MauiContext?.Services.GetService<StoresService>();
            establishmentsFull = service.GetStore();
            establishmentsFiltered = service.GetStore().ToList();
        }

        [RelayCommand]
        private void OnTextSearchFilteredList()
        {
            EstablishmentsFiltered = establishmentsFull.Where(x => x.Name.ToLower().Contains(textSearch.ToLower())).ToList();
        }
    }
}
