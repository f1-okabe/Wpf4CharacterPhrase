using System;
using System.Collections.Generic;
using System.Text;
using _4CharacterPhrase;
using Reactive.Bindings;

namespace Wpf4CharacterPhrase
{
    public class MainWindowViewModel: ViewModelBase
    {
        public ReactiveProperty<BordEntity> Bord { get; set; } = new ReactiveProperty<BordEntity>(new BordEntity());

        public ReactiveCommand BordClickCommand { get; } = new ReactiveCommand();

        public MainWindowViewModel()
        {
            BordClickCommand.Subscribe(x => BordClick(x));

            Bord.Value.SetData();
        }

        private void BordClick(object entity)
        {
            var cell = (CellEntity)entity;
            if (cell.Status == CellStatus.Completed)
            {
                return;
            }

            if (cell.Status == CellStatus.Selected)
            {
                cell.Status = CellStatus.None;
                return;
            }

            if (cell.Status == CellStatus.None)
            {
                cell.Status = CellStatus.Selected;
                return;
            }
        }
    }
}
