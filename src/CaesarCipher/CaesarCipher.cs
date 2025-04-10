namespace CaesarCipher
{
    public class CaesarCipher
    {
        public string Encode(string s, int shift)
        {
            var result = string.Empty;

            foreach (var c in s)
            {
                if (char.IsLetter(c))
                {
                    var baseChar = char.IsUpper(c) ? 'A' : 'a';
                    var shiftedChar = (char)((c - baseChar + shift + 26) % 26 + baseChar);
                    result += shiftedChar;
                }
                else
                {
                    result += c;
                }
            }
            
            return result;
        }

        public string Decode(string s, int shift)
        {
            return Encode(s, shift * -1);
        }
    }
}
