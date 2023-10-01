using MathNet.Numerics.LinearAlgebra;
using System.Text;

namespace HillCipher.Library;

public class HillCipher : ICipher<double[,]>
{
    private const char whiteSpace = ' ';
    private int _blockLength;
    private char[] _alphabet;
    private readonly MatrixBuilder<double> _matrixBuilder = Matrix<double>.Build;
    private Dictionary<char, int> _letterIndexLookup;
    private Matrix<double> _key;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public HillCipher(char[] alphabet, double[,] keyValues)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        Alphabet = alphabet;
        Key = keyValues;
    }

    public char[] Alphabet
    {
        get => _alphabet;
        set
        {
            if (value.Length <= 0)
                throw new ArgumentException($"{nameof(Alphabet)} must not be empty.");

            if (!value.Contains(whiteSpace))
                throw new ArgumentException($"{nameof(Alphabet)} must contain a white space ' '.");

            int index = 0;
            _letterIndexLookup = value.ToDictionary(letter => letter, _ => index++);
            _alphabet = value;
        }
    }

    public double[,] Key
    {
        get => _key.AsArray();
        set
        {
            if (value.GetLength(0) != value.GetLength(1))
                throw new ArgumentException($"{nameof(Key)} dimensions must match.");

            int alphabetLength = _alphabet.Length;
            Matrix<double> key = _matrixBuilder.DenseOfArray(value) % alphabetLength;
            int determinant = (int)Math.Round(key.Determinant()) % alphabetLength;
            if (determinant == 0)
                throw new ArgumentException($"{nameof(Key)} dimensions must be invertibe.");

            if (determinant < 0)
                determinant += alphabetLength;
            if (Gcd.CommonDivisor(determinant, _alphabet.Length) != 1)
                throw new ArgumentException($"Determinant of the {nameof(Key)} must be coprime to the alphabet length.");

            _key = key;
            _blockLength = value.GetLength(0);
        }
    }

    public string Encrypt(string message) => Cipher(message, _key);

    public string Decrypt(string message)
    {
        Matrix<double> keyInverse = InverseKey(_key);
        return Cipher(message, keyInverse);
    }

    private string Cipher(string message, Matrix<double> key)
    {
        int i;
        StringBuilder encryptedMessageBuilder = new();
        for (i = _blockLength; i <= message.Length; i += _blockLength)
        {
            CipherSpan(message, i - _blockLength, i, key, encryptedMessageBuilder);
        }

        int lastIndex = i - _blockLength;
        if (lastIndex != message.Length)
        {
            message = message.PadRight(lastIndex + _blockLength, whiteSpace);
            CipherSpan(message, lastIndex, lastIndex + _blockLength, key, encryptedMessageBuilder);
        }

        return encryptedMessageBuilder.ToString();
    }

    private void CipherSpan(string message, int left, int right, Matrix<double> key, StringBuilder messageBuilder)
    {
        double[] letterIndices = GetLetterIndices(message, left, right);
        int letterSpan = right - left;
        Matrix<double> originalLetterIndices = _matrixBuilder.Dense(letterSpan, 1, letterIndices);
        Matrix<double> encryptedLetterIndices = key * originalLetterIndices % _alphabet.Length;
        foreach (double realLetterIndex in encryptedLetterIndices.AsColumnMajorArray())
        {
            int letterIndex = realLetterIndex < 0 
                ? (int)Math.Floor(realLetterIndex) + _alphabet.Length 
                : (int)realLetterIndex;
            messageBuilder.Append(_alphabet[letterIndex]);
        }
    }

    private double[] GetLetterIndices(string message, int left, int right)
    {
        double[] letterIndices = new double[right - left];
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

    private Matrix<double> InverseKey(Matrix<double> key)
    {
        int alphabetLength = _alphabet.Length;
        Matrix<double> adjugateKey = key.Adjugate() % alphabetLength;
        NormalizeMatrix(adjugateKey);

        double keyDeterminant = Math.Round(key.Determinant()) % alphabetLength;
        if (keyDeterminant < 0)
            keyDeterminant += alphabetLength;

        int inverseDeterminant = 0;
        int inverseAlphabet = 0;
        Gcd.CommonDivisorExtended((int)keyDeterminant, alphabetLength, ref inverseDeterminant, ref inverseAlphabet);
        if (inverseDeterminant < 0)
            inverseDeterminant += alphabetLength;

        return inverseDeterminant * adjugateKey % alphabetLength;
    }

    private void NormalizeMatrix(Matrix<double> matrix)
    {
        for (int i = 0; i < matrix.RowCount; i++)
        {
            for (int j = 0; j < matrix.ColumnCount; j++)
            {
                matrix[i, j] = Math.Round(matrix[i, j]);
                if (matrix[i, j] < 0)
                    matrix[i, j] += _alphabet.Length;
            }
        }
    }
}