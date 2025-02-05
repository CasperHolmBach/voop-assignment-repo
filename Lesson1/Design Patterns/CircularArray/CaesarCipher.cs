namespace CircularArray;

public class CaesarCipher
{
    private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    public string Encode(string text, int shift)
    {
        string encodedText = string.Empty;
        text = text.ToUpper();
        for (int i = 0; i < text.Length; i++)
        {
            char letter = text[i];
            int pos = Array.IndexOf(_alphabet, letter);
            int newPos = (pos + shift) % _alphabet.Length;
            char newLetter = _alphabet[newPos];
            encodedText += newLetter;
        }

        return encodedText;
    }

    public string Decode(string text, int shift)
    {
        return Encode(text, _alphabet.Length - shift);
    }
}