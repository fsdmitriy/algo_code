int[][] matrix = {
    new int[] {1,2},
    new int[] {3,4 }
};

MatrixReshape(matrix, 4, 1);

int[][] MatrixReshape(int[][] mat, int r, int c)
{
    var rows = mat.Length;
    var cols = mat[0].Length;

    if (rows * cols != r * c)
        return mat;

    var arr = new int[r][];

    int curr_row = 0, curr_col = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (curr_col == 0)
                arr[curr_row] = new int[c];

            arr[curr_row][curr_col++] = mat[i][j];

            if (curr_col == c)
            {
                curr_row++;
                curr_col = 0;
            }
        }
    }

    return arr;
}