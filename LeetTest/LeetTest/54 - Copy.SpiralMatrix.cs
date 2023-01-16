
int[][] matrix = {
	new int[] {1, 2, 3, 4 },
	new int[] {5, 6, 7, 8 },
	new int[] {9, 10, 11, 12}
};

SpiralOrder(matrix);

IList<int> SpiralOrder(int[][] matrix)
{
	var rows = matrix.Length;
	var cols = matrix[0].Length;

	var result = new int[rows * cols];

	int indx = 0, row_begin = 0, row_end = rows-1, col_begin = 0, col_end = cols-1;

	while(row_begin<=row_end && col_begin <= col_end)
	{
		//traverse rigth
		for (int i = col_begin; i <=col_end; i++)
			result[indx++] = matrix[row_begin][i];
		row_begin++;

		//traverse down
		for (int i = row_begin; i <= row_end; i++)
			result[indx++] = matrix[i][col_end];
		col_end--;
		
		//traverse left
		if(row_begin<=row_end)
			for (int i = col_end; i >= col_begin; i--)
				result[indx++] = matrix[row_end][i];
		row_end--;

		//traverse up
		if(col_begin<=col_end)
			for (int i = row_end; i >= row_begin; i--)
				result[indx++] = matrix[i][col_begin];
		col_begin++;
	}
	

	return result;
}