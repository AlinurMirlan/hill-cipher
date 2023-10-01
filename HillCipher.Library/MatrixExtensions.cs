﻿using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HillCipher.Library;

public static class MatrixExtensions
{
    public static Matrix<double> Adjugate(this Matrix<double> matrix)
    {
        MatrixBuilder<double> builder = Matrix<double>.Build;
        if (matrix.RowCount != matrix.ColumnCount)
            throw new ArgumentException("Matrix ought to be square.");

        int dimension = matrix.RowCount;
        LinkedList<double> adjugateValues = new();
        for (int i = 0; i < dimension; i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                adjugateValues.AddLast(Math.Pow(-1, i + j) * matrix.Cofactor(i, j).Determinant());
            }
        }

        return builder.DenseOfRowMajor(dimension, dimension, adjugateValues).Transpose();
    }

    private static Matrix<double> Cofactor(this Matrix<double> matrix, int row, int column)
    {
        MatrixBuilder<double> builder = Matrix<double>.Build;
        int dimension = matrix.RowCount;
        LinkedList<double> cofactorValues = new();
        for (int k = 0; k < dimension; k++)
        {
            if (k == row)
                continue;

            for (int l = 0; l < dimension; l++)
            {
                if (l == column)
                    continue;

                cofactorValues.AddLast(matrix[k, l]);
            }
        }

        int lowerDimension = dimension - 1;
        return builder.DenseOfRowMajor(lowerDimension, lowerDimension, cofactorValues);
    }
}