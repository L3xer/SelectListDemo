using System.Diagnostics;
using System.Collections.Generic;
using MvvmHelpers;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;


namespace SelectListDemo.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigatingAware
    {
        public DelegateCommand ItemTappedCommand { get; set; }

        public ObservableRangeCollection<string> Items { get; } = new ObservableRangeCollection<string>();

        public MainPageViewModel()
        {
            ItemTappedCommand = new DelegateCommand(ItemTappedExecute);
        }

        private void ItemTappedExecute()
        {
            Debug.WriteLine("ItemTappedExecute");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Items.ReplaceRange(new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" });
        }
    }
}
