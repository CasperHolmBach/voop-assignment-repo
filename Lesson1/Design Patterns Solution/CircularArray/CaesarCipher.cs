namespace CircularArray;

public class CaesarCipher
{
    private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    public string Encode(string text, int shift)
    {
        string encodedText = "";
        text = text.ToUpper();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                int originalIndex = Array.IndexOf(_alphabet, c);
                int newIndex = (originalIndex + shift) % _alphabet.Length;
                encodedText += _alphabet[newIndex];
            }
            else
            {
                encodedText += c;
            }
        }

        return encodedText;
    }

    public string Decode(string text, int shift)
    {
        return Encode(text, _alphabet.Length - shift);
    }
}