using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private int _count = 0;

        [ObservableProperty]
        private string _buttonText = "Click me, pls";

        [RelayCommand]
        private void IncrementCounter()
        {
            Count++;

            if (Count == 1)
                ButtonText = $"Clicked {Count} time";
            else
                ButtonText = $"Clicked {Count} times";

            SemanticScreenReader.Announce(ButtonText);
        }
    }
}
