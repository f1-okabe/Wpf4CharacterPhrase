using System;
using System.Collections.Generic;
using System.Text;
using _4CharacterPhrase;
using ExtensionsLibrary;
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

            if (Bord.Value.IsFourSelecting() == true && cell.Status !=  CellStatus.Selected) return;

            cell.ChangeStatus();
            Bord.Value = Bord.Value.DeepCopy();

            if (Bord.Value.IsFourSelecting() == false) return;

            if (Bord.Value.IsCorrectAnswer() == false) return;

            Bord.Value.ChangeCellsStatusSelectingToCompleted();
            Bord.Value = Bord.Value.DeepCopy();
        }
    }
}
