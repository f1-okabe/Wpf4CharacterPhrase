﻿using System;
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
            Words.Add(new WordEntity() { Value = "異口同音" });
            Words.Add(new WordEntity() { Value = "一網打尽" });
            Words.Add(new WordEntity() { Value = "因果応報" });
            Words.Add(new WordEntity() { Value = "以心伝心" });
            Words.Add(new WordEntity() { Value = "意気消沈" });
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

        public void Click(CellEntity cell)
        {
            if (IsFourSelecting() == true && cell.Status != CellStatus.Selecting) return;

            cell.ChangeStatus();

            if (IsFourSelecting() == false) return;

            if (IsCorrectAnswer() == false) return;

            ChangeCellsStatusSelectingToCompleted();
        }

        public bool IsCompleted()
        {
            if (Cells.Where(m => m.Status != CellStatus.Completed).Count() == 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 四文字選択されている状態かチェックする
        /// </summary>
        /// <returns></returns>
        private bool IsFourSelecting()
        {
            if (Cells.Where(m => m.Status == CellStatus.Selecting).Count() == 4)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 洗濯されている文字が4字熟語になっているかチェックする
        /// </summary>
        /// <returns></returns>
        private bool IsCorrectAnswer()
        {
            var selectChars = new List<char>();
            selectChars = Cells.Where(m => m.Status == CellStatus.Selecting).Select(m => m.Value).ToList();
            selectChars.Sort();
            if (Words.Any(m => m.GetCharSortValue() == new String(selectChars.ToArray()))) return true;
            return false;
        }

        /// <summary>
        /// cellsのStatusでSelectingのものをCompletedにする
        /// </summary>
        private void ChangeCellsStatusSelectingToCompleted()
        {
            Cells.Where(m => m.Status == CellStatus.Selecting).ToList().ForEach(m => m.Status = CellStatus.Completed);
        }
    }
}
