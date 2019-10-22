using System;
using System.Collections.Generic;
using System.Text;

namespace _4CharacterPhrase
{
    public class Word
    {
        public string Value { get; set; }

        public List<Char> GetOneCharacter()
        {
            var returnValue = new List<char>();
            returnValue.AddRange(Value.ToCharArray());
            return returnValue;
        }
    }
}
