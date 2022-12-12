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
    public class RulesViewModel : ViewModelBase
    {
        public ICommand NavigateGameCommand { get; }
        public ICommand NavigateRankingCommand { get; }
        public ICommand NavigateRewardsCommand { get; }
        public ICommand NavigatePerfilCommand { get; }

        public RulesViewModel(NavigationStore navigationStore)
        {
            NavigateGameCommand = new NavigateCommand<GameViewModel>(navigationStore, () => new GameViewModel(navigationStore));
            NavigateRankingCommand = new NavigateCommand<RankingViewModel>(navigationStore, () => new RankingViewModel(navigationStore));
            NavigateRewardsCommand = new NavigateCommand<RewardsViewModel>(navigationStore, () => new RewardsViewModel(navigationStore));
            NavigatePerfilCommand = new NavigateCommand<PerfilViewModel>(navigationStore, () => new PerfilViewModel(navigationStore));
        }
    }

}
