using System;

namespace Open_Lab_03._08
{
    public class Checker
    {
        public bool IsPlural(string word)
        {
            return word.ToCharArray()[word.Length - 1] == 's';
        }
    }
}
