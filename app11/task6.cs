using functions;

namespace task6
{
    public class Matrix
    {
        private int[,] data;
        private int rowsData;
        private int columnsData;

        public Matrix(int rows, int columns, bool check = false)
        {
            this.data = new int[rows, columns];
            this.rowsData = rows;
            this.columnsData = columns;

            if (check)
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] elements = Console.ReadLine().Split(' ');

                    for (int j = 0; j < columns; j++)
                    {
                        this.data[i, j] = int.Parse(elements[j]);
                    }
                }
            }
        }

        public int this[int row, int column]
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

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1.rowsData != m2.rowsData || m1.columnsData != m2.columnsData)
            {
                Console.WriteLine("Matrices must be of the same size to make this operation");
                return m1;
            }

            Matrix result = new Matrix(m1.rowsData, m1.columnsData);

            for (int i = 0; i < m1.rowsData; i++)
            {
                for (int j = 0; j < m1.columnsData; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if (m1.rowsData != m2.rowsData || m1.columnsData != m2.columnsData)
            {
                Console.WriteLine("Matrices must be of the same size to make this operation");
                return m1;
            }

            Matrix result = new Matrix(m1.rowsData, m1.columnsData);

            for (int i = 0; i < m1.rowsData; i++)
            {
                for (int j = 0; j < m1.columnsData; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if (m1.columnsData != m2.rowsData)
            {
                Console.WriteLine("Number of columns in the first matrix must equal the number of rows in the second matrix to make this operation");
                return m1;
            }

            Matrix result = new Matrix(m1.rowsData, m1.columnsData);

            for (int i = 0; i < m1.rowsData; i++)
            {
                for (int j = 0; j < m2.columnsData; j++)
                {
                    for (int k = 0; k < m1.columnsData; k++)
                    {
                        result[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }

            return result;
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
}