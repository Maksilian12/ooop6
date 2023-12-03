using System;

public class MathOperations
{
    // Перевантажений метод для додавання двох чисел
    public T Add<T>(T a, T b)
    {
        dynamic num1 = a;
        dynamic num2 = b;
        return num1 + num2;
    }

    // Перевантажений метод для віднімання двох чисел
    public T Subtract<T>(T a, T b)
    {
        dynamic num1 = a;
        dynamic num2 = b;
        return num1 - num2;
    }

    // Перевантажений метод для множення двох чисел
    public T Multiply<T>(T a, T b)
    {
        dynamic num1 = a;
        dynamic num2 = b;
        return num1 * num2;
    }

    // Перевантажений метод для додавання елементів масивів
    public T[] Add<T>(T[] arr1, T[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        T[] result = new T[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = Add(arr1[i], arr2[i]);
        }
        return result;
    }

    // Перевантажений метод для віднімання елементів масивів
    public T[] Subtract<T>(T[] arr1, T[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        T[] result = new T[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = Subtract(arr1[i], arr2[i]);
        }
        return result;
    }

    // Перевантажений метод для множення елементів масивів
    public T[] Multiply<T>(T[] arr1, T[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            throw new ArgumentException("Arrays must have the same length.");
        }

        T[] result = new T[arr1.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            result[i] = Multiply(arr1[i], arr2[i]);
        }
        return result;
    }

    // Перевантажений метод для додавання елементів матриць
    public T[,] Add<T>(T[,] matrix1, T[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        T[,] result = new T[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = Add(matrix1[i, j], matrix2[i, j]);
            }
        }

        return result;
    }

    // Перевантажений метод для віднімання елементів матриць
    public T[,] Subtract<T>(T[,] matrix1, T[,] matrix2)
    {
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new ArgumentException("Matrices must have the same dimensions.");
        }

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        T[,] result = new T[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = Subtract(matrix1[i, j], matrix2[i, j]);
            }
        }

        return result;
    }

    // Перевантажений метод для множення елементів матриць
    public T[,] Multiply<T>(T[,] matrix1, T[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            throw new ArgumentException("Number of columns in the first matrix must be equal to the number of rows in the second matrix.");
        }

        int rowsA = matrix1.GetLength(0);
        int colsA = matrix1.GetLength(1);
        int colsB = matrix2.GetLength(1);

        T[,] result = new T[rowsA,
