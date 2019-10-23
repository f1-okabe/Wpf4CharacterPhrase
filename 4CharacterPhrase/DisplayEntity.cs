using System;
using System.Collections.Generic;

namespace _4CharacterPhrase
{
    public class DisplayEntity
    {
        public List<CellEntity> Cells { get; set; } = new List<CellEntity>();
        public List<WordEntity> Words { get; set; } = new List<WordEntity>();
    }
}
