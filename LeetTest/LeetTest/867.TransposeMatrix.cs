//int[][] matrix = {
//    new int[] {1,2,3},
//    new int[] {4,5,6},
//    new int[] {7,8,9}
//};

int[][] matrix = {
    new int[] {1,2,3},
    new int[] {4,5,6}    
};


Transpose(matrix);

int[][] Transpose(int[][] matrix)
{
    int rows = matrix.Length;
    int cols = matrix[0].Length;

    var result = new int[cols][];

    for (int i = 0; i < cols; i++)
    {
        result[i] = new int[rows];
        for (int j = 0; j < rows; j++)
        {
            result[i][j] = matrix[j][i];
        }
    }

    return result;
}