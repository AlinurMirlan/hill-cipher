using MathNet.Numerics.LinearAlgebra;
using System.Text;

namespace HillCipher.Library;

public class HillCipher : ICipher<int[,]>
{
    private int _blockLength;
    private char[] _alphabet;
    private readonly MatrixBuilder<int> _matrixBuilder;
    private Dictionary<char, int> _letterIndexLookup;
    private Matrix<int> _key;
    

    public HillCipher(char[] alphabet, int[,] keyValues)
    {
        if (alphabet.Length <= 0)
            throw new ArgumentException($"{nameof(Alphabet)} must not be empty.");
        if (keyValues.GetLength(0) != keyValues.GetLength(1))
            throw new ArgumentException($"{nameof(Key)} dimensions must match.");

        _alphabet = alphabet;
        _matrixBuilder = Matrix<int>.Build;
        int index = 0;
        _letterIndexLookup = alphabet.ToDictionary(letter => letter, _ => index++);
        Matrix<int> key = _matrixBuilder.DenseOfArray(keyValues) % _alphabet.Length;
        if (key.Determinant() == 0)
            throw new ArgumentException("{nameof(Key)} dimensions must be invertibe.");

        _key = key;
        _blockLength = keyValues.GetLength(0);
    }

    public char[] Alphabet
    {
        get => _alphabet;
        set
        {
            if (value.Length <= 0)
                throw new ArgumentException($"{nameof(Alphabet)} must not be empty.");
            int index = 0;
            _letterIndexLookup = value.ToDictionary(letter => letter, _ => index++);
            _alphabet = value;
        }
    }

    public int[,] Key
    {
        get => _key.AsArray();
        set
        {
            if (value.GetLength(0) != value.GetLength(1))
                throw new ArgumentException($"{nameof(Key)} dimensions must match.");

            Matrix<int> key = _matrixBuilder.DenseOfArray(value) % _alphabet.Length;
            if (key.Determinant() == 0)
                throw new ArgumentException("{nameof(Key)} dimensions must be invertibe.");

            _key = key;
            _blockLength = value.GetLength(0);
        }
    }

    public string Encrypt(string message) => Cipher(message, _key);

    public string Decrypt(string message)
    {
        Matrix<int> keyInverse = _key.Inverse() % _alphabet.Length;
        return Cipher(message, keyInverse);
    }

    private string Cipher(string message, Matrix<int> key)
    {
        int i;
        StringBuilder encryptedMessageBuilder = new();
        for (i = _blockLength; i < message.Length; i += _blockLength)
        {
            CipherSpan(message, i - _blockLength, i, key, encryptedMessageBuilder);
        }

        if (i > message.Length)
        {
            int leftoutIndicesCount = message.Length - i;
            Matrix<int> subKey = key.SubMatrix(0, leftoutIndicesCount, 0, leftoutIndicesCount);
            CipherSpan(message, message.Length, i, subKey, encryptedMessageBuilder);
        }

        return encryptedMessageBuilder.ToString();
    }

    private void CipherSpan(string message, int left, int right, Matrix<int> key, StringBuilder messageBuilder)
    {
        int[] letterIndices = GetLetterIndices(message, left, right);
        int letterSpan = right - left;
        Matrix<int> originalLetterIndices = _matrixBuilder.Dense(letterSpan, 1, letterIndices);
        Matrix<int> encryptedLetterIndices = (key * originalLetterIndices) % _alphabet.Length;
        foreach (int letterIndex in encryptedLetterIndices.AsColumnMajorArray())
            messageBuilder.Append(_alphabet[letterIndex]);
    }

    private int[] GetLetterIndices(string message, int left, int right)
    {
        int[] letterIndices = new int[right - left];
        for (int i = left, k = 0; i < right; i++, k++)
        {
            char characer = message[i];
            if (_letterIndexLookup.TryGetValue(characer, out int index))
                letterIndices[k] = index;
            else
                throw new InvalidOperationException("Message contains unknown, the ones not included in the alphabet, characters.");
        }

        return letterIndices;
    }
}