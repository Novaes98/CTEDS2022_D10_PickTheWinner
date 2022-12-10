using CTEDS2022_D10_PickTheWinner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTEDS2022_D10_PickTheWinner.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged;

        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel 
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentModelChanged();
            }
        }

        private void OnCurrentModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
