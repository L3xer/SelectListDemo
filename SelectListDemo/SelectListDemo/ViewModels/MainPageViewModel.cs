using System.Collections.Generic;
using MvvmHelpers;
using Prism.Mvvm;
using Prism.Navigation;


namespace SelectListDemo.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigatingAware
    {
        public ObservableRangeCollection<string> Items { get; } = new ObservableRangeCollection<string>();

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Items.ReplaceRange(new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" });
        }
    }
}
