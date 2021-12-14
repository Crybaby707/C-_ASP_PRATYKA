namespace TVShows.Domain.Extensions
{
    public static class StringExtensions
    {
        public static bool HasLetters(this string word)
        {
            for (var i = 0; i < word.Length; i++)
            {
                if (Char.IsLetter(word[i]))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
