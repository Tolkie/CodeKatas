namespace CountWords
{
    public class CountWords
    {
        public int Count(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            if (!s.Contains(' '))
            {
                return s.Split(",").Length;
            }
            
            return s.Split(" ").Length;
        }
    }
}
