using System;
using System.Collections.Generic;
using System.Linq;

namespace _4CharacterPhrase
{
    public class BordEntity
    {
        public List<CellEntity> Cells { get; set; } = new List<CellEntity>();
        public List<WordEntity> Words { get; set; } = new List<WordEntity>();

        public void SetData()
        {
            SetWords();
            SetCells();
        }

        private void SetWords()
        {
            Words.Add(new WordEntity() { Value = "悪戦苦闘" });
            Words.Add(new WordEntity() { Value = "安楽浄土" });
            Words.Add(new WordEntity() { Value = "暗中模索" });
            Words.Add(new WordEntity() { Value = "阿鼻叫喚" });
            Words.Add(new WordEntity() { Value = "悪逆無道" });
            Words.Add(new WordEntity() { Value = "悪口雑言" });
            Words.Add(new WordEntity() { Value = "唯唯諾諾" });
            Words.Add(new WordEntity() { Value = "一日千秋" });
            Words.Add(new WordEntity() { Value = "一罰百戒" });
        }

        private void SetCells()
        {
            var list = new List<char>();
            foreach(var item in Words)
            {
                list.AddRange(item.GetOneCharacter());
            }

            while (list.Count > 0)
            {
                var randomNumber = RandomNumber(list.Count);
                Cells.Add(new CellEntity() { Value = list[randomNumber] });
                list.Remove(list[randomNumber]);
            }
        }

        private int RandomNumber(int maxNumber)
        {
            System.Random r = new System.Random();
            return r.Next(maxNumber);
        }

        public bool IsFourSelecting()
        {
            if (Cells.Where(m => m.Status == CellStatus.Selected).Count() == 4)
            {
                return true;
            }
            return false;
        }
        public bool IsCorrectAnswer()
        {
            var selectChars = new List<char>();
            selectChars = Cells.Where(m => m.Status == CellStatus.Selected).Select(m => m.Value).ToList();
            selectChars.Sort();
            if (Words.Any(m => m.GetCharSortValue() == new String(selectChars.ToArray()))) return true;
            return false;
        }
        public void ChangeCellsStatusSelectingToCompleted()
        {
            Cells.Where(m => m.Status == CellStatus.Selected).ToList().ForEach(m => m.Status = CellStatus.Completed);
        }
        public void ChangeCellsStatusSelectingToNone()
        {
            Cells.Where(m => m.Status == CellStatus.Selected).ToList().ForEach(m => m.Status = CellStatus.None);
        }
    }
}
