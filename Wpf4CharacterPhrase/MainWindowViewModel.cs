using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
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
            Bord.Value.Click((CellEntity)entity);

            Bord.Value = Bord.Value.DeepCopy();

            if (Bord.Value.IsCompleted() == true)
            {
                MessageBox.Show("Completed");
            }
        }
    }
}
