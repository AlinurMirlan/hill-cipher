using MathNet.Numerics.LinearAlgebra;

namespace HillCipher.Library;

public class HillCipherCracker
{
    private Dictionary<char, int> _letterIndexLookup;
    private char[] _alphabet;
    private readonly HillMatrixOperation _hillOperation;
    private readonly MatrixBuilder<double> _matrixBuilder = Matrix<double>.Build;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public HillCipherCracker(char[] alphabet)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        Alphabet = alphabet;
        _hillOperation = new HillMatrixOperation(alphabet);
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

    public double[,] ExtractKey(string originalExcerpt, string decryptedExcerpt)
    {
        if (originalExcerpt.Length != decryptedExcerpt.Length)
            throw new ArgumentException($"The length of the {originalExcerpt} and {decryptedExcerpt} must match.");

        if (Math.Sqrt(originalExcerpt.Length) % 1 != 0)
            throw new ArgumentException($"{originalExcerpt}'s lenght must be perfect square.");

        int dimension = (int)Math.Sqrt(originalExcerpt.Length);
        Matrix<double> originialMatrix = _matrixBuilder.DenseOfArray(GetLetterIndices(originalExcerpt, dimension));
        ValidateOriginalMatrix(originialMatrix);

        Matrix<double> decryptedMatrix = _matrixBuilder.DenseOfArray(GetLetterIndices(decryptedExcerpt, dimension));
        Matrix<double> originalInverse = _hillOperation.Inverse(originialMatrix);
        Matrix<double> keyMatrix = decryptedMatrix * originalInverse % _alphabet.Length;
        return keyMatrix.AsTwoDimensionalArray();
    }

    private void ValidateOriginalMatrix(Matrix<double> matrix)
    {
        int determinant = (int)Math.Round(matrix.Determinant()) % _alphabet.Length;
        if (determinant == 0)
            throw new ArgumentException($"Original excerpt's dimensions must be invertibe.");

        if (determinant < 0)
            determinant += _alphabet.Length;
        if (Gcd.CommonDivisor(determinant, _alphabet.Length) != 1)
            throw new ArgumentException($"Determinant of the original excerpt must be coprime to the alphabet length.");
    }

    private double[,] GetLetterIndices(string message, int dimension)
    {
        double[,] letterIndices = new double[dimension, dimension];
        for (int i = 0; i < dimension; i++)
        {
            int row = i * dimension;
            for (int j = 0; j < dimension; j++)
            {
                char characer = message[row + j];
                if (_letterIndexLookup.TryGetValue(characer, out int index))
                    letterIndices[j, i] = index;
                else
                    throw new InvalidOperationException("Message contains unknown, the ones not included in the alphabet, characters.");
            }
        }

        return letterIndices;
    }
}
