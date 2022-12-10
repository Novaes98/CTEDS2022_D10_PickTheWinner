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
    public class RegisterViewModel : ViewModelBase
    {
        public ICommand NavigateLoginCommand { get; }

        public RegisterViewModel(NavigationStore navigationStore) 
        {
            NavigateLoginCommand =  new NavigateCommand<LoginViewModel>(navigationStore, () => new LoginViewModel(navigationStore));
        }
    }
}
