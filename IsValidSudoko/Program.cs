public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] columns = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];

        for (int m = 0; m < 9; m++)
        {
            rows[m] = new HashSet<char>();
            columns[m] = new HashSet<char>();
            boxes[m] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {

                char value = board[i][j];
                int boxNum = (i / 3) * 3 + (j / 3);

                if (board[i][j] == '.')
                {
                    continue;
                }
                if (rows[i].Contains(value) || columns[j].Contains(value) || boxes[boxNum].Contains(value))
                {
                    return false;
                }
                rows[i].Add(value);
                columns[j].Add(value);

                boxes[boxNum].Add(value);


            }
        }
        return true;
    }
}
