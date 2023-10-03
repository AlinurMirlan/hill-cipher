using MathNet.Numerics.LinearAlgebra;

namespace HillCipher.Library;

public class HillMatrixOperation
{
    private char[] _alphabet;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public HillMatrixOperation(char[] alphabet)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        Alphabet = alphabet;
    }

    public char[] Alphabet
    {
        get => _alphabet;
        set
        {
            if (value.Length <= 0)
                throw new ArgumentException($"{nameof(Alphabet)} must not be empty.");

            _alphabet = value;
        }
    }

    public Matrix<double> Inverse(Matrix<double> key)
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
