using System;
using System.Collections.Generic;
using System.Text;

namespace _4CharacterPhrase
{
    public class CellEntity
    {
        public char Value { get; set; }

        public int X { get; set; }

        public int Y { get; set; }

        public CellStatus Status { get; set; } = CellStatus.None;

        public int Color { get; set; }
    }
}
