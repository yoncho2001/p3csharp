using System;
using validate;
using System.Reflection;


public class Matrix<T> where T : IComparable
{
    private T[,] data;
    private int rowsData;
    private int columnsData;

    public Matrix(int rows, int columns, bool check = false)
    {
        this.data = new T[rows, columns];
        this.rowsData = rows;
        this.columnsData = columns;

        if (check)
        {
            for (int i = 0; i < rows; i++)
            {
                string[] elements = Console.ReadLine().Split(' ');

                for (int j = 0; j < columns; j++)
                {
                    this.data[i, j] = (T)Convert.ChangeType(elements[j], typeof(T));
                }
            }
        }
    }

    public Matrix(T[,] data)
    {
        this.data = new T[data.GetLength(0), data.GetLength(1)];
        this.rowsData = data.GetLength(0);
        this.columnsData = data.GetLength(1);

        for (int i = 0; i < rowsData; i++)
        {
            for (int j = 0; j < columnsData; j++)
            {
                this.data[i, j] = data[i, j];
            }
        }
    }

    public T this[int row, int column]
    {
        get
        {
            return data[row, column];
        }
        set
        {
            data[row, column] = value;
        }
    }

    public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.rowsData != matrix2.rowsData || matrix1.columnsData != matrix2.columnsData)
        {
            throw new("Matrixes must be of the same size to make this operation");
        }

        Matrix<T> result = new Matrix<T>(matrix1.rowsData, matrix1.columnsData);

        for (int i = 0; i < matrix1.rowsData; i++)
        {
            for (int j = 0; j < matrix1.columnsData; j++)
            {
                var covert1 = Convert.ToDouble(matrix1[i, j]);
                var convert = Convert.ToDouble(matrix2[i, j]);
                result[i, j] = (T)(dynamic)(covert1 + convert);
            }
        }

        return result;
    }

    public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.rowsData != matrix2.rowsData || matrix1.columnsData != matrix2.columnsData)
        {
            throw new("Matrixes must be of the same size to make this operation");
        }

        Matrix<T> result = new Matrix<T>(matrix1.rowsData, matrix1.columnsData);

        for (int i = 0; i < matrix1.rowsData; i++)
        {
            for (int j = 0; j < matrix1.columnsData; j++)
            {
                var covert1 = Convert.ToDouble(matrix1[i, j]);
                var convert = Convert.ToDouble(matrix2[i, j]);
                result[i, j] = (T)(dynamic)(covert1 - convert);
            }
        }

        return result;
    }

    public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
    {
        if (matrix1.columnsData != matrix2.rowsData)
        {
            throw new("Number of columns in the first matrix must equal the number of rows in the second matrix to make this operation");
        }

        Matrix<T> result = new Matrix<T>(matrix1.rowsData, matrix2.columnsData);

        for (int i = 0; i < matrix1.rowsData; i++)
        {
            for (int j = 0; j < matrix2.columnsData; j++)
            {
                double sum = 0;
                
                for (int k = 0; k < matrix1.columnsData; k++)
                {
                    var covert1 = Convert.ToDouble(matrix1[i, k]);
                    var convert2 = Convert.ToDouble(matrix2[k, j]);
                    sum += covert1 * convert2;
                }
                result[i, j] = (T)(dynamic)(sum);
            }
        }

        return result;
    }

    public static bool operator true(Matrix<T> matrix)
    {
        return HaveZero(matrix);
    }

    public static bool operator false(Matrix<T> matrix)
    {
        return !HaveZero(matrix);
    }

    public static bool HaveZero(Matrix<T> matrix)
    {
        for (int i = 0; i < matrix.rowsData; i++)
        {
            for (int j = 0; j < matrix.columnsData; j++)
            {
                if (matrix[i, j].CompareTo(0) != 0)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public override string ToString()
    {
        string output = "";
        for (int i = 0; i < rowsData; i++)
        {
            for (int j = 0; j < columnsData; j++)
            {
                output += data[i, j] + " ";
            }

            output += "\n";
        }

        return output;
    }
}