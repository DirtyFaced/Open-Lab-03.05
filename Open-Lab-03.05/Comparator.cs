using System;

namespace Open_Lab_03._05
{
    public class Comparator
    {
        public bool MatchCaseInsensitive(string str1, string str2)
        {
            string jedna = str1.ToLower();
            string dva = str2.ToLower();
            bool oog = false;
            if (jedna == dva)
            { oog = true; };
            return oog;

        }
    }
}
