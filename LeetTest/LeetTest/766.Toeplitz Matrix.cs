//int[][] matrix = {
//	new int[] {1,2,3, 4},
//	new int[] {5,1,2,3 },
//	new int[] {9,5,1,2}
//};

int[][] matrix = {
	new int[] {1,2},
	new int[] {2,2 },
};

IsToeplitzMatrix(matrix);

bool IsToeplitzMatrix(int[][] matrix)
{
	var rows = matrix.Length;
	var cols = matrix[0].Length;

	for (int i = 1; i < rows; i++)
	{
		for (int j = 1; j < cols; j++)
		{
			if (matrix[i][j] != matrix[i - 1][j - 1])
				return false;
		}
	}

	return true;
}