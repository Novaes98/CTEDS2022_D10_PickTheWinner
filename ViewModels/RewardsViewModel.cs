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
    public class RewardsViewModel : ViewModelBase
    {
        public ICommand NavigateGameCommand { get; }
        public ICommand NavigateRankingCommand { get; }
        public ICommand NavigateRulesCommand { get; }
        public ICommand NavigatePerfilCommand { get; }

        public RewardsViewModel(NavigationStore navigationStore)
        {
            NavigateGameCommand = new NavigateCommand<GameViewModel>(navigationStore, () => new GameViewModel(navigationStore));
            NavigateRankingCommand  = new NavigateCommand<RankingViewModel>(navigationStore, () => new RankingViewModel(navigationStore));
            NavigateRulesCommand = new NavigateCommand<RulesViewModel>(navigationStore, () => new RulesViewModel(navigationStore));
            NavigatePerfilCommand = new NavigateCommand<PerfilViewModel>(navigationStore, () => new PerfilViewModel(navigationStore));
        }
    }

}
