using CTEDS2022_D10_PickTheWinner.Commands;
using CTEDS2022_D10_PickTheWinner.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CTEDS2022_D10_PickTheWinner.ViewModels
{
    public class MenuGamesViewModel : ViewModelBase
    {
        public ICommand NavigateRegisterCommand { get; }

        public MenuGamesViewModel(NavigationStore navigationStore)
        {
        }

    }
}
