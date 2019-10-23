using System;
using System.Collections.Generic;
using System.Text;
using _4CharacterPhrase;
using Reactive.Bindings;

namespace Wpf4CharacterPhrase
{
    public class MainWindowViewModel: ViewModelBase
    {
        public ReactiveProperty<DisplayEntity> Display { get; set; } = new ReactiveProperty<DisplayEntity>(new DisplayEntity());

        public MainWindowViewModel()
        {
            Display.Value.Cells.Add(new CellEntity() { Value = '１' });
            Display.Value.Cells.Add(new CellEntity() { Value = '２' });
            Display.Value.Cells.Add(new CellEntity() { Value = '３' });
            Display.Value.Cells.Add(new CellEntity() { Value = '４' });
            Display.Value.Cells.Add(new CellEntity() { Value = '５' });
            Display.Value.Cells.Add(new CellEntity() { Value = '６' });
            Display.Value.Cells.Add(new CellEntity() { Value = '７' });
            Display.Value.Cells.Add(new CellEntity() { Value = '８' });
            Display.Value.Cells.Add(new CellEntity() { Value = '９' });
            Display.Value.Cells.Add(new CellEntity() { Value = '０' });
            Display.Value.Cells.Add(new CellEntity() { Value = '１' });
            Display.Value.Cells.Add(new CellEntity() { Value = '２' });
            Display.Value.Cells.Add(new CellEntity() { Value = '３' });
            Display.Value.Cells.Add(new CellEntity() { Value = '４' });
            Display.Value.Cells.Add(new CellEntity() { Value = '５' });
            Display.Value.Cells.Add(new CellEntity() { Value = '６' });
            Display.Value.Cells.Add(new CellEntity() { Value = '７' });
            Display.Value.Cells.Add(new CellEntity() { Value = '８' });
            Display.Value.Cells.Add(new CellEntity() { Value = '９' });
            Display.Value.Cells.Add(new CellEntity() { Value = '０' });
            Display.Value.Cells.Add(new CellEntity() { Value = '１' });
            Display.Value.Cells.Add(new CellEntity() { Value = '２' });
            Display.Value.Cells.Add(new CellEntity() { Value = '３' });
            Display.Value.Cells.Add(new CellEntity() { Value = '４' });
            Display.Value.Cells.Add(new CellEntity() { Value = '５' });
            Display.Value.Cells.Add(new CellEntity() { Value = '６' });
            Display.Value.Cells.Add(new CellEntity() { Value = '７' });
            Display.Value.Cells.Add(new CellEntity() { Value = '８' });
            Display.Value.Cells.Add(new CellEntity() { Value = '９' });
            Display.Value.Cells.Add(new CellEntity() { Value = '０' });
            Display.Value.Cells.Add(new CellEntity() { Value = '１' });
            Display.Value.Cells.Add(new CellEntity() { Value = '２' });
            Display.Value.Cells.Add(new CellEntity() { Value = '３' });
            Display.Value.Cells.Add(new CellEntity() { Value = '４' });
            Display.Value.Cells.Add(new CellEntity() { Value = '５' });
            Display.Value.Cells.Add(new CellEntity() { Value = '６' });
        }
    }
}
