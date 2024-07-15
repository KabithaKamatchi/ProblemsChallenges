
namespace MatrixProgram;
public class Matrix
{
	public static void Solution()
	{
		//MatrixA
		Console.WriteLine("Enter the rows A : ");
		bool bIsSuccess1 = int.TryParse(Console.ReadLine(), out int nMatrixRowA);

		Console.WriteLine("Enter the Columns A: ");
		bool bIsSuccess2 = int.TryParse(Console.ReadLine(), out int nMatrixColA);

		int[,] nMatrixA = new int[nMatrixRowA, nMatrixColA];


		for(int i = 0; i < nMatrixRowA; i++)
		{
			for(int j = 0; j < nMatrixColA; j++)
			{
				Console.Write("Enter the elements MatrixA: ");
				bool bIsSuccess = int.TryParse(Console.ReadLine(), out nMatrixA[i, j]);

			}
		}

		Console.WriteLine("Matrix A: ");

		for(int i = 0; i < nMatrixRowA; i++)
		{
			for(int j = 0; j < nMatrixColA; j++)
			{
				Console.Write(nMatrixA[i, j] + " ");
			}

			Console.WriteLine();
		}

		//MatrixB
		Console.WriteLine("Enter the rows B : ");
		bool bIsSuccess3 = int.TryParse(Console.ReadLine(), out int nMatrixRowB);

		Console.WriteLine("Enter the Columns B: ");
		bool bIsSuccess4 = int.TryParse(Console.ReadLine(), out int nMatrixColB);

		int[,] nMatrixB = new int[nMatrixRowB, nMatrixColB];

		for(int i = 0; i < nMatrixRowB; i++)
		{
			for(int j = 0; j < nMatrixColB; j++)
			{
				Console.Write("Enter the elements MatrixB: ");
				bool bIsSuccess = int.TryParse(Console.ReadLine(), out nMatrixB[i, j]);
			}
		}

		Console.WriteLine("Matrix B: ");
		for(int i = 0; i < nMatrixRowB; i++)
		{
			for(int j = 0; j < nMatrixColB; j++)
			{
				Console.Write(nMatrixB[i, j] + " ");
			}

			Console.WriteLine();
		}

		//MatrixC
		Console.WriteLine("Enter the rows C: ");
		bool bIsSuccess5 = int.TryParse(Console.ReadLine(), out int nMatrixRowC);

		Console.WriteLine("Enter the Columns C: ");
		bool bIsSuccess6 = int.TryParse(Console.ReadLine(), out int nMatrixColC);

		int[,] nMatrixC = new int[nMatrixRowC, nMatrixColC];

		for(int i = 0; i < nMatrixRowC; i++)
		{
			for(int j = 0; j < nMatrixColC; j++)
			{
				Console.Write("Enter the elements MatrixC: ");
				bool bIsSuccess = int.TryParse(Console.ReadLine(), out nMatrixC[i, j]);
			}
		}
		Console.WriteLine("MatrixC: ");
		for(int i = 0; i < nMatrixRowC; i++)
		{
			for(int j = 0; j < nMatrixColC; j++)
			{
				Console.Write(nMatrixC[i, j] + " ");
			}

			Console.WriteLine();
		}
		Console.WriteLine();


		//Matrix Mutiplication of nMatrixA * nMatrixB
		int[,] MatrixAB = new int[nMatrixA.GetLength(0), nMatrixB.GetLength(1)];
		for(int i = 0; i < nMatrixA.GetLength(0); i++)
		{
			for(int j = 0; j < nMatrixB.GetLength(1); j++)
			{
				MatrixAB[i, j] = 0;
				for(int k = 0; k < nMatrixA.GetLength(1); k++)
				{
					MatrixAB[i, j] = MatrixAB[i, j] + nMatrixA[i, k] * nMatrixB[k, j];
				}

			}
		}
		Console.WriteLine("MatrixAB: ");
		for(int i = 0; i < MatrixAB.GetLength(0); i++)
		{
			for(int j = 0; j < MatrixAB.GetLength(1); j++)
			{
				Console.Write($"{MatrixAB[i, j]} ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();


		//Matrix Multiplication of MatrixAB * nMatrixC

		int[,] MatrixABC = new int[MatrixAB.GetLength(0), nMatrixC.GetLength(1)];
		for(int i = 0; i < MatrixAB.GetLength(0); i++)
		{
			for(int j = 0; j < nMatrixC.GetLength(1); j++)
			{
				MatrixABC[i, j] = 0;
				for(int k = 0; k < MatrixAB.GetLength(1); k++)
				{
					MatrixABC[i, j] = MatrixABC[i, j] + MatrixAB[i, k] * nMatrixC[k, j];
				}
			}
		}


		Console.WriteLine("Matrix ABC : ");
		for(int i = 0; i < MatrixABC.GetLength(0); i++)
		{
			for(int j = 0; j < MatrixABC.GetLength(1); j++)
			{
				Console.Write($"{MatrixABC[i, j]} ");
			}
			Console.WriteLine();
		}

		//LHS Determinant of ABC
		int detMatrixABC = 0;
		Console.WriteLine("Determinant of ABC : ");
		for(int i = 0; i < MatrixABC.Length; i++)
		{
			detMatrixABC = MatrixABC[0, 0] * (MatrixABC[1, 1] * MatrixABC[2, 2] - MatrixABC[1, 2] * MatrixABC[2, 1])
						   - MatrixABC[0, 1] * (MatrixABC[1, 0] * MatrixABC[2, 2] - MatrixABC[1, 2] * MatrixABC[2, 0])
						   + MatrixABC[0, 2] * (MatrixABC[1, 0] * MatrixABC[2, 1] - MatrixABC[1, 1] * MatrixABC[2, 0]);


		}
		Console.WriteLine($" {detMatrixABC}");



		//Determinant MatrixA
		int detMatrixA = 0;
		Console.WriteLine("Determinant of A : ");
		for(int i = 0; i < nMatrixRowA; i++)
		{

			detMatrixA = nMatrixA[0, 0] * (nMatrixA[1, 1] * nMatrixA[2, 2] - nMatrixA[1, 2] * nMatrixA[2, 1])
						   - nMatrixA[0, 1] * (nMatrixA[1, 0] * nMatrixA[2, 2] - nMatrixA[1, 2] * nMatrixA[2, 0])
						   + nMatrixA[0, 2] * (nMatrixA[1, 0] * nMatrixA[2, 1] - nMatrixA[1, 1] * nMatrixA[2, 0]);


		}
		Console.WriteLine($" {detMatrixA}");


		//Determinant MatrixB
		int detMatrixB = 0;
		Console.WriteLine("Determinant of B : ");
		for(int i = 0; i < nMatrixRowB; i++)
		{

			detMatrixB = nMatrixB[0, 0] * (nMatrixB[1, 1] * nMatrixB[2, 2] - nMatrixB[1, 2] * nMatrixB[2, 1])
						 - nMatrixB[0, 1] * (nMatrixB[1, 0] * nMatrixB[2, 2] - nMatrixB[1, 2] * nMatrixB[2, 0])
						 + nMatrixB[0, 2] * (nMatrixB[1, 0] * nMatrixB[2, 1] - nMatrixB[1, 1] * nMatrixB[2, 0]);

		}
		Console.WriteLine($" {detMatrixB}");

		//Determinant MatrixC

		int detMatrixC = 0;
		Console.WriteLine("Determinant of C: ");
		for(int i = 0; i < nMatrixRowB; i++)
		{

			detMatrixC = nMatrixC[0, 0] * (nMatrixC[1, 1] * nMatrixC[2, 2] - nMatrixC[1, 2] * nMatrixC[2, 1])
						 - nMatrixC[0, 1] * (nMatrixC[1, 0] * nMatrixC[2, 2] - nMatrixC[1, 2] * nMatrixC[2, 0])
						 + nMatrixC[0, 2] * (nMatrixC[1, 0] * nMatrixC[2, 1] - nMatrixC[1, 1] * nMatrixC[2, 0]);

		}
		Console.WriteLine($" {detMatrixC}");

		//Multiple of  detMatrixA and detMatrixB
		int productOfDeterminantsAB = detMatrixA * detMatrixB;
		Console.WriteLine($"Product of Determinants AB: {productOfDeterminantsAB}");


		//Multiple of ProductDeterminantAB & detMatrixC

		int nResultDeterminant = productOfDeterminantsAB * detMatrixC;
		Console.WriteLine($"nResultDeterminant : {nResultDeterminant}");


		Console.WriteLine($"LHS:{detMatrixABC}");
		Console.WriteLine($"RHS:{nResultDeterminant}");

	}
}

		//// Calculating adjugates
		//int[,] adjA = Adjugate(nMatrixA);
		//Console.WriteLine("Adjugate of A: ");
		

		//int[,] adjB = Adjugate(nMatrixB);
		//Console.WriteLine("Adjugate of B: ");
		

		//int[,] adjC = Adjugate(nMatrixC);
		//Console.WriteLine("Adjugate of C: ");
		

		//int[,] adjABC = Adjugate(MatrixABC);
		//Console.WriteLine("Adjugate of ABC: ");
		

		// static int[,] Adjugate(int[,] matrix)
		//{
		//	int[,] adjugate = new int[matrix.GetLength(0), matrix.GetLength(1)];

		//	for(int i = 0; i < matrix.GetLength(0); i++)
		//	{
		//		for(int j = 0; j < matrix.GetLength(1); j++)
		//		{
		//			int[,] minor = GetMinor(matrix, i, j);
		//			int minorDeterminant = Determinant(minor);
		//			adjugate[i, j] = (int) Math.Pow(-1, i + j) * minorDeterminant;
		//		}
		//	}

		//	// Transpose to get adjugate
		//	adjugate = Transpose(adjugate);

		//	return adjugate;
		//}

		//// Function to get the minor of a matrix
		// static int[,] GetMinor(int[,] matrix, int row, int col)
		//{
		//	int[,] minor = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
		//	int m = 0, n = 0;

		//	for(int i = 0; i < matrix.GetLength(0); i++)
		//	{
		//		for(int j = 0; j < matrix.GetLength(1); j++)
		//		{
		//			if(i != row && j != col)
		//			{
		//				minor[m, n] = matrix[i, j];
		//				n++;
		//				if(n == matrix.GetLength(1) - 1)
		//				{
		//					n = 0;
		//					m++;
		//				}
		//			}
		//		}
		//	}

		//	return minor;
		//}

		//// Function to transpose a matrix
		// static int[,] Transpose(int[,] matrix)
		//{
		//	int rows = matrix.GetLength(0);
		//	int cols = matrix.GetLength(1);
		//	int[,] transposed = new int[cols, rows];

		//	for(int i = 0; i < cols; i++)
		//	{
		//		for(int j = 0; j < rows; j++)
		//		{
		//			transposed[i, j] = matrix[j, i];
		//		}
		//	}

		//	return transposed;
		//}
//	}
//}








	

