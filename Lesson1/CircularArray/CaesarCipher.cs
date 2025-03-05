namespace CircularArray;

public class CaesarCipher
{
    private char[] _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    public string Encode(string text, int shift)
    {
		string input = text.ToUpper();
		input.ToCharArray();
		
		string result = "";

		for (int i = 0; i < input.Length; i++)
		{
			int indexInAlphabet = Array.IndexOf(_alphabet, input[i]);
			result += _alphabet[(indexInAlphabet + shift) % _alphabet.Length];
		}

		return result;
    }

    public string Decode(string text, int shift)
    {
	    return Encode(text, -shift);
    }
}